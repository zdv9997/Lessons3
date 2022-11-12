Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, вот она!");
}
else
{
    Console.Write("Капец, это не она! это ");
    Console.WriteLine(username);
}