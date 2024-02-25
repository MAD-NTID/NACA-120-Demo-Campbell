public class Attack
{
    private int damagePoints;
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public int DamagePoints
    {
        get { return damagePoints; }
        set { damagePoints = value; }
    }

    public Attack(string name, int damage)
    {
        this.Name = name;
        this.DamagePoints = damage;
    }

    public override string ToString()
    {
        return $"{name} - {damagePoints}";
    }

}