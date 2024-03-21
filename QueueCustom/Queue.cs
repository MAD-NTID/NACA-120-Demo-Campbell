using System.Collections;

public class Queue<T> : IQueue<T>, IEnumerable<T>
{
    private int count;
    private Node<T> front;
    private Node<T> back;

    public int Count{
        get{
            return this.count;
        }
    }

    public Queue()
    {
        this.front = null;
        this.back = null;
        this.count = 0;
    }

    public void Clear()
    {
        this.front = null;
        this.back = null;
        this.count = 0;
    }

    public bool Contains(T element)
    {
        Node<T> current = this.front;
        while(current is not null) {
            bool match = EqualityComparer<T>.Default.Equals(element, current.Data);
            if(match)
                return true;
            
            current = current.Next;

        }

        return false;
    }

    public T Dequeue()
    {
        T data = this.front.Data;
        this.front = this.front.Next;
        count--;

        //if the front become null then the back must also be null
        if(this.front == null)
            this.back = null;
        
        return data;
    }

    public void Enqueue(T element)
    {
        Node<T> node = new Node<T>(element);
        count++;

        //there is currently nothing in the queue so both front and back are going to be the same
        if(this.front is null){
            this.front = this.back = node;

            return ;
        }

        this.back.Next = node;
        this.back = node;
    }

    public IEnumerator<T> GetEnumerator()
    {
        //make a copy of the front so we can loop over the copy without modifying the front
        Node<T> current = front;
        //This helps the Enumerator know that there is still more data on our node
        //as long as we have not hit a null
        while (current != null)
        {
            yield return current.Data; //yield (pass) the current Data to the IEnumerator
            current = current.Next;//move the pointer to the next element
        }
    }

    //Tell C# IEnumerator to use our GetEnumerator() that we built above
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public T[] ToArray()
    {
        T[] elements = new T[count];
        Node<T> current = this.front;
        int index = 0;

        while(current is not null) {
            elements[index] = current.Data;
            
            current = current.Next;
            index++;

        }

        return elements;
    }

    public T Peek()
    {
        //show the element current at the front without remove the element
        return this.front.Data;
    }

    public override string ToString()
    {
        if(this.front is null)
            return "null";
            
        return this.front.ToString();
    }
}
