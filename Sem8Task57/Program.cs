/*
* задача 57
* Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
*сколько раз встречается элемент входных данных.
*/

int[,] GenArray(int Row, int Column, int start, int stop)
{
    Random rand = new Random();
    int[,] array = new int[Row, Column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(start, stop);
        }
    }
    return array;
}

//Возвращает частотный словарь элементов двумерного массива
SortedDictionary<int, int> CountDictionary(int[,] array)
{
    SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if (dict.ContainsKey(array[j, i]))
                dict[array[j, i]] = dict[array[j, i]] + 1;
            else
                dict.Add(array[j, i], 1);
        }
    }
    return dict;
}

//вывод двумерного массива
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void PrintAnswer(string answer, string title = "")
{
    System.Console.WriteLine("{0} -> {1}", title, answer);
}

int[,] array = GenArray(5, 5, 0, 10);
System.Console.WriteLine("\n------ Исходная матрица ------\n");
Print2DArray(array);

SortedDictionary<int, int> dict = CountDictionary(array);

PrintAnswer("Сколько повторений\n", "\nЧисло");
foreach (KeyValuePair<int, int> kvp in dict)
{
    PrintAnswer(kvp.Value.ToString(), kvp.Key.ToString());
}
