public class Snake : Animal
{

    public Snake(int age, string name):base(name, age)
    {

    }

    public override string Sound()
    {
        return "Hiss";
    }
}