namespace OOPAdventure;

public abstract class Action
{
    public virtual string Name => "";

    public virtual void Execute(string[] agrs)
    {
        throw new Exception("Nothing to execute.");
    }
}