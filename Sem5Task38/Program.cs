/*
* задача 38
* Задайте массив вещественных чисел. 
* Найдите разницу между максимальным и минимальным элементов массива. 
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

//вычисляем разницу между максимальным и минимальным элементом массива

int differenceMaxAndMinelem(int[] array)
{
    //используем метод сортировки массива
    Array.Sort(array);
    int dif = array[array.Length-1]-array[0];
    return dif;
}
    
void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int[] array=genArray(5,0,100);
PrintArray(array);

int result = differenceMaxAndMinelem(array);
PrintResult("сумма элементов стоящие на нечетных местах равно ====> "+result);
