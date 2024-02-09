/// <summary>
///     This is a class that represent a monster. 
///     A monster has the following attributes:
///      -name
///      -health point
///     
///     A monster has the following properties:
///     -IsAlive
///     -Name
///     -HealthPoint
///     
///    A monster is capable of:
///    - Punch a monsterous punch - some random int values that represents the monsterious punch
///    - Take some damage from a monster punch
///     
/// </summary>
public class Monster
{
    //private attributes
    private string name;
    private int healthPoint;

    //a random attribute to use and generate a random punch value
    private Random punchBlow;

    //constants
    private const int MIN_PUNCH = 100;
    private const int MAX_PUNCH = 3000;

    
    /// <summary>
    /// Return true if the monster is still alive. False otherwise
    /// </summary>
    public bool IsAlive{
        get{return healthPoint > 0;}
    }


    /// <summary>
    /// The Name property returns a name or set the name of the monster. If the name is
    /// null or empty the the monster's name is default to Unspecified
    /// </summary>
    public String Name
    {
        get{return name;}
        set{
            if(string.IsNullOrEmpty(value))
                value  = "Unspecified";
            name = value;
        }
    }

    /// <summary>
    /// The HealthPoint returns or set the health point of the monster.
    /// If the value of the health point to set is negative, it will be default to 0
    /// </summary>
    public int HealthPoint{
        get{return healthPoint;}
        set
        {
            if(value < 0)
                value = 0;
            healthPoint = value;
        }
    }

    /// <summary>
    ///     This is the default constructor that initalized a monster's name to Unspecified,
    ///     health point to 0 as well as set up the punch blow to new random instance
    /// </summary>
    public Monster()
    {
        Name = "Unspecified";
        punchBlow = new Random();
        HealthPoint = 0;
    }

    /// <summary>
    /// This parameterize constructor takes name and health points of a monsters and setup
    /// their properties as well as set up the punch blow to new random instance.
    /// </summary>
    /// <param name="name">The monster's name</param>
    /// <param name="healthPoint">The monster's health point</param>
    public Monster(string name, int healthPoint)
    {
        Name = name;
        HealthPoint = healthPoint;
        punchBlow = new Random();
    }

    /// <summary>
    /// This method overrides the ToString to show the monster's name and health point
    /// </summary>
    /// <returns>Monster name is: {name} and health point is: {healthPoint}</returns>
    public override string  ToString()
    {
        return $"Monster name is: {name} and health point is: {healthPoint}";
    }

    /// <summary>
    /// This method allows the monster to punch. The amount of punch is random between 100 - 3000
    /// </summary>
    /// <returns>The punch</returns>
    public int Punch()
    {
        return punchBlow.Next(MIN_PUNCH, MAX_PUNCH + 1);
    }

    /// <summary>
    /// This method allowss a monster to take a punch damage and reduce their health point
    /// </summary>
    /// <param name="damage">The amount of damage to the monster</param>
    public void TakePunch(int damage)
    {
        healthPoint-=damage;
    }
}