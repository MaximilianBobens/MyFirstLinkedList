using System.Text; // Bibliothek für das Arbeiten mit Zeichenfolgen

namespace LinkedListDll;

// Klasse "MyLinkedList", die eine einfache verkettete Liste implementiert
public class MyLinkedList : IList
{
    // Eigenschaft "Head", die auf das erste Element (den Kopf) der Liste verweist
    public Node Head { get; set; }

    // Methode "Append", um einen neuen Knoten am Ende der Liste hinzuzufügen (Methode überladen)
    public void Append(Node n)
    {
        // Wenn die Liste leer ist (Head == null), wird der neue Knoten zum Kopf
        if (Head == null)
            Head = n;
        else
        {
            // Ansonsten durchlaufe die Liste, um den letzten Knoten zu finden
            Node temp = Head;
            while (temp.Next != null)
                temp = temp.Next;

            // Füge den neuen Knoten ans Ende der Liste an
            temp.Next = n;
        }
    }

    // Überladene Methode "Append", um Daten als Knoten hinzuzufügen, ohne direkt einen Knoten zu übergeben
    public void Append(int data)
    {
        // Erstellt einen neuen Knoten mit den übergebenen Daten und ruft die erste "Append"-Methode auf
        Node n = new Node(data);
        Append(n);
    }

    // Methode "InsertFront", um einen neuen Knoten am Anfang der Liste einzufügen
    public void InsertFront(Node n)
    {
        // Der neue Knoten wird zum Kopf und zeigt auf den alten Kopf
        if (n != null)
        {
            n.Next = Head;
            Head = n;
        }
    }

    // Überladene Methode "InsertFront", um Daten am Anfang hinzuzufügen
    public void InsertFront(int data)
    {
        // Erstellt einen neuen Knoten mit den übergebenen Daten und ruft die erste "InsertFront"-Methode auf
        Node n = new Node(data);
        InsertFront(n);
    }

    // Methode "PrintList", um den Inhalt der Liste auf der Konsole auszugeben
    public void PrintList()
    {
        // Wenn die Liste leer ist, wird eine Nachricht ausgegeben
        if (Head == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            // Die Liste wird durchlaufen und die Daten jedes Knotens werden ausgegeben
            Node temp = Head;
            while (temp != null)
            {
                Console.Write($"{temp.Data} ");

                // Wenn der nächste Knoten existiert, wird ein Pfeil "->" hinzugefügt
                if (temp.Next != null)
                    Console.Write("-> ");

                // Fortschalten zum nächsten Knoten
                temp = temp.Next;
            }
            Console.WriteLine(); // Zeilenumbruch nach dem Durchlaufen der Liste
        }
    }

    // Methode "GetList", die die Liste als Zeichenfolge zurückgibt, anstatt sie auf der Konsole auszugeben
    public string GetList()
    {
        StringBuilder sb = new StringBuilder(); // StringBuilder für die Zeichenfolgenmanipulation
        sb.Append(Head.Data); // Den Wert des Kopfes hinzufügen
        return sb.ToString(); // Zeichenfolge zurückgeben
    }

    // Methode "FindMin", um den Knoten mit dem kleinsten Wert zu finden
    public Node FindMin()
    {
        Node min = Head; // Setze den ersten Knoten als Minimum
        Node temp = Head;
        while (temp != null)
        {
            // Wenn der aktuelle Wert kleiner ist als das bisherige Minimum, wird der neue Knoten als Minimum gesetzt
            if (temp.Data < min.Data)
            {
                min = temp;
            }
            temp = temp.Next;

            // Ausgabe des aktuellen Minimums
            Console.WriteLine("Minimum: " + min.Data);
        }
        return min; // Rückgabe des minimalen Knotens
    }

    // Methode "FinMax", um den Knoten mit dem größten Wert zu finden
    public Node FinMax()
    {
        Node max = Head; // Setze den ersten Knoten als Maximum
        Node temp = Head;
        while (temp != null)
        {
            // Wenn der aktuelle Wert größer ist als das bisherige Maximum, wird der neue Knoten als Maximum gesetzt
            if (temp.Data > max.Data)
            {
                max = temp;
            }
            temp = temp.Next;
        }

        return max; // Rückgabe des maximalen Knotens
    }

    // Methode "Remove", die noch nicht implementiert ist
    public Node Remove()
    {
        throw new NotImplementedException(); // Ausnahme wird ausgelöst, da die Methode noch nicht implementiert wurde
    }

    // Methode "PrintRec", um die Liste rekursiv auszugeben
    public void PrintRec()
    {
        PrintRec(Head); // Rufe die private rekursive Methode auf, beginnend mit dem Kopf
        Console.WriteLine();
    }

    // Private rekursive Methode zum Ausgeben der Liste
    private void PrintRec(Node temp)
    {
        if (temp == null) // Basisfall: Wenn der aktuelle Knoten null ist, wird abgebrochen
        {
            return;
        }
        Console.Write(temp.Data + "\t"); // Daten des aktuellen Knotens ausgeben
        PrintRec(temp.Next); // Rufe die Methode für den nächsten Knoten auf
    }

    // Methode "PrintReverseRec", um die Liste rekursiv in umgekehrter Reihenfolge auszugeben
    public void PrintReverseRec()
    {
        PrintReverseRec(Head); // Rufe die private rekursive Methode auf, beginnend mit dem Kopf
        Console.WriteLine();
    }

    // Private rekursive Methode zum Ausgeben der Liste in umgekehrter Reihenfolge
    private void PrintReverseRec(Node temp)
    {
        if (temp == null) // Basisfall: Wenn der aktuelle Knoten null ist, wird abgebrochen
        {
            return;
        }
        PrintReverseRec(temp.Next); // Rufe die Methode für den nächsten Knoten auf
        Console.Write(temp.Data + "\t"); // Daten des aktuellen Knotens ausgeben
    }

    // Methode "FinMinRec", um den Knoten mit dem kleinsten Wert rekursiv zu finden
    public Node FinMinRec()
    {
        return FindMinRec(Head, Head); // Rufe die private rekursive Methode auf, beginnend mit dem Kopf
    }

    // Private rekursive Methode, um den Knoten mit dem kleinsten Wert zu finden
    private Node FindMinRec(Node temp, Node min)
    {
        if (temp == null) // Basisfall: Wenn der aktuelle Knoten null ist, wird das Minimum zurückgegeben
        {
            return min;
        }
        if (temp.Data < min.Data) // Aktualisiere das Minimum, wenn der aktuelle Wert kleiner ist
        {
            min = temp;
        }
        return FindMinRec(temp.Next, min); // Rekursiver Aufruf mit dem nächsten Knoten
    }

    // Methode "FinMaxRec", um den Knoten mit dem größten Wert rekursiv zu finden
    public Node FinMaxRec()
    {
        return FindMaxRec(Head, Head); // Rufe die private rekursive Methode auf, beginnend mit dem Kopf
    }

    // Private rekursive Methode, um den Knoten mit dem größten Wert zu finden
    private Node FindMaxRec(Node temp, Node max)
    {
        if (temp == null) // Basisfall: Wenn der aktuelle Knoten null ist, wird das Maximum zurückgegeben
        {
            return max;
        }
        if (temp.Data > max.Data) // Aktualisiere das Maximum, wenn der aktuelle Wert größer ist
        {
            max = temp;
        }
        return FindMaxRec(temp.Next, max); // Rekursiver Aufruf mit dem nächsten Knoten
    }

    // Rekursive Methode "AppendRec", um einen neuen Knoten ans Ende der Liste anzuhängen
    public void AppendRec(Node n)
    {
        if (Head == null) // Wenn die Liste leer ist, wird der neue Knoten zum Kopf
        {
            Head = n;
        }
        else
        {
            AppendRec(n, Head); // Rufe die rekursive Methode auf, beginnend mit dem Kopf
        }
    }

    // Überladene rekursive Methode "AppendRec", um Daten hinzuzufügen
    public void AppendRec(int data)
    {
        AppendRec(new Node(data)); // Erstellt einen neuen Knoten und ruft die Methode auf
    }

    // Private rekursive Methode zum Anhängen eines Knotens ans Ende der Liste
    private void AppendRec(Node n, Node temp)
    {
        if (temp.Next != null) // Wenn es noch einen weiteren Knoten gibt, weiter zum nächsten Knoten
        {
            AppendRec(n, temp.Next);
        }
        else
        {
            temp.Next = n; // Füge den neuen Knoten ans Ende der Liste an
        }
    }

    // Methode "Find", um einen bestimmten Wert in der Liste zu finden
    public Node Find(int number)
    {
        Node temp = Head; // Beginne mit dem Kopf
        while (temp != null)
        {
            if (temp.Data == number) // Wenn der Wert gefunden wurde, gebe den Knoten zurück
            {
                return temp;
            }

            temp = temp.Next; // Fortschalten zum nächsten Knoten
        }

        return null; // Wert wurde nicht gefunden
    }

    // Methode "InsertSorted", um einen neuen Knoten in die sortierte Liste einzufügen
    public void InsertSorted(int data)
    {
        InsertSorted(new Node(data)); // Erstellt einen neuen Knoten und ruft die Methode auf
    }

    // Methode "IsSorted", um zu überprüfen, ob die Liste sortiert ist
    public bool IsSorted()
    {
        Node temp = Head;
        bool isSorted = true;
        while (temp != null && temp.Next != null)
        {
            if (temp.Data < temp.Next.Data) // Wenn der aktuelle Wert kleiner ist als der nächste
            {
                temp = temp.Next; // Fortschalten zum nächsten Knoten
            }
            else
            {
                isSorted = false; // Die Liste ist nicht sortiert
                Console.WriteLine("Liste ist nicht sortiert");
                return isSorted;
            }
        }

        Console.WriteLine("Liste ist sortiert");
        return isSorted; // Die Liste ist sortiert
    }

    // Methode "InsertSorted", um einen neuen Knoten in die sortierte Liste einzufügen
    public void InsertSorted(Node n)
    {
        if (IsSorted()) // Überprüfen, ob die Liste sortiert ist
        {
            if (Head == null) // Wenn die Liste leer ist, wird der neue Knoten zum Kopf
            {
                Head = n;
            }
            else if (Head.Data > n.Data) // Wenn der neue Wert kleiner als der Kopf ist, einfügen am Anfang
            {
                InsertFront(n);
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null && temp.Next.Data < n.Data) // Suche die richtige Position für den Knoten
                {
                    temp = temp.Next;
                }
                n.Next = temp.Next; // Füge den neuen Knoten ein
                temp.Next = n;
            }
        }
        else
        {
            throw new NotSortedException("Not sorted"); // Ausnahme werfen, wenn die Liste nicht sortiert ist
        }
    }

    // Methode "Sort", um die Liste zu sortieren
    public void Sort()
    {
        MyLinkedList sorted = new MyLinkedList(); // Erstelle eine neue sortierte Liste
        Node min = this.FindMin(); // Finde den kleinsten Knoten
        while (min != null)
        {
            min = Remove(min); // Entferne den kleinsten Knoten
            sorted.Append(min); // Füge den Knoten der sortierten Liste hinzu
        }

        this.Head = sorted.Head; // Aktualisiere den Kopf der Liste
    }

    // Methode "Remove", um einen bestimmten Knoten aus der Liste zu entfernen
    public Node Remove(Node r)
    {
        if (Head == null) // Wenn die Liste leer ist, gebe eine Nachricht aus
        {
            Console.WriteLine("Liste ist leer");
            return null;
        }
        else if (r == null) // Wenn der zu entfernende Knoten null ist, gebe eine Nachricht aus
        {
            Console.WriteLine("Ungültiger Knoten");
            return null;
        }
        else
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Next == r) // Wenn der nächste Knoten der zu entfernende ist
                {
                    temp.Next = r.Next; // Entferne den Knoten, indem der Zeiger übersprungen wird
                    r.Next = null; // Setze den "Next"-Zeiger des zu entfernenden Knotens auf nulla
                    Console.WriteLine("Lösche " + r.Data);
                    return r;
                }
                temp = temp.Next; // Fortschalten zum nächsten Knoten
            }
            return null; // Knoten wurde nicht gefunden
        }
    }
}