public class Monster
{
    private string name;
    private int healthPoint;
    private Random punchBlow;
    private const int MIN_PUNCH = 100;
    private const int MAX_PUNCH = 3000;

    public bool IsAlive{
        get{return healthPoint > 0;}
    }

    public String Name
    {
        get{return name;}
        set{
            if(string.IsNullOrEmpty(value))
                value  = "Unspecified";
            name = value;
        }
    }

    public int HealthPoint{
        get{return healthPoint;}
        set
        {
            if(value < 0)
                value = 0;
            healthPoint = value;
        }
    }

    public Monster()
    {
        Name = "Unspecified";
        punchBlow = new Random();
        HealthPoint = 0;
    }

    public Monster(string name, int healthPoint)
    {
        Name = name;
        HealthPoint = healthPoint;
    }

    public override string  ToString()
    {
        return $"Monster name is: {name} and health point is: {healthPoint}";
    }

    public int Punch()
    {
        return punchBlow.Next(MIN_PUNCH, MAX_PUNCH + 1);
    }

    public void TakePunch(int damage)
    {
        healthPoint-=damage;
    }
}