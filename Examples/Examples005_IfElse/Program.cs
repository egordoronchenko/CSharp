// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя");
string userName = Console.ReadLine();

if(userName.ToLower == "Маша")
{
    Console.WriteLine("Ура! Это Маша");
}
else
{
Console.WriteLine("Привет, "+ userName);

}