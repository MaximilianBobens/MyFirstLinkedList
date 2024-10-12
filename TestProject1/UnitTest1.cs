using LinkedListDll;

namespace NUnitTest;

public class Tests
{
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Append()
    {
        MyLinkedList list = new MyLinkedList();
        list.Append(3);
        list.Append(5);
        list.Append(7);
        list.PrintList();
        
        string result = list.GetList();
        Assert.That(result, Is.EqualTo("3 - 5 - 7"));
    }
    
    [Test]
    public void Test_InsertFront()
    {
        MyLinkedList list = new MyLinkedList();
        list.Append(3);
        list.Append(5);
        list.InsertFront(7);
        list.PrintList();
        
        string result = list.GetList();
        Assert.That(result, Is.EqualTo("7 - 3 - 5"));
    }
    
    [Test]
    public void Test_FindMin()
    {
        MyLinkedList list = new MyLinkedList();
        list.Append(3);
        list.Append(5);
        list.Append(7);
        list.Append(1);
        list.PrintList();
        
        var result = list.FindMin();
        Assert.That(result.Data, Is.EqualTo(1));
    }
    
    [Test]
    public void Test_FindMax()
    {
        MyLinkedList list = new MyLinkedList();
        list.Append(3);
        list.Append(5);
        list.Append(7);
        list.Append(1);
        list.PrintList();

        var result = list.FinMax(); // Corrected method name
        Assert.That(result.Data, Is.EqualTo(7));
    }
    
    [Test]
    public void Test_InsertSorted()
    {
        MyLinkedList list = new MyLinkedList();
        list.InsertSorted(3);
        list.InsertSorted(5);
        list.InsertSorted(7);
        list.InsertSorted(1);
        list.PrintList();
        
        Assert.That(list.IsSorted(), Is.True);
    }
    
    [Test]
    public void Test_Recursive_Print()
    {
        MyLinkedList list = new MyLinkedList();
        list.Append(3);
        list.Append(5);
        list.Append(7);
        list.Append(1);

        list.PrintRec();
    }
    
    [Test]
    public void Test_Recursive_Reverse_Print()
    {
        MyLinkedList list = new MyLinkedList();
        list.Append(3);
        list.Append(5);
        list.Append(7);
        list.Append(1);

        list.PrintReverseRec();
    }
    
    [Test]
    public void Test_Recursive_Min()
    {
        MyLinkedList list = new MyLinkedList();
        list.Append(3);
        list.Append(5);
        list.Append(7);
        list.Append(1);

        var result = list.FinMinRec(); // Corrected method name
        Assert.That(result.Data, Is.EqualTo(1));
    }
    
    [Test]
    public void Test_Recursive_Max()
    {
        MyLinkedList list = new MyLinkedList();
        list.Append(3);
        list.Append(5);
        list.Append(7);
        list.Append(1);

        var result = list.FinMaxRec(); // Corrected method name
        Assert.That(result.Data, Is.EqualTo(7));
    }
    
    [Test]
    public void Test_Recursive_Append()
    {
        MyLinkedList list = new MyLinkedList();
        list.AppendRec(3);
        list.AppendRec(5);
        list.AppendRec(7);
        list.AppendRec(1);
        list.PrintList();
        
        var result = list.GetList();
        Assert.That(result, Is.EqualTo("3 - 5 - 7 - 1"));
    }
    
    [Test]
    public void Test_Sort()
    {
        MyLinkedList list = new MyLinkedList();
        list.AppendRec(3);
        list.AppendRec(5);
        list.AppendRec(7);
        list.AppendRec(1);
        list.PrintList();
        
        Assert.That(list.IsSorted(), Is.False);
        list.Sort();
        Assert.That(list.IsSorted(), Is.True);
    }
}
