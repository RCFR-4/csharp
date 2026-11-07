// Manage a football team with independently created player objects.

Player p1 = new Player();
p1.Name = "Carlos";
p1.Position = "Goalkeeper";

Player p2 = new Player();
p2.Name = "Pedro";
p2.Position = "Defender";

Player p3 = new Player();
p3.Name = "Lucas";
p3.Position = "Forward";

Team t1 = new Team();
t1.Name = "Santos";
t1.AddPlayer(p1);
t1.AddPlayer(p2);
t1.AddPlayer(p3);
t1.RemovePlayer(p2);

Console.WriteLine($"---{t1.Name}---");
Console.WriteLine($"Number of players: {t1.CountPlayers()}");

foreach (Player p in t1.Players)
{
    Console.WriteLine($"{p.Name} - {p.Position} ");
}

Console.WriteLine($"\nRemoved player: {p2.Name}");

class Player
{
    public string Name { get; set; } = "";
    public string Position { get; set; } = "";
}

class Team
{
    public string Name { get; set; } = "";
    public List<Player> Players { get; } = new List<Player>();

    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        Players.Remove(player);
    }

    public int CountPlayers()
    {
        return Players.Count;
    }
}
