/*Задание 8
напишите программу, которая на вход принимает одно число N,
а на выходе показывает все целые числа в промежутке от -N до N*/
System.Console.WriteLine("Введите число N");

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);

    if (inputNumberN > 0)
    {

        int startNumber = 1;

        while (startNumber < inputNumberN)
        {
            if (startNumber%2==0)
            {
                System.Console.Write(startNumber+" ");
            }
            startNumber = startNumber + 1;
        }
        if (inputNumberN%2==0)
        {
            System.Console.WriteLine(inputNumberN);
        }
    }

}