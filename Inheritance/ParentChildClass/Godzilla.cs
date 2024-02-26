public class Godzilla :Beast
{

    public Godzilla(string name, int hp, int maxHp, string weakness):base(name, hp, maxHp, weakness)
    {
   
    }


    public override Attack Attack()
    {
        //for the sake of this demonstration, I will create some attacks and random pick one to use as selecte attack
        Attack[] attacks = {
            new Attack("Water",10),
            new Attack("Spike", 30),
            new Attack("Grab-and-Fly", 50)
        };

        //random select an attack
        int selected = this.random.Next(attacks.Length);
        
        return attacks[selected];
    }

    public void TakeDamage(Attack attack)
    {
        //override the godzilla to handle the 30% damage received from the fire
        if(attack.Name == "Fire"){
            //calcualate 30% of the spike's damage based on the godzilla's current health
            int damage = (int)(CurrentHP * 0.3);
            //update the attack damage
            attack.DamagePoints = damage;
        }

        //call the parent to the Take damage since we already have the logic in there... we only handle small
        //variant in the child such as calculate the % of damage point if Fire attack
        base.TakeDamage(attack);
    }

    public void Foo()
    {
        Console.WriteLine("FOOOOOOOOO");
    }

    public override bool Equals(object? obj)
    {
        if(obj== null)
            return false;
        
        if(!(obj is Godzilla))
            return false;
        
        Godzilla zilla = (Godzilla)obj;

        return zilla.Name == base.Name && zilla.CurrentHP == base.CurrentHP &&
               zilla.MaxHp == base.MaxHp && zilla.Weakness == base.Weakness;
    }
}