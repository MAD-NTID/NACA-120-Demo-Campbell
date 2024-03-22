using System.Diagnostics;

int[] a = {1,2,3,4,5,6,7,8,9,10};


//run time O(1)
Stopwatch watch = new Stopwatch();
watch.Start();
Console.WriteLine(a[0]);
watch.Stop();


//O(N)
// Console.WriteLine("Speed:"+  watch.ElapsedMilliseconds);
// watch = new Stopwatch();
// watch.Start();
// foreach(int element in a){
//     Console.WriteLine(element);
// }
// watch.Stop();
// Console.WriteLine("Looping");
// Console.WriteLine("Speed:"+  watch.ElapsedMilliseconds);

// //O(N^2)
for(int i = 0; i < 800; i++)
    for(int j = 0; j < 800; j++)
        Console.WriteLine($"{i},{j}");

// for(int i = 0; i < 800; i++)
//     for(int j = 0; j < 800; j++)
//         for(int k = 0; k < 800; k++)
//             Console.WriteLine($"{i},{j},{k}");



