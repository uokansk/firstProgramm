Console.Write("Your Name...");
string nameUser = Console.ReadLine();
if (nameUser.ToLower() == "маша")
{
    Console.Write("Приветствую тебя моя дорогая!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(nameUser);
}
