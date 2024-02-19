//Simple tests

// Alien test1 = new Alien("Kemoy", "Captain");
// Alien test2 = new Alien("", "mehhhhhhhhhhhhhhhhhhhhhhhhh");

// Console.WriteLine(test1.ToString());
// Console.WriteLine(test2.ToString());

// Ship ship = new Ship();

// Console.Write(ship);

// ship.Add(test1);
// Console.Write(ship);


/**
This is the logic for the starfleet ship
**/

//instance the ship
Ship ship = new Ship("Voyager", 3000);

//menu array
string[] menus = {
    "Add Alien to ship",
    "Fly",
    "Fly at specific speed",
    "Remove a alien from a ship",
    "Show ship information",
    "Exit"
};



//a while loop that continue until the user exit
while(true)
{
    //tru
    try{
        //select
        int choice = Selection();

        //switch between each choices
        switch(choice)
        {
            case 1:
                bool isAdded = false;
                Alien alien;
                do
                {
                    //prompt for name and role
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Role:");
                    string role = Console.ReadLine();
                    
                    //create alien object and attempt to add
                    alien = new Alien(name, role);
                    isAdded = ship.Add(alien);
                    if(isAdded == false) {
                        Console.WriteLine("Only 1 Captain or Chief Officer allowed!");
                    }
                }while(isAdded == false); //remprompt as long as the crew has not been added

                //if we get here then the alien was added
                Console.WriteLine($"{alien.ToString()} was successfully added");
            break;

            case 2:
                //fly the ship
                ship.Fly();
                Console.WriteLine($"{ship.Name} flew {ship.TotalDistance} interstellar distance at {ship.WarpSpeed} warp speed");
                break;
            case 3:
                //fly with overload method where the user can input the speed
                Console.Write("Enter the wrap speed in the multple of 3:");

                //validate that the speed can be parsed and is multiple of 3
                bool isParsedOut = int.TryParse(Console.ReadLine(), out int speed);
                if(isParsedOut == false || speed % 3 != 0){
                    Console.WriteLine("Invalid speed! Speed must be an integer in mutliple of 3!\n Ship did not fly!");
                } else{
                    ship.Fly(speed);
                     Console.WriteLine($"{ship.Name} flew {ship.TotalDistance} interstellar distance at {ship.WarpSpeed} warp speed");
                }
                break;
            case 4:
                //prompt for the name of the ship and attempt to remove
                Console.Write("Name:");
                string alienName = Console.ReadLine();
                bool removed = ship.Remove(alienName);

                if(removed){
                    Console.WriteLine($"{alienName} was successfully removed");
                } else {
                    Console.WriteLine($"{alienName} doesn't exit");
                }
            break;


            case 5:
                //show ship information
                Console.WriteLine(ship.ToString());
                break;

            case 6:
                //thank the user and exit
                Console.WriteLine("Thank you for exploring space with us");
                Environment.Exit(0);
                break;
            
            default:
                //any option below 1 or above 6 will result in invalid selection
                Console.WriteLine("Invalid Selection");
                break;
        }
        
    }
    catch(FormatException )
    {
        //this is caught if the user attempted to enter string instead of digit
        //as menu selection
        Console.WriteLine("“Invalid selection. Input must be a digit!");
    }
}

//prompt the user for a selection and return
//their choice in integer
int Selection()
{
    Console.WriteLine("StarFleet Federation");

    //show the user the available menu option
    for(int i = 0; i < menus.Length; i++) {
        Console.WriteLine($"{i+1}. {menus[i]}");
    }

    //get their selection
    Console.Write("Selection:");
    int selection = int.Parse(Console.ReadLine());

    return selection;
}
