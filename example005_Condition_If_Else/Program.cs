Console.WriteLine("введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "jeanne")
{
    Console.WriteLine("Ура, это же Пряник!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}