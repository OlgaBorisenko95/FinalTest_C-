// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

int Number(int N)
{
    if (N == 1) return N;
    else
    {
        Console.Write($"{Number(N-1)}, ");
        return N;
    }
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int N = EnterData("Введите число: ");
Number(N);
Console.WriteLine(N);