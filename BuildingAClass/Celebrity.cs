public class Celebrity
{
    //  Set up the properties for celebrity
    public string name, topWork;
    public int age;
    private bool deceased;

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
}