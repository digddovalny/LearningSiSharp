// Задача 62
// Напишите программу, которая заполнит спирально массив 4 на 4.


int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//Заполнаяем спиральный массив
int[,] CreateMatrix(int dimension)
{
    int[,] sqareMatrix = new int[dimension, dimension];

    int buff = 1;
    int i = 0;
    int j = 0;

    while (buff <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
        sqareMatrix[i, j] = buff;
        buff++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return sqareMatrix;
}
//Печатаем спиральный массив
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int Dimension = ReadData("Введите размерность матрицы "); 
int[,] ResultMatrix = CreateMatrix(Dimension);
PrintArray(ResultMatrix);
