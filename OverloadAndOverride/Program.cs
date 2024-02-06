
//create two empty monsters and give both an initalize state of null
Monster dragon = null;
Monster godzilla = null;

// setup our user interactions in an infinity(forever) loop.
//the loop ends when the user enter option #3
while(true)
{
    //get the user selection
    int selection = Selection();

    //switch/toggle based on the option the user select
    switch(selection)
    {
        //user selected option 1 so we create 2 monsterss
        case 1:
            Console.WriteLine("Creating monster #1\n=================");
            dragon = createMonster();
            Console.WriteLine("\nCreating monster #2\n=================");
            godzilla = createMonster();
            Console.WriteLine("Monsters created!!!");
            break;

        //the user selected option 2.
        case 2:
            //if the user try to jump to option 2 before creating 2 monsters, we inform them that they need to create
            //monsters before those monsters can battle
            if(dragon == null || godzilla == null)
                Console.WriteLine("The monsters are empty. You must first create 2 monsters with option 1 before battling!");
            else
                //there are 2 monsters so send those monsters to battle
                Battle(dragon, godzilla);
            break;
        case 3:
            //user decided to quit playing
            Console.WriteLine("Thank you for playing!");
            Environment.Exit(0);
            break;
        
        //handle invalid selections
        default:
            Console.WriteLine("Invalid selection!");
            break;
    }
}

///<summary>
/// This method shows the user the list of menu options
///</summary>
void DisplayMenu()
{
    //create the menu in an array
    string[] menus = {"Create new monsters", 
                      "Place in battle arena",
                      "Exit"
                      };

    //loop through each and show the menu with number option
   for(int i = 0; i < menus.Length; i++)
   {
        Console.WriteLine($"{i+1}. {menus[i]}");
   }
}

///<summary>
/// This method gets the user selection for the menu and return the selection.
///</summary>
int Selection()
{
    int selection = 0;
    do
    {
        //show the user the menu
        DisplayMenu();
        //prompt the user for the menu selection
        Console.Write("Selection:");
        //if the user selection is not an integer show them an error
        //NOTE:: If the Try.Prase cannot convert from string to int, it automatically set the out variable value to 0
        if(!int.TryParse(Console.ReadLine(), out selection))
        {
            Console.WriteLine("Invalid selection. Enter digit only!");
        }

    //continue as long as the selection is still 0 
    }while(selection == 0);

    //return selection
    return selection;
}

///<summary>
/// This method create and return a monster class
///</summary>
Monster createMonster()
{
    string name = "";
    int health = 0;

    //prompting for monster name
    while(true)
    {
        // the user to enter a name for the monster
        Console.Write("Name:");
        name = Console.ReadLine();

        //if the user enter a name that is not empty, we break out of the infinity loop
        if(!string.IsNullOrEmpty(name)) {
            break;
        }

        //if the name is not valid, we inform the user and continue prompt for name
        Console.WriteLine("Invalid name!");
    }

    //prompt for health point
    while(true)
    {
        //prompt the user for the health point
        Console.Write("Health Point:");
        //if the healthpoint is a digit and greater than or equal to 100 then we break out of the loop
        if(int.TryParse(Console.ReadLine(), out health) && health >=100)
        {
            break;
        }

        //inform the user of the error and keep prompting for health point
        Console.WriteLine("Invalid health point! Health Point must start from a minimum of 100!");
    }

    //the user enter valid name and health point so we can create a monster object from the name and health point
    return new Monster(name, health);
}

///<summary>
/// This take two monster instances and commence a monsterous battle!!
///</summary>
void Battle(Monster monster1, Monster monster2)
{
    //we will add some randomness to decide which monster will throw the first 
    //punch in the battle
    Random rand = new Random();
    int battleFirst = rand.Next(2); //this will random select  between 0-1

    //by default, we monster1 will go first. However, if the random selected 2 then monster 2 will punch first
    //if monster 2 have to go first we will just set monster2 as monster1 to make it easier
    //to play the game and reduce the if else logics
    if(battleFirst == 1)
    {
        //store monster1 in a temp variable. This is because monster1 will override when we assign monster 2 as monster1
        Monster temp = monster1;
        monster1 = monster2; //set monster2 as monster1
        monster2 = temp; //set monster2 as monster 1 using the value we stored at the temp
    }

    //while both monsters are still alive, we will continue the fight.
    while(monster1.IsAlive && monster2.IsAlive)
    {
        //monster will throw the first punch
        int punch = monster1.Punch();

        //inflict the damage punch from monster 1 to monster 2
        monster2.TakePunch(punch);
        BattleCommentary(monster1, monster2, punch);


        //monster 2 can only punch monster 1 if monster 2 is still alive after receiving 
        //that monsterous punch from monster1
        if(monster2.IsAlive) {
            punch = monster2.Punch();
            monster1.TakePunch(punch);
            BattleCommentary(monster2, monster1, punch);
        }

        //pause for 1 second before continuing
        Thread.Sleep(1000);
    }


}


///<summary>
/// This take the attacking monster, the victim monster and the damage punch from the attacking monster then
/// narrate what is going on in the battle
///</summary>
void BattleCommentary(Monster attacking, Monster victim, int damage)
{
    //show which monster did the punch and which monster received the punch along with the punch damage points
    Console.WriteLine($"{attacking.Name} punch {victim.Name} with a punch of {damage} damage points");

    //we can compute the victim monster's health point prior to the damage by take the current
    //health point and add it with the damage punch
    int victimPreviousHealthPoint = victim.HealthPoint + damage;
    Console.WriteLine($"{victim.Name} health reduced from {victimPreviousHealthPoint} to {victim.HealthPoint}");

    //show if our victim monster is dead :-)
    if(!victim.IsAlive){
        Console.WriteLine($"{victim.Name} is dead!!!!");
    }

    Console.WriteLine();
}
