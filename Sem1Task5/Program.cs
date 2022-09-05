/*Задание 5
напишите программу, которая на вход принимает одно число N,
а на выходе показывает все целые числа в промежутке от -N до N*/

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);

    if (inputNumberN > 0)
    {

        int startNumber = (-1) * inputNumberN;

        while (startNumber < inputNumberN)
        {
            System.Console.Write(startNumber + ", ");
            startNumber = startNumber + 1;
        }
        System.Console.WriteLine(inputNumberN);
    }

}