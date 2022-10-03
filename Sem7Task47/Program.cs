/*
* Задача 47
* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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

double[,] gen2DArray(int countRow, int countColomn)
{

    double[,] array2D = new double[countRow, countColomn];
    Random ran = new Random();
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColomn; j++)
        {
            array2D[i, j] = (ran.NextDouble())*100;
        }
    }
    return array2D;
}

void Print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j] + " "}");
        }
        System.Console.WriteLine();
    }
}

int row = ReadData("Введите кол-во строк ");
int column = ReadData("Введите кол-во столбцов ");

double[,] arr2D = gen2DArray(row, column);
Print2DArray(arr2D);
