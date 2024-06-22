using Task3;

internal class Program
{
    private static void Main(string[] args)
    {
        User user = new() { Login = "admin", Password = "12345678" };
        Console.WriteLine($"Логин: {user.Login} \nПароль:  {user.Password}\n");
 
        user.Changed += HandleInfoEvent;

        user.Login = "User2005";
        user.Password = "password";

        user.Password = "pass";
        user.Login = null; 
    }

    private static void HandleInfoEvent(object? sender, InfoEventArgs e)
    {
        Console.WriteLine($"{e.ChangeDate}: у пользователя {((User)sender).Login} изменено {e.PropertyName}.");
        Console.WriteLine(e.ErrorText);
    }
}