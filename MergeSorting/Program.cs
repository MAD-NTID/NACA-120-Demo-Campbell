int[] unsorted = {7,2,13,15,3,9,12,2,300};

MergeSort<int> mergeSort = new MergeSort<int>();

int[] sorted = mergeSort.Sort(unsorted);

foreach(int element in sorted) {
    Console.Write($"{element} ");
}

Console.WriteLine("\n");