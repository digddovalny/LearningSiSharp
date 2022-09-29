/*
* задача 39
* Напишите программу, которая перевернёт одномерный массив
* (последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/

//Заполняем массив
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
    for (int i = 1; i < array.Length-1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.Write(array[array.Length - 1] + "]");
    System.Console.WriteLine();
}

//метод разворота массива с созданием нового массива
int[] SwapNewArray(int[] array)
{
    int[] outArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        outArray[i]=array[array.Length-1-i];
    }

    return outArray;
}

//метод разворота массива с созданием нового массива
int[] SwapArray(int[] array)
{
    int buffElement = 0;
    for (int i = 0; i < array.Length/2; i++)
    {
        buffElement=array[array.Length-1-i];
        array[array.Length-1-i]=array[i];
        array[i]=buffElement;
    }

    return array;
}

int[] arr = genArray(20,1,100);
System.Console.WriteLine("Исходный массив: ");
PrintArray(arr);
int[] copyArray = SwapNewArray(arr);
System.Console.WriteLine("Новый и перевернутый массив: ");
PrintArray(copyArray);
System.Console.WriteLine("Исходный массив: ");
PrintArray(arr);
arr = SwapArray(arr);
System.Console.WriteLine("Перевернутый исходный массив: ");
PrintArray(arr);