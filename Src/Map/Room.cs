namespace OOPAdventure;

public class Room
{
    public string RName { get; set; } = Text.Language.DefaultRoomName;
    public string RDescription { get; set; } = Text.Language.DefaultRoomDescription;

    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
        {Directions.North, -1},
        {Directions.East, -1},
        {Directions.South, -1},
        {Directions.West, -1},
        {Directions.None, -1},
    };

    public bool Visited { get; set; }
    
}