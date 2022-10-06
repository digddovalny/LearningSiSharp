// Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

uint AkermanFuncRec(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AkermanFuncRec(n - 1, 1);
    else
      return AkermanFuncRec(n - 1, AkermanFuncRec(n, m - 1));
}

uint ReadData(string line)
{
    //Выводим сообщение
    System.Console.WriteLine(line);
    //Считываем число
    uint number = uint.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

void PrintResult(uint line)
{
    System.Console.WriteLine(line);
}

uint M = ReadData("Введите значение М: ");
uint N = ReadData("Введите значение N: ");

uint res = AkermanFuncRec(M,N);
PrintResult(res);
