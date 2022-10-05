// Задача 56
// Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

//Ищем минимальную сумму чисел строки
int FindMinRow(int[,] array2D)
{
    int outIndexRow = -1;
    int min = int.MaxValue;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            summ += array2D[i, j];
        }
        if (min > summ)
        {
            min = summ;
            outIndexRow = i;
        }
        
        System.Console.WriteLine(summ);
    }

    return outIndexRow;
}

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int[,] array2D = gen2DArray(4, 4, 0, 5);
Print2DArray(array2D);

int IndexOfString = FindMinRow(array2D);
System.Console.WriteLine("\n");
PrintResult($" Индекс строки с минимальной суммой эелементов ===> {IndexOfString}");
