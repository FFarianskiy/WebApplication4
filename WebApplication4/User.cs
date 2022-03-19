public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public Routs Rout { get; set; }
    
}

public class LoginUser
{
    public string Login { get; set; }
    public string Password { get; set; }
    
    
}

public class CreateUser
{
    public string Login { get; set; }
    public string Password { get; set; }
}

public enum Routs
{
    Use,
    Admin,
    Customer
}
