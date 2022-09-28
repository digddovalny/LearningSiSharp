/*
*Задача 35
*Задайте одномерный массив из 123 случайных
чисел. Найдите количество элементов массива,
значения которых лежат в отрезке [10,99].
*/

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

//заполняем массив
int[] genArray(int arrLenght, int start, int stop)
{
    int[] array = new int[arrLenght];
    Random ran = new Random();

    for (int i = 0; i < arrLenght; i++)
    {
        array[i] = ran.Next(start, stop + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + array[0] + ", ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i] + ", ");
    }
    System.Console.Write(array[array.Length - 1] + "]");
    System.Console.WriteLine();
}

//считаем числа в массиве
int CountElem(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            sum++;
        }
    }
    return sum;
}

int[] array = genArray(123, 1, 1000);

PrintArray(array);
PrintResult("В массиве" + CountElem(array) + " элементов в отрезке [10, 99]");
