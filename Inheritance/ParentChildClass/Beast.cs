public class Beast:IBeast
{
    private string name;
    private int currentHp;
    private int maxHp;
    protected string weakness;

    public Beast(string name, int currentHp, int maxHp, string weakness)
    {
        this.currentHp = currentHp;
        this.weakness = weakness;
        this.maxHp = maxHp;
        this.name = name;
    }

    public int CurrentHP
    {
        get{return currentHp;}
    }

    public int MaxHp => maxHp;
    public string Name => name;

    public string Weakness => weakness;

    public virtual IAttack Attack()
    {
        //pick a random attack


        //place holder
        return new Electricity();
    }

    public virtual void TakeDamage(IAttack attack)
    {
    
        //
        if(attack.Name == this.weakness)
        {
            //he lost <point> points
        } else{
            //do something
        }
    }

    public override string ToString()
    {
        return $"Name:{name}, HP:{currentHp}, MaxHp:{maxHp}, Weakness:{weakness}";
    }
}