/*задача 31
Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных
элементов массива. */

int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//Универсальный метод генерации и заполнения массива
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

//печатает одномерный массив
void Print1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int[] negativPositivSumms(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sums[0] += arr[i];
        }
        else
        {
            sums[1] += arr[i];
        }
    }
    return sums;
}

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int arrayLength = ReadData("Введите длину массива ");
int donwBorder = ReadData("Введите нижнюю границу массива ");
int topBorder = ReadData("Введите верхнюю границу массива  ");

int[] inputArray = FillArray(arrayLength, donwBorder, topBorder);
Print1DArray(inputArray);

int[] sumArray = negativPositivSumms(inputArray);

PrintResult("Сумма > 0: " + sumArray[0] + " Сумма <0: " + sumArray[1]);
Print1DArray(sumArray);
