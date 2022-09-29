/*
* Задача 44
* Не используя рекурсию, выведите первые N чисел
* Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
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

string Fibonachicycle(int numb)
{
    string res = string.Empty;
    int first = 0;
    int second = 1;
    int buf = 0;
    for (int i = 0; i < numb; i++)
    {
        res = res + " " + first;
        buf = first + second;
        first = second;
        second = buf;
    }
    return res;
}

int fibonumb = ReadData("Введите кол-во чисел фибоначи: ");
string line = Fibonachicycle(fibonumb);
PrintResult("Числа фибоначи: " + line);
