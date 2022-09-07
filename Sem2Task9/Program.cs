/*Задача 9
Напишите программу, которая выводит случайное чисо из отрезка [10, 99]
и показывает наибольшую цифру этого числа*/

System.Random numberGenerator = new System.Random();

int number = numberGenerator.Next(10, 100);

void MyVariant()



{


    System.Console.WriteLine(number);

    int firstDigit = number / 10;

    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    {
        System.Console.WriteLine("Наибольшее число равно: " + firstDigit);
    }
    else
    {
        System.Console.WriteLine("Наибольшее число равно: " + secondDigit);
    }
}

void EvginiyVariant()
{
    System.Console.WriteLine(number);

    int firstDigit = number / 10;

    int secondDigit = number % 10;
    System.Console.WriteLine((firstDigit > secondDigit)? firstDigit : secondDigit);
}

MyVariant();
