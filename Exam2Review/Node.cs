public class Node<T>
{
    private T data;
    private Node<T> next;

    public T Data
    {
        get{return this.data;}
        set{
            this.data = value;
        }
    }
    public Node<T> Next
    {
        get{return this.next;}
        set{
            this.next = value;
        }
    }

    public Node(T data, Node<T> next)
    {
        this.data = data;
        this.next = next;
    }

    public Node(T data):this(data, null)
    {

    }




    /**
        We will recursively show all data and the next data in the node
    **/
    public override string ToString()
    {
        //this is the base case. If the next is null then we will simply return the data and the next item as null  
        if(this.next is null)
            return this.data.ToString() + "-->null";
        
        //we will return the current data and recursively go through the next and add them the string
        return this.data.ToString() + "-->"+ this.next.ToString();
    }
}