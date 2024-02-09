const int MAX_PERSONS = 30000;
Inventory inventory = new Inventory();
Person[] persons = new Person[MAX_PERSONS];


while(true)
{
    string[] menus = {
        ""
    };

    for(int i = 1; i <= menus.Length; i++){
        Console.WriteLine($"{i}. {menus[i-1]}");
    }
    Console.WriteLine("Selection:");
    string selection = Console.ReadLine();

    switch(selection)
    {
        case "1":
            Item item = NewItem();
            inventory.AddItem(item);
            Console.WriteLine($"New item {item.Name} added to the inventory");
        break;


        case "5":
            Console.WriteLine("Inventory Status");
            inventory.ShowAvailableItems();
            inventory.ShowLoanedItems();
            break;
        case "6":
            Console.WriteLine("Thank you for using our inventory system");
            break;

        default:
            Console.WriteLine("Invalid selection!");
            break;

    }
}


Item NewItem()
{
    Item item = null;
    string name;
    string category;
    int id;

    while(true)
    {
        Console.Write("Item Id:");
        if(int.TryParse(Console.ReadLine(), out id) && id > 0)
            break;
        
        Console.WriteLine("Item Id must be a digit greater than 0!");
    }

    while(true)
    {
        Console.Write("Item Category:");
        category = Console.ReadLine();
        if(!string.IsNullOrEmpty(category))
            break;
        
        Console.WriteLine("Category cannot be empty or null");
    }

    while (true)
    {
        Console.Write("Item Name:");
        name = Console.ReadLine();

        if(!string.IsNullOrEmpty(name))
            break;
        
        Console.WriteLine("Item name cannot be empty or null");

    }

    return new Item(id, name, category);
    
}
