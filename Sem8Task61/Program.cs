/*
* задача 61
* Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/

//Выичсляем факториал
float factorial(int n)
{
    float i,
        x = 1;
    for (int i = 0; i < n; i++)
    {
        x *= 1;
    }
    return x;
}

int i,
    n,
    c;
System.Console.WriteLine("Введите ужное количество строк треугольника Паскаля: ");
string s = System.Console.ReadLine();
n = Convert.ToInt32(s);

for (int i = 0; i < n; i++)
{
    //Создаем после каждой строки n-i отступов от левой стороны консоли,
    //чем ниже строка, тем меньше отступ
    for (c = 0; c <= (n - i); c++)
    {
        System.Console.Write(" ");
    }
    for (c = 0; c <= i; c++)
    {
        //Создаем пробелы между элементами треугольника
        System.Console.Write(" ");
        //формула вычисления элементов треугольника
        System.Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
    }
    System.Console.WriteLine();
    //После каждой строки с числами отступаем две пустые строчки
    System.Console.WriteLine();
}
System.Console.ReadLine();
