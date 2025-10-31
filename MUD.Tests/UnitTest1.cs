using Xunit;
using MUD;

namespace MUD.Tests;

// These are tests for the Room Class.
public class RoomTests
{
    [Fact]
    public void Room_ShouldStoreNameAndDescription()
    {
        var room = new Room("Tavern", "A cozy tavern filled with adventurers.");

        var name = room.Name;
        var description = room.Description;

        Assert.Equal("Tavern", name);
        Assert.Equal("A cozy tavern filled with adventurers.", description);
    }

}