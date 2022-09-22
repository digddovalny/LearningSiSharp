/*Задача 28
напишите программу которая показывает произведение чисел от 0 до N, где N это введенное пользователем число*/

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

long Factorial(int numN)
{
    long factorial = 1;
    while (numN > 1)
    {
        factorial *= numN;
        numN -= 1;
    }
    return factorial;
}

long CalcData(int numN)
{
    if (numN == 1)
        return 1;
    return numN * CalcData(numN - 1);
}

int inputN = ReadData("ВВедите число N ");
long result = Factorial(inputN);
PrintResult("Произведение чисел от 0 до N равно " + result);
long factorialAnatoliy = CalcData(inputN);
PrintResult("Факториал Анатолия равен: " + factorialAnatoliy);
