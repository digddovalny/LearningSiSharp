/*
Задача 27
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

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

int SumofNumber(int inputNum)
{

    int summ = 0;
    while (inputNum > 0)
    {
        summ = summ + inputNum % 10;
        inputNum = inputNum / 10;
    }
    return summ;
}

int inputNumber = ReadData("Введите ваше число ");
int res = SumofNumber(inputNumber);
PrintResult("сумма цифр в числе равна " + res);
