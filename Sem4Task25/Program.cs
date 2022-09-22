/* Задача 25

Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

int NuminNum(int numA, int Numb)
{
    int i = 1;
    int result = 1;
    while (i <= Numb)
    {
        result = result * numA;
        i += 1;
    }
    return result;
}

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int inputA = ReadData("Введите число А ");
int inputB = ReadData("Введите число B ");
int res = NuminNum(inputA, inputB);
PrintResult("Число А в степени В равняется: " + res);
