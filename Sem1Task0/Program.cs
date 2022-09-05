/*Задание 0
возведение степень в квадрат*/

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = inputNumber * inputNumber;
    Console.WriteLine(outNumber);
}