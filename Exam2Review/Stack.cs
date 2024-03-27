


using System.Collections;

public class Stack<T> : IStack<T>, IEnumerable<T>
{
    //keep track of the number of elements on the stack
    private int count;
    //the top node with link of pointer(s) to every other elements
    private Node<T> top;
    //The constructor that initalize the top as null and count as 0
    //when we first create a new stack
    public Stack()
    {
        this.top = null;
        this.count = 0;
    }

    //a property that return the total elements on the stack
    public int Count
    {
        get{return count;}
    }

    public void Clear()
    {
        this.count = 0;
        this.top = null;
    }

    public bool Contains(T element)
    {
        //if the top element is null then there are no elements therefore 
        //the element is not on the stack
        if(this.top is null)
            return false;
        
        //store the current top as we dont want to modify the top directly
        //create a copy
        Node<T> current = top;
        //we will loop as long as we have not get to the end of the node (a null pointer)
        while(current is not null) {
            //check if the element on the stack match what we are searching for
            bool match  = EqualityComparer<T>.Default.Equals(element, current.Data);
            if(match)
                return true; // return true if we find a match
            
            current = current.Next; //otherwise we move the pointer and keep on searching
        }

        //return false if no match has been found
        return false;
        
    }

    public IEnumerator<T> GetEnumerator()
    {
        //make a copy of the top so we can loop over the copy without modifying the top
        Node<T> current = top;
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
   

    public T Peek()
    {
        //show the current top element without remove it
        return this.top.Data;
    }

    public T Pop()
    {
        //temporary store the current top data
        T data = this.top.Data;
        //set the next element on the stack as the new top
        top = top.Next;
        //decrease the number of elements on the stack
        count--;
        //return the old top
        return data;
    }

    public void Push(T element)
    {
        //store the current top as this will now go to the bottom
        Node<T> currentTop = top;
        //create a node for the new element and set the current top as the next pointer
        Node<T> node = new Node<T>(element,currentTop);
        //set the new node as top
        top = node;
        //increase the number of elements on the stack
        count++;
        
    }

    public T[] ToArray()
    {
       //create an array to hold the elements
       T[] elements = new T[count];
       int index = 0; // this is used used to insert the data at specific index

       //create a copy of the top and loop through copy
       //to avoid modify the original top
       Node<T> current = top;
       
       //loop through each of the pointrs
       while(current is not null){
        //add the data to the array
        elements[index] = current.Data;
        current = current.Next;//move the pointer to the next pointer
        index++; //update the index
       }

       return elements;//return the array elements
    }

    public override string ToString()
    {
        if(this.top is null)
            return "null";
            
        return this.top.ToString();
    }

 

  
}
