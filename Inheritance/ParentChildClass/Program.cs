// Dragon dragon = new Dragon("King Dragon", 1000, 2500, "Electricity");
// Godzilla godzilla = new Godzilla("Da Zilla", 3000, 4000, "Fire");

// Console.WriteLine($"Two characters are battling each other:\n{dragon}\n{godzilla}\n");


// //GodZilla generate an attack and attack dragon
// Attack attack = godzilla.Attack();
// dragon.TakeDamage(attack);

// Console.WriteLine($"{godzilla.Name} attacked {dragon.Name} with {attack}");
// Console.WriteLine(dragon);

// //dragon attacking godzilla
// attack = dragon.Attack();
// godzilla.TakeDamage(attack);

// Console.WriteLine($"\n{dragon.Name} attacked {godzilla.Name} with {attack}");
// Console.WriteLine(godzilla);

//Assigning child to parent
// Beast beast = new Godzilla("Da Zilla", 3000, 4000, "Fire");

// //check if the instance is a type of Godzilla
// if(beast is Godzilla)
// {
//     Godzilla godzilla = (Godzilla)beast;
//     godzilla.Foo();
// }


Godzilla zillaOne = new Godzilla("Da Zilla", 3000, 4000, "Fire");
Godzilla zillaTwo = new Godzilla("Da Zilla", 3000, 4000, "Fire");

Dragon dragon = new Dragon("King Dragon", 1000, 2500, "Electricity");

Console.WriteLine(zillaOne.Equals(zillaTwo));

Console.WriteLine(zillaOne.Equals(dragon));




