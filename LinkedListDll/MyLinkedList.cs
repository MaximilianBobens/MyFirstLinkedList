namespace LinkedListDll;

public class MyLinkedList : IList
{
         // Eigenschaft "Head", die auf das erste Element (den Kopf) der Liste verweist.
        public Node Head { get; set; } 
        
        // Methode "Append", um einen neuen Knoten am Ende der Liste hinzuzufügen (Überladung 1).
        public void Append(Node n) 
        {
            // Wenn die Liste leer ist (Head == null), wird der neue Knoten zum Kopf.
            if (Head == null)
                Head = n;
            else
            {
                // Sonst wird die Liste durchlaufen, bis der letzte Knoten gefunden ist.
                Node temp = Head;
                while (temp.Next != null)
                    temp = temp.Next;

                // Der neue Knoten wird ans Ende angehängt.
                temp.Next = n;
            }
        }

        // Überladene Methode "Append", um Daten hinzuzufügen, ohne direkt einen Knoten zu übergeben (Überladung 2).
        public void Append(int data) 
        {
            // Erstellt einen neuen Knoten mit den übergebenen Daten und ruft die erste "Append"-Methode auf.
            Node n = new Node(data);
            Append(n);
        }

        // Methode "InsertFront", um einen neuen Knoten am Anfang der Liste einzufügen.
        public void InsertFront(Node n) 
        {
            // Der neue Knoten wird zum Kopf, und sein "Next"-Verweis zeigt auf den alten Kopf.
            if (n != null)
            {
                n.Next = Head;
                Head = n;
            }
        }

        // Überladene Methode "InsertFront", um Daten am Anfang hinzuzufügen.
        public void InsertFront(int data) 
        {
            // Erstellt einen neuen Knoten mit den übergebenen Daten und ruft die erste "InsertFront"-Methode auf.
            Node n = new Node(data);
            InsertFront(n);
        }

        // Methode "PrintList", um den Inhalt der Liste auf der Konsole auszugeben.
        public void PrintList() 
        {
            // Wenn die Liste leer ist, wird eine Nachricht ausgegeben.
            if (Head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                // Die Liste wird durchlaufen und die Daten jedes Knotens werden ausgegeben.
                Node temp = Head;
                while (temp != null)
                {
                    Console.Write($"{temp.Data} ");
                    
                    // Wenn der nächste Knoten existiert, wird ein Pfeil "->" hinzugefügt.
                    if (temp.Next != null)
                        Console.Write("-> ");

                    // Fortschalten zum nächsten Knoten.
                    temp = temp.Next; 
                }
                Console.WriteLine(); // Zeilenumbruch nach dem Durchlaufen der Liste.
            }
        }

        // Methode "GetList", die die Liste als String zurückgibt, anstatt sie auf der Konsole auszugeben.
        public string GetList() 
        {
            // Wenn die Liste leer ist, wird ein entsprechender String zurückgegeben.
            if (Head == null)
                return "List is empty";
            
            // Die Liste wird durchlaufen und die Daten werden in einem String zusammengefasst.
            Node temp = Head;  /* Erstellt eine temporäre Variable "temp", 
            die auf den ersten Knoten (Head) der Liste zeigt, 
            tium die Liste durchlaufen zu können, ohne den Wert von Head zu verändern.*/
            string result = "";
            while (temp != null)
            {
                result += $"{temp.Data}";
                
                // Wenn der nächste Knoten existiert, wird ein Pfeil "->" hinzugefügt.
                if (temp.Next != null)
                    result += " -> ";
                    
                // Fortschalten zum nächsten Knoten.
                temp = temp.Next;
            }

            // Der String mit den Daten der Liste wird zurückgegeben.
            return result;
    }
}
