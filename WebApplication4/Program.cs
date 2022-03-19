var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var users = new List<User>();
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/register", (CreateUser body) =>
{
    users.Add(new User()
    {
        Login = body.Login,
        Password = body.Password
    });


    return "Ok!";
});

app.MapPost("/auth", (LoginUser body) =>
{
    var user = users.Find(i => i.Login == body.Login);
    if (user == null)
    {
        return "Пользователя с такими данными не существует!";
    }

    if (body.Password == user.Password)
    {
        return "Пользователь найден!";
    }

    return "Пароль не правильный!";
});


app.Run();
