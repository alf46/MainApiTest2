var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/users", () =>
{
    var users = new User[]{new (Guid.CreateVersion7(), "alfonso"),
        new (Guid.CreateVersion7(), "maritza"),
        new (Guid.CreateVersion7(), "arlette") };
    return users;
});

app.Run();

internal record User(Guid Id, string UserName);
