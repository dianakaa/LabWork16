using System;
using Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        User user = new() { Login = "admin", Password = "12345678" };
        Console.WriteLine($"Логин: {user.Login} \nПароль:  {user.Password}\n");

        user.PropertyChanged += User_PropertyChanged;

        user.Login = "User2005";
        Console.WriteLine($"Логин: {user.Login} \nПароль:  {user.Password}\n");
        user.Login = "User2005";
        Console.WriteLine($"Логин: {user.Login} \nПароль:  {user.Password}\n");
        user.Password = "password";
        Console.WriteLine($"Логин: {user.Login} \nПароль:  {user.Password}");
    }

    private static void User_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        Console.WriteLine($"{e.PropertyName} изменён");
    }
}