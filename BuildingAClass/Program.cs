// Create an instance of the celebrity class
// The class is not the "data type"
Celebrity topSinger = new Celebrity();
topSinger.name = "Whitney Houston";
topSinger.topWork = "I Will Always Love You <3";
topSinger.age = 48;
topSinger.deceased = true;

// Console.WriteLine($"Celebrity Name: {topSinger.name} whose top work is {topSinger.topWork}.\nDeceased? {topSinger.deceased}.\nAge: {topSinger.age}");

Console.WriteLine();

//  Let's instantiate another celebrity with information ready
Celebrity topMovieActor = new Celebrity("Angie Jolie", "Tomb Raider", 48, false);

// Console.WriteLine($"Celebrity Name: {topMovieActor.name} whose top work is {topMovieActor.topWork}.\nDeceased? {topMovieActor.deceased}.\nAge: {topMovieActor.age}");

//  Let's create an array of Celebrity
Celebrity[] celebrities = new Celebrity[3];
celebrities[0] = topSinger;
celebrities[1] = topMovieActor;

Console.Write("Enter a Celebrity's Name: ");
string celebrityName = Console.ReadLine();

Console.Write("Enter the Celebrity's Top Work: ");
string celebrityTopWork = Console.ReadLine();

Console.Write("Enter the Celebrity's Age: ");
int celebrityAge = int.Parse(Console.ReadLine());

Console.Write("Is the Celebrity Deceased? (yes if deceased): ");
bool celebrityDeceased = false;
if(Console.ReadLine() == "yes")
    celebrityDeceased = true;

Celebrity newCelebrity = new Celebrity(celebrityName, celebrityTopWork, celebrityAge, celebrityDeceased);
celebrities[2] = newCelebrity;

// This loop will get the object of Celebrity for each of the spaces in the Celebrity array
// And Grab the values in the object's properties and print
for(int i = 0; i < celebrities.Length; i++)
    Console.WriteLine($"Celebrity Name: {celebrities[i].name} whose top work is {celebrities[i].topWork}.\nDeceased? {celebrities[i].deceased}.\nAge: {celebrities[i].age}");