// Напишите программу, которая принимает на вход 2 числа и проверяет является ли 1 число квадратом второго

int ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//Тест на квадрат
bool SqrTest(int firstNum, int secondNum)
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}
void PrintData(int firstNum, int secondNum)
{
    if (SqrTest(firstNum, secondNum))
    {
        System.Console.WriteLine("Число " + firstNum + "квадрат числа " + secondNum);
    }
    else
    {
        System.Console.WriteLine("Число " + firstNum + "не является квадратом числа " + secondNum);
    }
}


int num1 = ReadData("Введите число 1");
int num2 = ReadData("Введите число 2");

PrintData(num1,num2);
PrintData(num2,num1);
