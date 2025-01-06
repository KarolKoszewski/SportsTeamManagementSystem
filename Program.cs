// See https://aka.ms/new-console-template for more information

using zadanie3;

internal class Program
{
    public static void Main(string[] args)
    {
        Team team = new Team();

        team.AddPlayer("Robert Lewandowski", "Napastnik", 41);
        team.AddPlayer("Jakub Kowalski", "Obrońca", 10);
        team.AddPlayer("Łukasz Fabijańśki", "Bramkarz", 50);

        team.ShowPlayers();

        team.ShowPlayersByPosition("Obrońca");

        team.ShowTeamAverageScore();

        team.RemovePlayer("Łukasz Fabijańśki");

        team.ShowPlayers();

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}   