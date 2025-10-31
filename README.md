# C# MUD Project

A simple text-based **MUD (Multi-User Dungeon)** game built in C# with .NET 8.  
This project is structured using **Test-Driven Development (TDD)** with **xUnit tests**.

---

## Project Structure

```
MUDSolution.sln
MUD/
├── MUD.csproj
├── Program.cs
├── Room.cs
MUD.Tests/
├── MUD.Tests.csproj
├── UnitTest1.cs
.gitignore
README.md
```

- **MUD/** → Main game code: Rooms, Players, and Program entry point
- **MUD.Tests/** → Unit tests for TDD development

Optional future structure as the project grows:

```
MUD/
├── Models/      # Classes representing game entities (Room, Player, etc.)
├── Services/    # Game logic and mechanics
├── Program.cs
```

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Git

### Running the Game

```bash
cd MUD
dotnet run
```

### Running Tests

```bash
cd MUD.Tests
dotnet test
```

You should see your tests passing:

```
Passed!  - 1 passed, 0 failed, 0 skipped
```

---

## Example Output

```
Tavern: A cozy tavern filled with adventurers.
```

---

## Contributing

1. Fork the repository
2. Create a branch: `git checkout -b feature/my-feature`
3. Write code and tests
4. Commit your changes: `git commit -m "Add feature or fix"`
5. Push to your branch: `git push origin feature/my-feature`
6. Open a Pull Request

---

## License

This project is open-source and available under the [GPLv3](https://choosealicense.com/licenses/gpl-3.0/) license.
