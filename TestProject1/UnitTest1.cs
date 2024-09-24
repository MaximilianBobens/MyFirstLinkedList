using LinkedListDll;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    [Test]
    public void Test_Append()
    {
        MyLinkedList list = new MyLinkedList();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        list.Append(4);
    }
}