namespace LinkedListDll;

public class NotSortedException : Exception
{
    public NotSortedException() {}
    public NotSortedException(string message) : base(message) {}
}