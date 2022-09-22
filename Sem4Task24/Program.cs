/*Задача 24
Напишите программу, которая принимает на вход число (А) и выдает сумму числе от 1 до А*/

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

int VariantSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

int VariantGausa(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("Введите число А");
DateTime d1 = DateTime.Now;
int res1 = VariantSimple(numberA);
System.Console.WriteLine(DateTime.Now - d1);
DateTime d2 = DateTime.Now;
int res2 = VariantSimple(numberA);
System.Console.WriteLine(DateTime.Now - d2);
PrintResult("Сумма чисел от 0 до А равна(простой метод): " + res1);
PrintResult("Сумма чисел от 0 до А равна(метод Гаусса): " + res2);
