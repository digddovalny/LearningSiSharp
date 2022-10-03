/*
* задача 50
* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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
            System.Console.Write($"{arr[i, j]}\t");
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

int FindElem(int x, int y, int[,] arr)
{
    if (x < arr.GetLength(0) && y < arr.GetLength(1))
    {
        return arr[x, y];
    }
    else
    {
        return -1;
    }
}

void PrintRes(int result)
{
    if (result >= 0)
    {
        System.Console.WriteLine("Данный элемент находмтся в масиве и равен ===> " + result);
    }
    else
    {
        System.Console.WriteLine(" Данного элемента в массиве нет");
    }
}

int m = ReadData("Введите кол-во столбцов");
int n = ReadData("Введите кол-во строк");
int[,] array2D = gen2DArray(m, n, 0, 20);
Print2DArray(array2D);

int x = ReadData("Введите позицию элемента по строке: ");
int y = ReadData("Введите позицию элемента по столбцу: ");

int res = FindElem(x, y, array2D);
PrintRes(res);
