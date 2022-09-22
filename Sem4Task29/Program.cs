/*
Задача 29
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
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

int[] GenArray(int num, int start, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(start, end+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
    System.Console.WriteLine(arr[arr.Length - 1]);
}

int arrLen = ReadData("ВВедите длину массива");
int startNum = ReadData("Введите начало генерируемых чисел");
int endNum = ReadData("Введите конец генерируемых чисел");
int[] array = GenArray(arrLen, startNum, endNum);
PrintArray(array);
