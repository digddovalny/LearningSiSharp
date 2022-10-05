/*
* задача 53
* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива
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
//Меняем первую строку с последней местами
void Change2DArray(int[,] array2D)
{
    //int[] arr = new int[array2D.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(1); i++)
    {
        // arr[i]=array2D[0,i];
        // array2D[0,i]=array2D[array2D.GetLength(0)-1,i];
        // array2D[array2D.GetLength(0)-1,i]=arr[i];
        int temp =array2D[0,i];
        array2D[0,i]=array2D[array2D.GetLength(0)-1,i];
        array2D[array2D.GetLength(0)-1,i]=temp;
    }
}

int m = ReadData("Введите кол-во строк М: ");
int n = ReadData("Введите кол-во столбцов N: ");

int[,] array2D = gen2DArray(m, n, 0, 20);
Print2DArray(array2D);

Change2DArray(array2D);
System.Console.WriteLine("\n");
Print2DArray(array2D);