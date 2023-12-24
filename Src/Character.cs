// Using our own Namespace to avoid conflict
namespace OOPAdventure;

public abstract class Character
{
    // Character Name.
    public string CName{ get; set; }

    // creating a constructor
    public Character(string name)
    {
        CName = name;
    }

    // Getting Character Name

}