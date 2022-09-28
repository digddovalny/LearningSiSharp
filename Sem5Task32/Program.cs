/*Задача 32
Напишите программу замена элементов массива:
положительные элементы замените на
соответствующие отрицательные, и наоборот
*/



int[] FillArray(int num, int donwBorder, int topBorder)
{
    //генератор случайных чисел
    Random numSintezator = new Random();
    //создаем массив
    int[] arr = new int[num];

    //тест границ
    if (donwBorder < topBorder)
    {
        //заполняем массив случайными числами
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(donwBorder, topBorder + 1);
        }
    }
    // возвращаем рузельтат
    return arr;
}

void Print1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int[] InversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * (-1);
    }
    return arr;
}

int arrayLength = 20;
int donwBorder = -10;
int topBorder = 13;

int[] arr = FillArray(arrayLength, donwBorder, topBorder);
Print1DArray(arr);
Print1DArray(InversArray(arr));
