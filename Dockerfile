FROM public.ecr.aws/lambda/dotnet:6 AS base


FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim as common
WORKDIR /src/BatServerless.Common

# Copy csproj and restore as distinct layers
COPY ./src/BatServerless.Common/*.csproj .
RUN dotnet restore

COPY ./src/BatServerless.Common/. .

FROM common as build
ARG functionFolder
WORKDIR /src/$functionFolder
COPY ./src/$functionFolder/*.csproj .
RUN dotnet restore

COPY ./src/$functionFolder/. .
RUN dotnet build --configuration Release --output /app/build


FROM build AS publish
RUN dotnet publish \
    --configuration Release \ 
    --runtime linux-x64 \
    --self-contained false \ 
    --output /app/publish \
    -p:PublishReadyToRun=true  


FROM base AS final
WORKDIR /var/task
COPY --from=publish /app/publish .