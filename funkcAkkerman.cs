int Number(int n, int m)
{
    if (n == 0) return m + 1; 
    else
      if ((n != 0) && (m == 0))
        return Number(n - 1, 1);
    else
        return Number(n - 1, Number(n, m - 1));
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int n = EnterData("Введите число: ");
int m = EnterData("Введите число: ");
Console.WriteLine(Number(n, m));
