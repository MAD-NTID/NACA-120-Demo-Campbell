int[] a = {99,10,-1,5,2000,85};

Console.WriteLine("Unsorted");
foreach(int element in a) {
    Console.Write($"{element} ");
}

// for(int i = 1; i < a.Length; i++) {
//     for(int j = i; j > 0 && a[j-1] > a[j]; j--)
//     {
//         int temp = a[j];

//         a[j] = a[j-1];
//         a[j-1] = temp;
//     }
// }

InsertionSort<int> insertionSort = new InsertionSort<int>();
a = insertionSort.Sort(a);

Console.WriteLine("\nSorted");
foreach(int element in a) {
    Console.Write($"{element} ");
}