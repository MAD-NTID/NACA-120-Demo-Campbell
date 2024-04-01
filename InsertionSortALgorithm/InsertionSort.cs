public class InsertionSort<T>
{
    public InsertionSort(){}

    public bool IsGreater(T element1, T element2)
    {
        return Comparer<T>.Default.Compare(element1,element2) > 0;
    }

    public T[] Sort(T[] elements)
    {
        for(int i = 1; i < elements.Length; i++) 
        {
            int j;
            for(j = i; j > 0 && IsGreater(elements[j-1], elements[j]); j--)
            {
                //compare return 3 possible values:
                //0 if both are equals
                //-1 if elements[j-1] is lesss than elements[j]
                //1 if elements[j] > elements[j-1]
            
                T temp = elements[j];
                elements[j] = elements[j-1];
                elements[j-1] = temp;
                
                
            }
        }

        return elements;
    }
}