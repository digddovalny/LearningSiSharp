/*
*Задача 37
*Найдите произведение пар чисел в одномерном
массиве. Парой считаем первый и последний
элемент, второй и предпоследний и т.д. Результат
запишите в новом массиве.

*/

int[] GenArray(int arrLenght, int start, int stop)
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
    Console.Write("[" + array[0] + ", ");
    for (int i = 1; i < array.Length-1; i++)
    {
        Console.WriteLine(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine();
}

int[] MultiTask(int[] array)
{
    int[] outArray = new int[array.Length/2];
    for (int i = 0; i < array.Length/2; i++)
    {
        outArray[i]=array[i]*array[array.Length-1-i];
    }
    return outArray;
}

int[] array=GenArray(50,1,1000);

PrintArray(array);

int[] outArr = MultiTask(array);
PrintArray(outArr);
