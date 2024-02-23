public class Person
{
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private const int MAX_ITEM = 30000;
    private Item[] borrows;

    public Person()
    {
        Name = "Not set";
        Id = 0;
    }

    public Person(int id, string name)
    {
        borrows = new Item[MAX_ITEM];
        Id = id;
        Name = name;
    }

    public void Borrow(Item item)
    {
        //put it in the first available location
        for(int i = 0; i < MAX_ITEM; i++) {
            if(borrows[i] == null)
            {
                borrows[i] = item;
                break;
            }
        }
    }

    public void ReturnItem(Item item)
    {
        for(int i = 0; i < MAX_ITEM; i++)
        {
            //search for the item
            Item search = borrows[i];
            if(search!=null && search.Name == item.Name)
            {
                borrows[i] = null;
            }
        }
    }
    
}