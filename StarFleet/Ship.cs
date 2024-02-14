/**
    This is a class that represent the federation ship
**/
public class Ship
{
    private int totalDistance;
    private int warpSpeed;
    private string name;
    private int totalCrew;

    public int TotalDistance { get{return totalDistance;}}
    public int WarpSpeed{get{return warpSpeed;}}
    public string Name{get{return name;}}

    //setting up constants
    private const int ZERO = 0;
    private const int MAX_CAPACITY = 10;
    private const string DEFAULT_SHIP_NAME = "Unidentified FlyingObject";

    private const int FIVE = 5;
    private const int THREE = 3;

    //this will keep a list of all alien crew members
    private Alien[] crews;

    /**
        The default constructor that sets up the default values of the ship
    **/
    public Ship()
    {
        crews = new Alien[MAX_CAPACITY];
        totalDistance = ZERO;
        warpSpeed = ZERO;
        totalCrew = ZERO;
        name = DEFAULT_SHIP_NAME;
    }

    /**
        A parameterized constructor that takes the name and crew capacity for the ship
        and initalize the variables
    **/
    public Ship(string _name, int capacity)
    {
        crews = new Alien[capacity];
        totalDistance = ZERO;
        warpSpeed = ZERO;
        totalCrew = ZERO;
        name = _name;
    }

    /**
        This method takes an alien object and add them to the ship.
        Note: there cannot be 2 chief officers or 2 captains on the ship
    **/
    public bool Add(Alien alien)
    {
        //if the alien to add is a captain or chief officer, we need to check
        //that there wont be any duplicate chief officer or captain
        if(alien.IsCaptainOrOfficer){
            for(int i = 0; i < crews.Length; i++)
            {
                Alien crew = crews[i];
                //if a alien that is a captain or chief officer have the same role as a captain or a officer then it is a violation
                //of the rule so we do not add them to the ship
                if(crew!=null && alien.Role == crew.Role)
                    return false;
            }
 
        }

        //find a null location to insert the crew
        for(int i = 0; i < crews.Length; i++) {
            //the location is null so we can add it there
            if(crews[i] == null)
            {
                //add the alien to the array and break out of the loop
                crews[i] = alien;
                break;
            }
        }

        //increment the number of crews on the ship
        totalCrew++;
        return true;
    }

    /**
        This method takes a name and remove the alien. If the alien was removed then
        true is returned otherwise false is returned
    **/
    public bool Remove(string name)
    {
        //search through the crew for the matching alien
        for(int i = 0; i < crews.Length; i++)
        {
            Alien crew = crews[i];
            //you cannot search a null element
            //make sure that the crew name match before removing them
            if(crew!=null  && crew.Name == name)
            {
                //we perform a remove by setting the location to null
                crews[i] = null;
                totalCrew--; //reduce the crew
                return true; //return true as the alien was removed
            }
        }

        return false; //false if the alien was not removed

    }

    /**
    This method fly at the increment of 3 warp speed and increment of 5 interstaller distance
    */
    public void Fly()
    {
        warpSpeed+=3;
        totalDistance+=5;

    }

    /**
        This method takes a warp speed and fly at that speed.
        since the distance have to move at 5 distance each 3 warp speed we can do
        (wrap / 3) * 5 then add that to the total distances already travelled
    **/
    public void Fly(int warp)
    {
        warpSpeed+=warp;
        totalDistance+=(warp / THREE) * FIVE;
    }

    /**
        This method returns the information about the ship including the speed,
        distance, ship name, total crews and all crew members as well as their roles
    **/
    public override string ToString()
    {
        string crewsString = "";
        foreach(Alien crew in crews)
        {
            if(crew!=null)
                crewsString+= "\n" + crew.ToString() ;
        }
        return $"Ship Name:{name}\nSpeed:{warpSpeed}\nDistance:{totalDistance}\nTotal Crew:{totalCrew}\nCrews:{crewsString}";
    }
}