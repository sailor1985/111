Console.WriteLine("Введите имя пользователя");
string? username = Console.ReadLine();

if (username.ToLower() == "маша")

{
    Console.WriteLine("Привет Wow");
}
else
{
    Console.WriteLine("Привет,");
    Console.WriteLine(username);
}