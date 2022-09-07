/*Напишите программу которая на вход принимает число и
проверяет кратно ли оно одновременно 7 и 23*/

System.Console.WriteLine("Введите число ");
string? inputValue = Console.ReadLine();
int numberValue = int.Parse(inputValue);

if (numberValue % 7 == 0 && numberValue % 23 == 0)
{
    System.Console.WriteLine($"число {numberValue} кратно 23 и 7");
}
else
{
    System.Console.WriteLine($"число {numberValue} не кратно 23 и 7");
}



