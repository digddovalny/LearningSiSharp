/*
* задача 52
* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write($"{array2D[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] gen2DArray(int countRow, int countColomn, int start, int stop)
{
    int[,] array2D = new int[countRow, countColomn];
    Random ran = new Random();
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColomn; j++)
        {
            array2D[i, j] = ran.Next(start, stop + 1);
        }
    }
    return array2D;
}

void Print1DArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}\t");
    }
}

double[] Count(int[,] array2D)
{
    double[] arr = new double[array2D.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            arr[j] = arr[j] + array2D[i, j];
        }
        for (int k = 0; k < arr.Length; k++)
        {
            arr[k] = Math.Round(arr[k] / (double)array2D.GetLength(0),2);
        }
    }
    return arr;
}

int m = ReadData("Введите кол-во строк");
int n = ReadData("Введите кол-во столбцов");
int[,] array2D = gen2DArray(m, n, 0, 20);
Print2DArray(array2D);

double[] arr = Count(array2D);
Print1DArray(arr);
