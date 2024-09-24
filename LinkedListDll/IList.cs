namespace LinkedListDll;

public interface IList
{
    Node Head { get;}
    void Append(Node n);
    void InsertFront(Node n);
    void PrintList();
    string GetList();
}