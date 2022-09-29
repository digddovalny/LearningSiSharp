/*
* Задача 42
* Напишите программу, которая будет
* преобразовывать десятичное число в двоичное.
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

string BinConvert(int a)
{
    string res = string.Empty;

    while (a > 0)
    {
        res = a % 2 + res;
        a = a / 2;
    }

    return res;
}

int inputNumber = ReadData("Введите число: ");

PrintResult($"Число {inputNumber} в двоичном представлении: {BinConvert(inputNumber)}");
