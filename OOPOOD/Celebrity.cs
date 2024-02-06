public class Celebrity
{
    //  Set up the properties for celebrity
    private string name, topWork;
    private int age;
    private bool deceased;
    private string yearDeceased;

    public string YearDeceased
    {
        get 
        {
            return yearDeceased;
        }
        set
        {
            // You can do validation here
            if(value.Length == 4 && int.TryParse(value, out int parsedYearDeceased))
                value = parsedYearDeceased.ToString();
            else
                value = "Invalid Year";

            yearDeceased = value;
        }

    }


    public Celebrity()
    {
        //  do nothing or do something, up to the programmer
    }

    public Celebrity(string _name, string _topWork, int _age, bool _deceased)
    {
        name = _name;
        topWork = _topWork;
        age = _age;
        deceased = _deceased;
    }

    // This is an accessor, returns the value of the attribute
    public string GetName()
    {
        return name;
    }

    // This is a modifier, modifies the value of the attribute
    public void SetName(string _name)
    {
        if(string.IsNullOrEmpty(_name))
            _name = "Invalid Name";

        name = _name;
    }
}