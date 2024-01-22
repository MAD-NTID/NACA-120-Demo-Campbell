/*int age  = 120;
string name = "Megaman";

//Using concatenation approach
Console.WriteLine("Wow, you are " + age + " years old");

//Using replacement/ composite formatting approach
Console.WriteLine("Wow, you are {0} years old", age);

//interpolation
Console.WriteLine($"Wow, you are {age} years old");
*/

Console.Write("Enter your name:");
string name = Console.ReadLine();

Console.Write("Enter your age:");
int age = int.Parse(Console.ReadLine());
// double foo = double.Parse(Console.ReadLine());
//age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Hello {0}! You are {1} years old",name,age);



