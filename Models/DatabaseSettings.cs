namespace BookStore.API.Models;

public class DatabaseSettings
{
    public string DatabaseName { get; set; } = null!;

    public string ConnectionString { get; set; } = null!;
}