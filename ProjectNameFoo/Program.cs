/**-------------------------
This is a block of comment.
Author: Kemoy Campbell
Date: foo
Purpose: Meh

------------------------------**/

string option = "3";
//option_foo_meh_blah Python variable naming - snake case

//optionFooMehB - c# variable syntax - camel case

//python input syntax
//foo = input("Enter your text here:")

//prompt the user
Console.Write("Enter the option:");
option = Console.ReadLine();


//This is a single line of comment with some demo
if(option == "1" || option == "2")
{
    Console.WriteLine("You chose option " + option);
}
else if(option == "3"){
    Console.WriteLine("choice " + option + " is magnificent!");

} else {
    Console.WriteLine("You did not choose a valid option!");
}

Console.WriteLine("");
Console.WriteLine("This is how you code this block in C#.... How can you do it in python?");