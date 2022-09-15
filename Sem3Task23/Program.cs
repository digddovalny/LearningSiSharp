/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/


int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outline = string.Empty;
    while (i < numberN)
    {
        outline = outline + Math.Pow(i, pow) + "\t";
        ++i;
    }
    outline = outline + Math.Pow(numberN, pow);
    return outline;
}
void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int num = ReadData("Введите число N ");

// string LineTop = LineNumbers(num,1);
// string LineDown = LineNumbers(num,2);

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 3));
