// Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//Получаем данные
int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}
//Ввыводим данные
void PrintResult(string line)
{
    System.Console.WriteLine(line);
}
// Суммируем числа от M до N
int SumRecMN(int numberM, int numberN)
{
    if (numberM >= numberN)
        return numberN;
    return numberM + SumRecMN(numberM + 1, numberN);
}

int numberM = ReadData("Введите число M: ");
int numberN = ReadData("Введите число N: ");
int result = numberM < numberN ? SumRecMN(numberM, numberN) : SumRecMN(numberN, numberM);
PrintResult(result.ToString());
