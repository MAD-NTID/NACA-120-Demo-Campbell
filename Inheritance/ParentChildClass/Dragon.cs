public class Dragon : Beast
{

    public Dragon(string name, int hp, int maxHp, string weakness):base(name, hp, maxHp, weakness)
    {
   
    }

    public override void TakeDamage(IAttack attack)
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
        return base.ToString() + " Do my own thing too!!~";
    }

}