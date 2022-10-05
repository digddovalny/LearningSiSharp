// Задача 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplicationMatrix(int[,] FirstArray2D, int[,] SecondArray2D)
{
    if (FirstArray2D.GetLength(0) != SecondArray2D.GetLength(1))
    {
        System.Console.WriteLine(
            "Умножение невозможно, так как кол-во столбцов первой матрицы не равно кол-ву столюцов второй матрицы!!!"
        );
    }
    var multMatrix = new int[FirstArray2D.GetLength(0), SecondArray2D.GetLength(1)];
    for (int i = 0; i < FirstArray2D.GetLength(0); i++)
    {
        for (int j = 0; j < SecondArray2D.GetLength(1); j++)
        {
            multMatrix[i, j] = 0;
            for (int k = 0; k < FirstArray2D.GetLength(0); k++)
            {
                multMatrix[i, j] += FirstArray2D[i, k] * SecondArray2D[k, j];
            }
        }
    }
    return multMatrix;
}

int[,] MatrixA = gen2DArray(3, 3, 0, 5);
int[,] MatrixB = gen2DArray(3, 3, 0, 5);
System.Console.WriteLine("Первая матрица");
Print2DArray(MatrixA);
System.Console.WriteLine("Вторая матрица");
Print2DArray(MatrixB);
int[,] ResultMatrix = MultiplicationMatrix(MatrixA, MatrixB);
System.Console.WriteLine("Полученный результат");
Print2DArray(ResultMatrix);
