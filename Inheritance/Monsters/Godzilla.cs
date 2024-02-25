public class Godzilla : IBeast
{
    private string name;
    private int currentHp;
    private int maxHp;
    private string weakness;

    public Godzilla(string name, int currentHp, int maxHp, string weakness)
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

    public Attack Attack()
    {
        //pick a random attack


        //place holder
        return new Attack("Example2", 200);
    }

    public void TakeDamage(Attack attack)
    {
    
        //
        if(attack.Name == this.weakness)
        {
            //he lost 30 points
        } else{
            //do something
        }
    }
}