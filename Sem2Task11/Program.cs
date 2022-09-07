/*Задача 11
Напишите программу которая выводит случайное трехзначное число
и удаляет вторую цифру этого числа*/

//Evgeniy variant

System.Random numbergenerator = new System.Random();

int number = numbergenerator.Next(100, 1000);

System.Console.WriteLine(number);

int firstDigit = number / 100;
int lastDigit = number % 10;

System.Console.WriteLine(firstDigit * 10 + lastDigit);

// // Constantin variant

// int number = new Random().Next(100, 1000);
// System.Console.WriteLine(number);
// char[] charArray = number.ToString().ToCharArray;
// System.Console.WriteLine(charArray[0]);
// System.Console.WriteLine(charArray[2]);

// //Mikhail variant