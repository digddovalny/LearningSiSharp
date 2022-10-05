/*
* задача 59
* Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/
//печать массива
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

//Создаем двумерный массив
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

//ищем минимальный элемент
void MinFind(int[,] array2d, ref int x, ref int y)
{
    int min = array2d[0, 0];
    x = 0;
    y = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (min > array2d[i, j])
            {
                min = array2d[i, j];
                x = i;
                y = j;
            }
        }
    }
}

//сохдаем новый массив из старого
int[,] CreateArr(int[,] array2d, int x, int y)
{
    int k = 0;
    int m = 0;
    int[,] outArr = new int[array2d.GetLength(0) - 1, array2d.GetLength(1) - 1];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        if (i == x) { }
        else
        {
            m = 0;
            for (int j = 0; j < array2d.GetLength(1); j++)
            {
                if (j == y) { }
                else
                {
                    outArr[k, m] = array2d[i, j];
                    m++;
                }
            }
            k++;
        }
    }
    return outArr;
}

int[,] array = gen2DArray(4, 4, 0, 9);
Print2DArray(array);
int x = -1;
int y = -1;
MinFind(array, ref x, ref y);
int[,] outArr = CreateArr(array, x, y);
System.Console.WriteLine("\n");
Print2DArray(outArr);
