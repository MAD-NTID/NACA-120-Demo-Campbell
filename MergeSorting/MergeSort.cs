public class MergeSort<T>
{
    public T[] Sort(T[] elements)
    {
        int n = elements.Length;
        if(n == 1)
            return elements;
        
        //split the elements in halves
        int midPoint = (int)n/2;

        T[] firstHalves = Copy(elements, 0, midPoint);
        T[] secondHalves = Copy(elements, midPoint, n);

        //PrintElements(firstHalves, "First Halves");
        //PrintElements(secondHalves, "Second Halves");

        //recursively spilt in halves
        firstHalves = Sort(firstHalves);
        secondHalves = Sort(secondHalves);
        //Thread.Sleep(3000);
        
        return Merge(firstHalves, secondHalves);
    }

    public T[] Copy(T[] elements, int start, int end)
    {
        int size = end-start;
        T[] copy = new T[size];

        int index = 0;
        for(int i = start; i < end; i++)
        {
            copy[index] = elements[i];
            index++;
        }

        return copy;
    }

    public void PrintElements(T[] elements, string msg="")
    {
        if(!string.IsNullOrEmpty(msg))
            Console.Write($"{msg}: ");
        
        foreach(T element in elements) {
            Console.Write($"{element} ");
        }

        Console.WriteLine("\n");
    }

    public T[] Merge(T[] arrayA, T[] arrayB)
    {
        T[] sorted = new T[arrayA.Length + arrayB.Length];
        int indexA=0,indexB=0,indexSorted = 0;

        //while a and b both have something
        while(indexA < arrayA.Length && indexB < arrayB.Length)
        {
            T a = arrayA[indexA];
            T b = arrayB[indexB];
            if(IsGreater(a,b)){
                sorted[indexSorted] = a;
                indexA++;
            } else {
                sorted[indexSorted] = b;
                indexB++;
            }

            indexSorted++;
        }

        while(indexA < arrayA.Length){
            sorted[indexSorted] = arrayA[indexA];
            indexA++;
            indexSorted++;
        }

        while(indexB < arrayB.Length){
            sorted[indexSorted] = arrayB[indexB];
            indexB++;
            indexSorted++;
        }

        return sorted;
    }

    public bool IsGreater(T element1, T element2)
    {
        int result = Comparer<T>.Default.Compare(element1, element2);

        return result <=0;
    }
}