public class Dragon : Beast
{

    public Dragon(string name, int hp, int maxHp, string weakness):base(name, hp, maxHp, weakness)
    {
   
    }

    public override Attack Attack()
    {
        //for the sake of this demonstration, I will create some attacks and random pick one to use as selecte attack
        Attack[] attacks = {
            new Attack("Fire",10),
            new Attack("Smash", 20),
            new Attack("Choke", 50),
            new Attack("Electricity", 50)
        };

        //random select an attack
        int selected = this.random.Next(attacks.Length);
        
        return attacks[selected];
    }



    public override string ToString()
    {
        //the base will call the Parent's toString then concatenate "Do my own thing too!!" from the child class
        return base.ToString() + " Do my own thing too!!~";
    }

}