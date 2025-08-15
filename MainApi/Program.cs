using Dapper;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/users", () =>
{
    var connectionString = Environment.GetEnvironmentVariable("CONN");
    using var con = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
    con.Open();

    return con.Query<User>("SELECT * FROM users");
});

app.Run();

internal record User(int Id, string UserName);
