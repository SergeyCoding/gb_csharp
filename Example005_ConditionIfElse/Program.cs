// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя: ");
string userName = Console.ReadLine() ?? string.Empty;

if (userName != null && userName.ToLower() == "маша")
{
    Console.WriteLine("Ура!!! Маша!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(userName);
}
