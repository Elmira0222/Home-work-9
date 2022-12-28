/* Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30   */

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result >= 1) break;
        else Console.WriteLine("Entered not a number");
    }
    return result;
}


string GetValues(int n, int m)
{
    if (n == m)
    {
        return n.ToString();
    }
    return GetValues(n-1, m) + $", {n}";
}


int GetSumm (int n, int m)
{
    int min = m;
    int max = n;
    if (m > n)
    {
        min = n;
        max = m;
    }
    return (max + min) * (max - min + 1) / 2;
}


int M = GetNumber("Enter a number M greater than and equal to 1");
int N = GetNumber("Please enter a number greater than M");

GetValues(N, M);
Console.WriteLine(GetValues(N, M));
Console.WriteLine(GetSumm(M, N));

