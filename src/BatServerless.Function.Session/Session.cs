// using Amazon.DynamoDBv2.DataModel;

// namespace BatServerless.Function.Session;

// [DynamoDBTable("Session")]
// public class Session : ICreateAudit<Guid>, IUpdateAudit<Guid>
// {
//     [DynamoDBHashKey]
//     [DynamoDBGlobalSecondaryIndexRangeKey("BeginTimeAndId")]
//     public Guid Id { get; set; }
//     [DynamoDBRangeKey]
//     [DynamoDBGlobalSecondaryIndexHashKey("BeginTimeAndId")]
//     public DateTime BeginTime { get; set; }
//     public DateTime EndTime { get; set; }
//     public DateTime CreateTime { get; set; }
//     public Guid CreateBy { get; set; }
//     public DateTime UpdateTime { get; set; }
//     public Guid UpdateBy { get; set; }
// }
