// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Recurse(int m, int n)
{
    int res = m;
    if (m > n)
        return 0;
    else
    {
        return res + Recurse(m+1, n);
    }
}

// основной код
System.Console.WriteLine("Задайте значения M и N. Программа найдёт сумму натуральных элементов в промежутке от M до N");
int numberM = ReadInt("Введите число M: ");
int numberN = ReadInt("Введите число N: ");

if (numberM == numberN)
{
    System.Console.WriteLine($"Сумма натуральных чисел от {numberM} до {numberN} равна = {numberM}");
}
else if (numberM < numberN)
{
    System.Console.WriteLine($"Сумма натуральных чисел от {numberM} до {numberN} равна = {Recurse(numberM, numberN)}");
}
else
{
    System.Console.WriteLine($"Сумма натуральных чисел от {numberN} до {numberM} равна = {Recurse(numberN, numberM)}");
}
