/*Задача 10
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.*/

System.Random numbergenerator = new System.Random();

int number = numbergenerator.Next(100, 1000);

System.Console.WriteLine(number);

int firstDigit = number % 100;
int lastDigit = number % 10;

int secondDigit = (firstDigit - lastDigit) / 10;

System.Console.WriteLine(secondDigit);

