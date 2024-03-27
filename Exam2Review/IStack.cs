public interface IStack<T>
{
    //the number of elements in the stack
    public int Count{get;}
    //reset the stack
    public void Clear();
    //check if an element is in the stack
    public bool Contains(T element);
    //show the current element at the top without remove it
    public T Peek();
    //remove and return the current element at the top
    public T Pop();
    //add an new element to the top of the stack
    public void Push(T element);
    //convert the elements in the stack to an array of elements
    public T[] ToArray();



}