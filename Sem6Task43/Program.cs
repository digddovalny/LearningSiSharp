/*
* Задача 43
* 
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

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
    System.Console.WriteLine(arr[arr.Length - 1]);
}

double[] PointFind(double b1,double k1,double b2,double k2)
{
    double[] outArr = new double[2];
    outArr[0] = ((b2-b1)/(k1-k2));
    outArr[1] = k2*((b2-b1)/(k1-k2))+b2;
    return outArr;
}

double b1 = ReadData("Введите значение b1: ");
double k1 = ReadData("Введите значение k1: ");
double b2 = ReadData("Введите значение b2: ");
double k2 = ReadData("Введите значение k2: ");
double[] point = PointFind(b1,k1,b2,k2);
PrintArray(point);

