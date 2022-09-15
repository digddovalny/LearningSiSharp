/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

bool Testpalindrom(int palindrom)
{
    if ((palindrom / 10000 == palindrom % 10) && ((palindrom / 1000) % 10 == (palindrom / 10) % 10))
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintResult(bool line)
{
    System.Console.WriteLine(line);
}

int palindrom = ReadData("Введите слово для его проверки на полиндромность");
PrintResult(Testpalindrom(palindrom));
