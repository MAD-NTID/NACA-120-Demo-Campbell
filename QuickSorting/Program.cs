Random random = new Random();

int[] numbers = new int[10];
for(int i = 0; i < 10; i++) {
    numbers[i] = random.Next(-5,50);
}

Console.WriteLine("Unsort numbers:");
foreach(int element in numbers) {
    Console.Write($"{element} ");
}
Console.WriteLine("\n");


Console.WriteLine("sorted numbers:");
QuickSort<int> quickSort = new QuickSort<int>();
quickSort.Sort(numbers, 0, numbers.Length-1);
foreach(int element in numbers) {
    Console.Write($"{element} ");
}
Console.WriteLine("\n");
