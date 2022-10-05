// Задача 54
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

//печатаем массив
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
//заполняем массив
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

int[,] UpdateArr(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        List<int> Row = new List<int>();
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Row.Add(array2D[i,j]);
            Row.Sort();
            Row.Reverse();
        }
        
        for (int j = 0; j < array2D.GetLength(1); j++)
            {
                array2D[i,j] = Row[j];
            }
    }
    return array2D;
}


int[,] array2D = gen2DArray(4, 4, 0, 20);
Print2DArray(array2D);

int[,] update2Darray = UpdateArr(array2D);
System.Console.WriteLine("\n");
Print2DArray(update2Darray);