public class Person
{
    private string name;
    private int age;
    private double weight;

    public string Name
    {
        get{return name;}
        set{
            if(string.IsNullOrEmpty(name))
                value = "Unspecified";   
            name = value;
            }
    }

    public Person(string _name)
    {
        Name = _name;
    }
}