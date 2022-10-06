//Задайте значение N. Напишите программу, которая выдает все натуральные числа  в промежутке
//от 1 до N

//Получение данных
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

string LineGenRec(int numN)
{
    //Точка остановки
    if (numN == 0)
        return "";
    string outLine = numN + " " + LineGenRec(numN - 1);
    return outLine;
}

int numN = ReadData("Введите число N: ");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);
