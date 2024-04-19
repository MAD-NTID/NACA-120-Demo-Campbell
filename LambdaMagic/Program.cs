// var square = (int x) => 
// {
//     if(x < 0)
//         x = x*-1;

//     return x*x;
// };

// var square2 = (int x, int y, int m) => x*x + (y/y) * m;



// Console.WriteLine(square(2));
// Console.WriteLine(square(-2));
// Console.WriteLine(square(5));

//Action<string> greeting = (string name)=> Console.WriteLine($"Hello {name}");
// var greeting = (string name)=> Console.WriteLine($"Hello {name}");

// greeting("Austin");



MyClassExample class1 = new MyClassExample("Kemoy");
MyClassExample class2 = new MyClassExample("Kemoy");
MyClassExample class3 = new MyClassExample("Rahul");

Console.WriteLine(class1.IsEqual(class2));
Console.WriteLine(class1.IsEqual(class3));
