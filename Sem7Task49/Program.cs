/*
* задача 49
* Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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
            System.Console.Write($"{arr[i, j]}");
        }
        System.Console.WriteLine();
    }
}
int[,] Fill2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
        }
    }
    return arr;
}

int[,] Update2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] *= arr[i, j];
        }
    }
    return arr;
}

int m = ReadData("Введите кол-во столбцов");
int n = ReadData("Введите кол-во строк");
int[,] array = new int[m, n];

Fill2DArr(array);
Print2DArray(array);

Update2DArray(array);
Print2DArray(array);
