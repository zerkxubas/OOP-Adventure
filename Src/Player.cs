// Using our Own Namespace.
namespace OOPAdventure;

// Creating Player as child class which inherits the Character as Parent class
public class Player : Character{

    // Character class constructor has a parameter so we use 'base()'
    public Player(string name) : base(name){

    }
}