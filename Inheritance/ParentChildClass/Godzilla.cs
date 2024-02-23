public class Godzilla :Beast
{

    public Godzilla(string name, int hp, int maxHp, string weakness):base(name, hp, maxHp, weakness)
    {
   
    }
    public override IAttack Attack()
    {
        //pick a random attack


        //place holder
        return new Electricity();
    }

    public override void TakeDamage(IAttack attack)
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