Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "оля")
{
    Console.WriteLine("Ура, это же ОЛЯ!");
}
else
{
    Console.Write("Привет,  ");
    Console.WriteLine(username);
}