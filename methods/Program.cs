Greeting();
Greeting("Alex");

Console.WriteLine(Add(5,5));
int sum = Add(5,10);
Console.WriteLine(sum);

int complex = Add(5,Add(3,20));
Console.WriteLine(complex);


/**
This method output Hello Human!
*/
void Greeting(String name = "Human")
{
    Console.WriteLine($"Hello {name}!");
    return ; //optional for return nothing
}



int Add(int number1, int number2)
{
    return number1 + number2;
}