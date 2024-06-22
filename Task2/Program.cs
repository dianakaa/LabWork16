using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        User user = new() { Login = "admin", Password = "12345678" };
        Console.WriteLine($"Логин: {user.Login} \nПароль:  {user.Password}\n");

        user.Changed += User_Changed;
        
        user.Login = "User2005";
        Console.WriteLine($"Логин: {user.Login} \nПароль:  {user.Password}\n");
        user.Password = "password";
        Console.WriteLine($"Логин: {user.Login} \nПароль:  {user.Password}");
    }

    private static void User_Changed(object? sender, EventArgs e)
    {
        Console.WriteLine($"Изменены данные пользователя со следующим логином: {((User)sender)?.Login}"); 
    }
}