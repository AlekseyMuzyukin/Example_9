Console.Write("Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int n = Convert.ToInt32(Console.ReadLine());

int akkermanFuncion = AkkermanFuncion(m, n);
Console.WriteLine(akkermanFuncion);
int AkkermanFuncion(int m, int n)

{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFuncion(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return AkkermanFuncion(m - 1, AkkermanFuncion(m, n - 1));
    }
    return 0;
}