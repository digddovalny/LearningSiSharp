/*Задача 30
Напишите программу, которая выводит массив из 8
элементов, заполненный нулями и единицами в
случайном порядке.*/

int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

int[] GenArray(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// int arrLen = ReadData("ВВедите длину массива");
// int[] array = GenArray(arrLen);
// PrintArray(array);

PrintArray(GenArray(ReadData("Введите длину массива")));
