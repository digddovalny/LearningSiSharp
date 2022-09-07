/*Задача 13
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/

System.Console.WriteLine("Введите число ");
string? inputNumber = Console.ReadLine();

if (inputNumber.Length >= 3)
{
    char[] A = inputNumber.ToCharArray();
    System.Console.WriteLine(A[2]);

}
else
{
    System.Console.WriteLine("Такого числа нет");
}
