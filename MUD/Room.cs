namespace MUD;

public class Room
{
    public string Name { get; }
    public string Description { get; }

    public Room(string name, string description)
    {
        Name = name;
        Description = description;
    }
}