/*Задача 2
Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
*/

System.Console.WriteLine("Введите первое число a");
string? inputValueA = Console.ReadLine();
int ValueA = int.Parse(inputValueA);
System.Console.WriteLine("Введите второе число b");
string? intputValueB = Console.ReadLine();
int ValueB = int.Parse(intputValueB);
if (ValueA > ValueB)
{
    System.Console.WriteLine($"a = {ValueA}; b = {ValueB} ---> max = {ValueA}");
}
else
{
    System.Console.WriteLine($"a = {ValueA}; b = {ValueB} ---> max = {ValueB}");
}
