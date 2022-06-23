Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();
if(username.ToLower()=="катя")
{
    Console.WriteLine("Ура, этоже Катя!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}