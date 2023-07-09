// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Acerman (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Acerman(M - 1, 1);
    if (M > 0 && N > 0) return Acerman(M - 1, Acerman(M, N - 1));
    return Acerman(M, N);
}
// основной код

int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
System.Console.WriteLine($"Функция Аккермана A({m},{n}) = {Acerman(m, n)}");

