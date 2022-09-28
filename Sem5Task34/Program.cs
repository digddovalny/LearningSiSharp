/*
* задача 34
* Задайте массив заполненный случайными положительными трёхзначными числами. 
* Напишите программу, которая покажет количество чётных чисел в массиве.
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
    System.Console.WriteLine("[" + array[0] + ", ");
    for (int i = 1; i < array.Length-1; i++)
    {
        System.Console.WriteLine(array[i] + ", ");
    }
    System.Console.Write(array[array.Length - 1] + "]");
    System.Console.WriteLine();
}

//Вычисляем кол-во четных чисел в массиве
int evenNumsInMassive(int[] array)
{
    int amout = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            amout++;
        }
    }
    return amout;
}

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int[] array=genArray(4,100,1000);
PrintArray(array);

int result = evenNumsInMassive(array);
PrintResult("количество четных элементов в массиве ====> "+result);
