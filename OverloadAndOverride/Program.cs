
//create two empty monsters
Monster dragon = null;
Monster godzilla = null;

while(true)
{
    int selection = Selection();
    switch(selection)
    {
        case 1:
            dragon = createMonster();
            godzilla = createMonster();
            Console.WriteLine("Monsters created!!!");
            break;
        case 3:
            Console.WriteLine("Thank you for playing!");
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid selection!");
            break;
    }
}

void DisplayMenu()
{
    string[] menus = {"Create new monsters", 
                      "Place in battle arena",
                      "Exit"
                      };

   for(int i = 0; i < menus.Length; i++)
   {
        Console.WriteLine($"{i+1}. {menus[i]}");
   }
}

int Selection()
{
    int selection = 0;
    do
    {
        DisplayMenu();
        Console.Write("Selection:");
        if(!int.TryParse(Console.ReadLine(), out selection))
        {
            Console.WriteLine("Invalid selection. Enter digit only!");
        }

        
    }while(selection == 0);

    return selection;
}

Monster createMonster()
{
    string name = "";
    int health = 0;

    while(true)
    {
        Console.Write("Name:");
        name = Console.ReadLine();
        if(!string.IsNullOrEmpty(name)) {
            break;
        }

        Console.WriteLine("Invalid name!");
    }

    while(true)
    {
        Console.Write("Health Point:");
        if(int.TryParse(Console.ReadLine(), out health))
        {
            break;
        }

        Console.WriteLine("Invalid health!");
    }

    return new Monster(name, health);
}


void Battle(Monster monster1, Monster monster2)
{
    //assume monster 1 will go fist
    Random rand = new Random();
    int battleFirst = rand.Next(2);
    if(battleFirst == 1)
    {
        Monster temp = monster1;
        monster1 = monster2;
        monster2 = temp;
    }

    int punch = monster1.Punch();
    monster2.TakePunch(punch);

    if(monster2.IsAlive) {
        punch = monster2.Punch();
        monster1.TakePunch(punch);
    }
}
