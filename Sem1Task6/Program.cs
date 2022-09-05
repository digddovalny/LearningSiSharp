/*Задача 6
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка)
*/

System.Console.WriteLine("Введите число: ");
string? inputValue = Console.ReadLine();
int Value = int.Parse(inputValue);

if (Value % 2 == 0)
{
    System.Console.WriteLine($"число {Value} является четным");
}
else
{
    System.Console.WriteLine($"число {Value} является нечетным");
}