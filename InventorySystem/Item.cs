public class Item
{
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    private string category;
    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Item()
    {
        Name = "Item- No name";
        Category = "Category- No category";
        id = 0;
    }

    private bool borrowed;
    public bool Borrowed
    {
        get { return borrowed; }
        set { borrowed = value; }
    }
    

    public Item(int id, string name, string category)
    {
        Name = name;
        Category = category;
        Id = id;
        borrowed = false;
    }

    public override string ToString()
    {
        return $"Id:{id} Name:{name} Category:{category}";
    }



}