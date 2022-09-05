/*Задание 3
на вход программы подается 2 числа. Программа должна проверить
является ли 1-ое число квадратом второго*/

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    string outDayOfWeek = "";

    switch (inputDayOfWeek)
    {
        case 1: outDayOfWeek = "поедельник"; break;
        case 2: outDayOfWeek = "вторник"; break;
        case 3: outDayOfWeek = "среда"; break;
        case 4: outDayOfWeek = "четверг"; break;
        case 5: outDayOfWeek = "пятница"; break;
        case 6: outDayOfWeek = "суббота"; break;
        case 7: outDayOfWeek = "воскресенье"; break;
        default: outDayOfWeek = "такого числа нет"; break;
    }

    outDayOfWeek=System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayOfWeek));

    System.Console.WriteLine(outDayOfWeek);

    //string[] dayOfWeek = new string[7];
    // dayOfWeek[0] = "понедельник";
    // dayOfWeek[1] = "вторник";
    // dayOfWeek[2] = "среда";
    // dayOfWeek[3] = "четверг";
    // dayOfWeek[4] = "пятница";
    // dayOfWeek[5] = "суббота";
    // dayOfWeek[6] = "воскресенье";
    // if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    // {
    //     System.Console.WriteLine("Такого дня не существует");
    // }
    // else
    // {
    //     Console.WriteLine(dayOfWeek[inputDayOfWeek-1]);
    // }
}