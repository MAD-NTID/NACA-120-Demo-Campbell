class MyClassExample
{
    private string name;
    public string Name=> name;

    public MyClassExample(string name)
    {
        this.name = name;
    }

    public Func<MyClassExample, bool> IsEqual
    {
        get{
            return (MyClassExample example)=> example.Name == name;
        }
    }
}