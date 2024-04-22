using System.Reflection;

List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};
//tradational way without LINQ
// int count = 0;
// foreach(int num in numbers)
// {
//     if(num % 2==0)
//         count++;
// }

// Console.WriteLine(count);

// var evenNumbers = (List<int> nums) =>{
//     int count = 0;

//     foreach(int num in nums)
//     {
//         if(num % 2==0)
//             count++;
//     }

//     return count;
// };


// Console.WriteLine(evenNumbers(numbers));


//using LINQ - Count
int totalEvenNumbers = numbers.Count(num=> num % 2 ==0);
Console.WriteLine(totalEvenNumbers);

//LINQ - SELECT
List<string> names = new List<string>()
{
    "Linus",
    "Kemoy",
    "Bob",
    "Dog"
};

var namesWithLength = names.Select(name=>new {Name=name, TotalLength=name.Length});

foreach(var info in namesWithLength)
{
    Console.WriteLine($"Person name:{info.Name}, TotalCharacters:{info.TotalLength}");
}

var person = new [] {
    new {Name="Agent M", Age=50},
    new {Name="Agent Q", Age=25},
    new {Name="Agent T", Age= 20}
};

//LINQ - SELECT

var personAgeIn5Years = person.Select(info=> new {Name=info.Name, AgeIn5Years = info.Age + 5});
foreach(var personInfo in personAgeIn5Years)
{
    Console.WriteLine(personInfo);
}

//LINQ WHERE

List<int> evenNumbers = numbers.Where(num=> num % 2 == 0 ).ToList();

foreach(int number in evenNumbers)
{
    Console.WriteLine(number);
}