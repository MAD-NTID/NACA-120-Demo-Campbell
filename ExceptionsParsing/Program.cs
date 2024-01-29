
// YES! try/catch
int numberOfClasses = 0;

while(true) {
    Console.Write("Enter the number of classes you take this semester: ");

    try
    {
        numberOfClasses = int.Parse(Console.ReadLine());

        if(numberOfClasses < 1)
            throw new FormatException();

        break;
    }
    catch
    {
        Console.WriteLine("That's not a valid number of classes, duh");
    }
}

Console.WriteLine($"You are taking {numberOfClasses} classes this semester");