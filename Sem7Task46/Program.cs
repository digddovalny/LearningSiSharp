/*
* Задача 46
* Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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

//Заполняем двумерный массив
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

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
//печать двумерного массива цветом
void Print2DArrayColor(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{arr[i, j]} ");
            Console.ResetColor();
        }
        System.Console.WriteLine();
    }
}

int row = ReadData("Введите кол-во строк ");
int column = ReadData("Введите кол-во столбцов ");

int[,] arr2D = gen2DArray(row,column,1,100);
Print2DArrayColor(arr2D);