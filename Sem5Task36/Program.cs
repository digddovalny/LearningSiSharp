/*
* задача 36
* Задайте одномерный массив, заполненный случайными числами. 
* Найдите сумму элементов, стоящих на нечётных позициях.
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

//Вычисляем сумму чисел нечётных позиций в массиве

int SummOddElem(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (i%2!=0)
        {
            summ+=array[i];
        }
    }
    return summ;
}

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int[] array=genArray(4,-100,100);
PrintArray(array);

int result = SummOddElem(array);
PrintResult("сумма элементов стоящие на нечетных местах равно ====> "+result);
