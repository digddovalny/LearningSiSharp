/*Задача 15
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/

// System.Console.WriteLine("Введите цифру ");
// string? inputNumber = System.Console.ReadLine();
// int number = int.Parse(inputNumber);

// if (number <= 5 && number > 0)
// {
//     System.Console.WriteLine($"{number} ---> нет");
// }
// if (number >= 6 && number <= 7)
// {
//     System.Console.WriteLine($"{number} ---> да");
// }
// else
// {
//     System.Console.WriteLine("Такого дня недели не бывает");
// }
int number = 0;
inputNumber();
calculateNumber();
//Вводим цифру дня недели
void inputNumber()
{
    System.Console.WriteLine("Введите цифру ");
    string? inputNumber = System.Console.ReadLine();
    number = int.Parse(inputNumber);
}
//проверяем, является ли цифра, обозначающаяя день недели выходным?
void calculateNumber()
{
    if (number <= 5 && number > 0)
    {
        System.Console.WriteLine($"{number} ---> нет");
    }
    if (number >= 6 && number <= 7)
    {
        System.Console.WriteLine($"{number} ---> да");
    }
}
