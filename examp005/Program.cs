Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "александр")
{
    Console.WriteLine("Ура это АЛЕКСАНДР!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}