/*
* Задача 41
*  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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

void PrintResult(string line)
{
    System.Console.WriteLine(line);
}

int CountNum(int M)
{
    int res = 0;

    for (int i = 0; i < M; i++)
    {
        int num = ReadData("Введите число: ");
        if (num > 0)
        {
            res++;
        }
    }

    return res;
}

int val = ReadData("Введите кол-во чисел М: ");
PrintResult("Количество чисел введенных пользователем == " + val);
int res = CountNum(val);
PrintResult("Кол-во чисел больше нуля составляет: " + res);
