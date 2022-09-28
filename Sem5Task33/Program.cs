/*
Задача 33
Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в
массиве.
*/
//Ввод данных
int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//Вывод даных
void Printresult(string line)
{
    System.Console.WriteLine(line);
}

//создаем массив
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

//выводим одномерный массив
void Print1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//ищем нужный элемент в массиве
bool FindElement(int[] arr, int elem)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            return true;
        }
    }

    return false;
}

int arrayLength = ReadData("Введите длину массива ");
int donwBorder = ReadData("Введите нижнюю границу массива ");
int topBorder = ReadData("Введите верхнюю границу массива  ");

int[] inputArray = FillArray(arrayLength, donwBorder, topBorder);
Print1DArray(inputArray);

int num = ReadData("Введите искомое число в массиве");
Printresult(num + " -> " + FindElement(inputArray, num));
