/*Задание 1
на вход программы подается 2 числа. Программа должна проверить
является ли 1-ое число квадратом второго*/

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    //bool outResult = (inputNumberA * inputNumberA == inputNumberB);
    bool outResult = Math.Sqrt(inputLineB) == inputLineA;

    Console.WriteLine(outResult);
}