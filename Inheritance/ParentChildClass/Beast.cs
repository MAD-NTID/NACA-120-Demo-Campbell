public class Beast:IBeast
{
    private string name;
    private int currentHp;
    private int maxHp;
    protected string weakness;
    protected Random random;

    public Beast(string name, int currentHp, int maxHp, string weakness)
    {
        this.currentHp = currentHp;
        this.weakness = weakness;
        this.maxHp = maxHp;
        this.name = name;
        random = new Random();
    }

    public int CurrentHP
    {
        get{return currentHp;}
    }

    public int MaxHp => maxHp;
    public string Name => name;

    public string Weakness => weakness;

    //to override a method in the child, we must add virtual keyword to the method in the parent
    public virtual Attack Attack()
    {
        return null;
    }

    //to override a method in the child, we must add virtual keyword to the method in the parent
    public virtual void TakeDamage(Attack attack)
    {
        int damage = attack.DamagePoints;

        //the problem didnt didnt state how to handle a weakness but for the sake of demo
        //let us say the damange point will double
        if(attack.Name == this.weakness)
            damage*=2;

        this.currentHp-=damage;
            
    }

    public override string ToString()
    {
        return $"Name:{name}, HP:{currentHp}, MaxHp:{maxHp}, Weakness:{weakness}";
    }
}