//Задача 67

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

int RecSumDig(int num)
{
    if (num == 0)
    {
        return 0;
    }
    return num % 10 + RecSumDig(num / 10);
}

int numN = ReadData("Введите число: ");
int sum = RecSumDig(numN);
PrintResult("Сумма цифр в числе: " + sum);
