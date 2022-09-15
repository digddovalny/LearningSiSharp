// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек

int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

string QuterBorderTask(int quterNum)
{
    if (quterNum == 1)
        return "x > 0  y > 0";
    if (quterNum == 2)
        return "x < 0  y > 0";
    if (quterNum == 3)
        return "x < 0  y < 0";
    if (quterNum == 4)
        return "x > 0  y < 0";

    return "-1";
}

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int quterNumber = ReadData("Введите номер четверти");

string res = QuterBorderTask(quterNumber);

PrintResult("Диапазон значений для данной четверти "+res);
