namespace BatServerless.Function.Session;

public interface IUpdateAudit<T>
{
    DateTime UpdateTime { get; set; }
    T UpdateBy { get; set; }
}