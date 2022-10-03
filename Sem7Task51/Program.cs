/*
* Задача 51
* Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]+" "}");
        }
        System.Console.WriteLine();
    }
}

int[,] Fill2DArray(int rows, int colums, int start, int stop)
{
    int[,] array2D = new int[rows, colums];
    if (start < stop)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                array2D[i, j] = new Random().Next(start, stop + 1);
            }
        }
    }
    return array2D;
}

int DiagSum(int[,] arr)
{
    int sum = 0;
    int len = arr.GetLength(0) > arr.GetLength(1) ? (arr.GetLength(1)) : (arr.GetLength(0));
    for (int i = 0; i < len; i++)
    {
        sum = sum + arr[i, i];
    }
    return sum;
}

int start = 10;
int stop = 99;
int rows = ReadData("Введите кол-во строк: ");
int colums = ReadData("Введите кол-во столбцов: ");

int[,] array2D = Fill2DArray(rows, colums, start, stop);
System.Console.WriteLine($"Случайный массив {rows}x{colums}");
Print2DArray(array2D);

System.Console.WriteLine($"Сумма элементов по главной диагонали: {DiagSum(array2D)}");
