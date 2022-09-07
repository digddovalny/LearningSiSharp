/*Написать программу которая будет принимать на вход 2 числа 
и выводить является ли второе число кратным первому, если нет,
то выводить сотаток от деления числа 1 на число 2*/

// void var1()
// {
//     System.Console.WriteLine("Введите превое число ");
//     string? inputLineA = Console.ReadLine();
//     System.Console.WriteLine("Введите второе число ");
//     string? inputLineB = Console.ReadLine();

//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);

//     if (inputNumberA % inputNumberB == 0)
//     {
//         System.Console.WriteLine("Второе число кратно первому");
//     }
//     else
//     {
//         System.Console.WriteLine("Второе число не кратно первому, остаток от деления ----> " + inputNumberA % inputNumberB);
//     }
// }


// var1();

int inputNumberA = 0;
int inputNumberB = 0;
bool result;

ReadData();
CalculateData();
PrintData();
//получаем 2 чсила пользователя
void ReadData()
{
    System.Console.WriteLine("Введите превое число ");
    string? inputLineA = Console.ReadLine();
    System.Console.WriteLine("Введите второе число ");
    string? inputLineB = Console.ReadLine();

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);
}
//Определяем кратность чисел
void CalculateData()
{
    result = inputNumberA % inputNumberB == 0;
}
//Выводим данные 
void PrintData()
{
    if (result)
    {
        System.Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        System.Console.WriteLine("Второе число не кратно первому, остаток от деления ----> " + inputNumberA % inputNumberB);
    }
}
