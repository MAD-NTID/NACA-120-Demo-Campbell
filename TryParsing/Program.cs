
int numberOfClasses = 0;

while(true) 
{
    Console.Write("Enter the number of classes you take: ");

    if(int.TryParse(Console.ReadLine(), out numberOfClasses) && numberOfClasses > 0) {
        Console.WriteLine($"You are taking {numberOfClasses} this semester");
    }
    else {
        Console.WriteLine("Invalid number of classes");
    }
}

// while(true) 
// {
//     Console.Write("Enter the number of classes you take: ");

//     if(int.TryParse(Console.ReadLine(), out int numberOfClasses) && numberOfClasses > 0) {
//         Console.WriteLine($"You are taking {numberOfClasses} this semester");
//     }
//     else {
//         Console.WriteLine("Invalid number of classes");
//     }
// }