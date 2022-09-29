/*
* Задача 45
* Напишите программу, которая будет создавать копию заданного одномерного массива с помощью
* поэлементного копирования.
*/

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
    System.Console.Write("[" + array[0] + ", ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.Write(array[array.Length - 1] + "]");
    System.Console.WriteLine();
}

int[] ArrayCopy(int[] array)
{
    int[] rev = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        rev[i] = array[i];
    }
    return rev;
}

int[] arr = genArray(10, 0, 25);
PrintArray(arr);
PrintArray(ArrayCopy(arr));