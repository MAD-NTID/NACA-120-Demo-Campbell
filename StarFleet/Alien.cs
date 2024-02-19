/**
This class represent an Alien crew.
An alien has name and role
**/
public class Alien
{
    private string name, role;

    public bool IsCaptainOrOfficer 
    {
        get{return role == "Captain" || role == "Chief Officer";}
    }
    
    public string Name 
    { 
        get{
            return name;
        }
        set
        {
            if(string.IsNullOrEmpty(value))
                value = "Undefined";
            name = value;
        } 
    }

    /**
        This method takes a role and check if it is valid.
        if the role is valid. True is returned. False otherwise
    **/
    private bool IsValidRole(string _role)
    {
        string[] roles = {
            "Captain",
            "Chief Officer",
            "Navigator",
            "Engineer",
            "Doctor"
        };

        foreach(string role in roles)
        {
            if(role == _role)
                return true;
        }

        return false;
    }

    public string Role 
    { 
        get{return role;} 
        set
        {
            if(IsValidRole(value) == false)
                value = "Unknown role";
            role = value;
        }
    }

    public Alien(string name, string role)
    {
        Name = name;
        Role = role;
    }

    public override string ToString()
    {
        return $"Name:{name} Role: {role}";
    }
}