/*
* задача 55
* Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

//Тест на транспонирование матрицы
bool TestRorate(int[,] array2D)
{
    if (array2D.GetLength(0) == array2D.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] RotateArray(int[,] array2D)
{
    int buf = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = i + 1; j < array2D.GetLength(1); j++)
        {
            buf = array2D[j, i];
            array2D[j, i] = array2D[i, j];
            array2D[i, j] = buf;
        }
    }
    return array2D;
}

int m = ReadData("Введите кол-во строк М: ");
int n = ReadData("Введите кол-во столбцов N: ");

int[,] array2D = gen2DArray(m, n, 0, 20);
Print2DArray(array2D);

if(TestRorate(array2D))
{
    RotateArray(array2D);
    System.Console.WriteLine("\n");
    Print2DArray(array2D);
}
else
{
    System.Console.WriteLine("Нельзя преобразовать данную матрицу");
}
