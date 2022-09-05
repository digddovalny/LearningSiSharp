/*Задача 4
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

System.Console.WriteLine("Введите первое число a");
string? inputValueA = Console.ReadLine();
int ValueA = int.Parse(inputValueA);
System.Console.WriteLine("Введите второе число b");
string? intputValueB = Console.ReadLine();
int ValueB = int.Parse(intputValueB);
System.Console.WriteLine("Введите первое число c");
string? inputValueC = Console.ReadLine();
int ValueC = int.Parse(inputValueC);

if (ValueA > ValueB)
{
    if (ValueA > ValueC)
    {
        System.Console.WriteLine($"{ValueA}, {ValueB}, {ValueC}; ---> max = {ValueA}");
    }
}
if (ValueB > ValueA)
{
    if (ValueB > ValueC)
    {
        System.Console.WriteLine($"{ValueA}, {ValueB}, {ValueC}; ---> max = {ValueB}");
    }
}
if (ValueC > ValueA)
{
    if (ValueC > ValueB)
    {
        System.Console.WriteLine($"{ValueA}, {ValueB}, {ValueC}; ---> max = {ValueC}");
    }
}