namespace OOPAdventure;

public class English : Language{
    
    // Creating a constructor
    public English(){
        // Accessing & modify the protected fields of Language Class.
        ChooseYourName = "Hello Player, What Is Your Name ? ";
        DefaultName = "No Name";
        Welcome = "Welcome, {0} to OOP Adventure";
        DefaultRoomName = "Room {0} ({1}, {2})";
        DefaultRoomDescription = "You are in a room with doors to the {0}.";
    }
}