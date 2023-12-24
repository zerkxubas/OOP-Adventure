namespace OOPAdventure;

public abstract class Language
{
    // using protected fields for set.
    public string Welcome { get; protected set;} = "";
    public string ChooseYourName { get; protected set;} = "";
    public string DefaultName { get; protected set;} = "";

}