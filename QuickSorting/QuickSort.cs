using System.Runtime.Serialization;

public class QuickSort<T>
{
    //see the full comments in the quicksort pseudocode
    //on unit 32 PPT
    /**
    This method recursively sort an array based on the 
    pivot and partition
        array  - the array elements
        lo - the starting index
        hi - the ending index
    */
    public void Sort(T[] array, int lo, int hi)
    {
        //lo cannot be greater than hi and lo cannot be negative
        //base case
        if(lo >=hi || lo < 0)
            return ;

        //find the pivot point
        int pivot = Partition(array, lo, hi);

        //find pivot, do partition and sort for left side
        Sort(array, lo, pivot-1);
        //find pivot, do partition and sort for right side
        Sort(array,pivot+1, hi);
    }


    /**
        This performs the partition and return the index
        of the pivot
    **/
    private int Partition(T[] array, int lo, int hi)
    {
        //pick the last element as pivot
        T pivot = array[hi];

        int i = lo-1;

        //compare the elements against the pivot
        for(int j = lo; j < hi; j++){
            if(IsLessOrEqual(array[j], pivot)){
                i+=1;
                //swap
                Swap(array,i,j);
            }
        }

        i+=1;
        Swap(array, i, hi);
        return i;
    }

    //check if less or equals to
    private bool IsLessOrEqual(T element1, T element2)
    {
        int result = Comparer<T>.Default.Compare(element1, element2);
        return result <=0;
    }

    //swap I and j
    public void Swap(T[] array, int j, int i)
    {
        T temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
}