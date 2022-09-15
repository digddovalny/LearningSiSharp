//написать программу, которая определяет в какой плоскости расположена точка



//чтение данных из консоли
int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

int Qutertest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

    return -1;
}

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int x = ReadData("Введите координату x");
int y = ReadData("Введите координату y");

int res = Qutertest(x, y);

PrintResult("Точка находится в четверти: " + res);
