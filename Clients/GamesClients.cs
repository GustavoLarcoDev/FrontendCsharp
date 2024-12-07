namespace GameStore.FrontEnd.Clients;
using GameStore.FrontEnd.Models;
public class GamesClients
{
    private readonly List<GameSummary> games =
    [
        new(){
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateOnly(2010, 9, 30)
        },
        new(){
            Id = 2,
            Name = "Minecraft",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateOnly(2010, 9, 30)
        },
        new(){
            Id = 3,
            Name = "Fortnite",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateOnly(2010, 9, 30)
        }
    ];

    private readonly Genre[] genres = new GenresClients().GetGenres();


    public GameSummary[] GetGames() => [.. games];
    public void AddGame(GameDetails game)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);
        var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));
        var gameSummary = new GameSummary
        {
            Id = games.Count + 1,
            Name = game.Name,
            Genre = game.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
        games.Add(gameSummary);
    }
}
