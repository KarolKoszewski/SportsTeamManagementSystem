namespace zadanie3;

public class Team
{
    private List<Player> players;

    public Team()
    {
        players = new List<Player>();
        Console.WriteLine("Stworzono nową drużynę");
    }

    public void AddPlayer(string name, string position, int score)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Błąd podaj normalne imie");
            return;
        }
        
        var player = new Player(name, position, score);
        players.Add(player);
        Console.WriteLine($"Dadano gracza: {name} na pozycje {position}");
    }

    public void RemovePlayer(string name)
    {
        Player playerToRemove = null;
        foreach (var player in players)
        {
            if (player.Name == name)
            {
                playerToRemove = player;
                break;
            }
            
        }

        if (playerToRemove != null)
        {
            players.Remove(playerToRemove);
            Console.WriteLine($"Usunięto gracza: {name}");
        }
        else
        {
            Console.WriteLine($"Nie ma zawodnika o imieniu: {name}");
        }
    }
}