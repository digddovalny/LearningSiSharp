//Задача 69

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

int MyPow(int number, int pow)
{
    if (pow == 2)
    {
        return number * number;
    }
    if (pow == 1)
    {
        return number;
    }
    if (pow % 2 == 0)
    {
        return MyPow(number, pow / 2) * MyPow(number, pow / 2);
    }
    else
    {
        return MyPow(number, pow / 2) * MyPow(number, pow / 2 + 1);
    }
}

int RecPow(int A, int B)
{
    if (B == 1)
    {
        return A;
    }
    return A * RecPow(A, B - 1);
}

int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");

int Pow = RecPow(numA, numB);
PrintResult("Число А в степени В: " + Pow);
