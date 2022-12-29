int Number(int begin, int end)
{
    if (end == begin) return begin;
    return (begin + Number(begin + 1, end));
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int begin = EnterData("Введите число: ");
int end = EnterData("Введите число: ");
Console.WriteLine(Number(begin, end));
