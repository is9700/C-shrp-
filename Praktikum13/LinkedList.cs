namespace Praktikum13;
using System;

public class LinkedList<T>
{
    class Element
    {
        public T Value { get; }
        public Element Next { get; set; }

        public Element(T value, Element next = null)
        {
            Value = value;
            Next = next;
        }
    // Element a= new Element(head ); tjii w next initialisé null
    //Element b=new Element(head,second)tji zeda
    }

    class ListIterator : Iterator<T>
    {
        private Element current;

        public ListIterator(Element head)
        {
            current = head;
        }

     
        public bool? hasNext()
        {
             return current != null;
        }

       

        public T next()
        {
           T value = current.Value;
            current = current.Next;
            return value;
        }

       public T  Next()
        {
            T value = current.Value;
            current = current.Next;
            return value;
        }
    }

    private Element head;
    private Element tail;
    private int Count{get;
    set ;}
     //   public Element this[int pos] GHALTA
    public T this[int pos]
    {  
        set{
             if(Count<pos)
            {
                throw new IndexOutOfRangeException();
            }
            else{  Element current=head;
            int i=pos;
            while(i>0)
            {
                current=current.Next;
                i--;
            }
            if (!(value is T)) throw new Exception();
            Append(value); /// insert f ekher list  

            }

        }
        get{
            if(Count<pos || pos<0)
            {
                throw new System.IndexOutOfRangeException();
            }
            
            Element current=head;
            int i=pos;
            while(i>0)
            {
                current=current.Next;
                i--;
            }
      
    return current.Value;
       
        }

    }

    public int Append(T value)
    {
        Element newElement = new Element(value);//next initialisé of null

        if (head == null)
            head = newElement;
        else
            tail.Next = newElement;

        tail = newElement;

        return 1;
    }


//to do!!
    public int Remove(int pos)
    {
        if (pos < 0 || head == null) return 0;

        System.Console.WriteLine("Removing an element...");

        Element current = head;
        Element previous = null;

        for (int i = 0; i < pos; i++)
        {
            if (current == tail) break;

            previous = current;
            current = current.Next;
        }

        if (current == head && current == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            if (current == head)
            {
                head = current.Next;
            }
            else
            {
                if (current == tail) tail = previous;

                previous.Next = current.Next;
            }
        }

        return 1;
    }

    public Iterator<T> Iterator()
    {
        return new ListIterator(head);
    }
}


