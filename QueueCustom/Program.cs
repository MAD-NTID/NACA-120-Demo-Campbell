Queue<int> queue = new Queue<int>();

for(int i = 1; i <= 10; i++) {
    queue.Enqueue(i);
}

for(int i = 1; i <= 10; i++) {
    Console.WriteLine($"queue contains {i}? {queue.Contains(i)}");
}

Console.WriteLine("Printing the queue elements in the queue from front to back");
Console.WriteLine(queue);

Console.WriteLine("The front element is :" + queue.Peek());
Console.WriteLine("Denqueue off the front element: " + queue.Dequeue());

//testing the IEnumerator
Console.WriteLine("Showing the remaining elements using foreach");
foreach(int element in queue)
{
    Console.WriteLine(element);
}

//to array
int[] elements = queue.ToArray();
Console.WriteLine("Get queue as array elements");
for(int i = 0; i < elements.Length; i++) {
    Console.WriteLine($"index:{i}, element:{elements[i]}");
}

queue.Clear();
Console.WriteLine("Elements cleared");
Console.WriteLine("The size of the elements after clearing the queue: " + queue.Count);
Console.WriteLine("The contents:"+ queue.ToString());
