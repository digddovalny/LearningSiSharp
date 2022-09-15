/*Напишите программу которая принмает на взод координаты двух точек
и находит расстояние между ними в 2Д пространстве*/

int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

double Execute(int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return res;
}

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int x1 = ReadData("Введите координату первой точки по оси x");
int y1 = ReadData("Введите координату первой точки по оси y");
int x2 = ReadData("Введите координату второй точки по оси x");
int y2 = ReadData("Введите координату второй точки по оси y");

double res = Execute(x1, y1, x2, y2);
PrintResult("Расстояние между точками равно " + res);
