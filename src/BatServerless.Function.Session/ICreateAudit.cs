namespace BatServerless.Function.Session;

public interface ICreateAudit<T>
{
    DateTime CreateTime { get; set; }
    T CreateBy { get; set; }
}