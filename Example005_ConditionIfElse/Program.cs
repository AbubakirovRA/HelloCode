// Пример программы с условием, в зависимости от входных данных
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!!! Привет-привет!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
