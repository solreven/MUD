namespace MUD;

using System.Collections.Generic;

public class Room
{
    public string Name { get; }
    public string Description { get; }

    private readonly Dictionary<string, Room> _exits = new();

    public Room(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void AddExit(string direction, Room room)
    {
        _exits[direction] = room;
    }

    public Room GetExit(string direction)
    {
        return _exits.ContainsKey(direction) ? _exits[direction] : null;
    }
}
