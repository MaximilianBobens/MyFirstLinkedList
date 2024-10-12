namespace LinkedListDll;

public interface IList
{
    Node Head { get;}
    void Append(Node n);
    void InsertFront(Node n);
    void PrintList();
    string GetList();
    Node FindMin();
    Node FinMax();
    Node Remove();
    public void PrintRec();
    public void PrintReverseRec();
    public Node FinMinRec();
    public Node FinMaxRec();
    public void AppendRec(Node n);
    public void Sort();

}