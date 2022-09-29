/*
* Задача №40
* Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
* треугольник с сторонами такой длины.
*/

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

bool TriangleTest(int a, int b, int c)
{
    return (a + b > c) && (c + a > b) && (b + c > a);
}

int a = ReadData("Введите длину стороны а: ");
int b = ReadData("Введите длину стороны b: ");
int c = ReadData("Введите длину стороны c: ");

PrintResult(TriangleTest(a,b,c)?"Такой треугольник можно построить":"такой треугольник построить нельзя");