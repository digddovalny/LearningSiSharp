/*Задача 26
Напишите программу, которая принимает на вход
число и выдаёт количество цифр в числе.
*/

int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        num = num / 10;
        sum += 1;
    }

    return sum;
}

int num = ReadData("Введите число");
int res = SumDigit(num);
PrintResult($"Число {num} состоит из " + res + " цифр");
