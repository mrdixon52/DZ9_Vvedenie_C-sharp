int rec(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return rec(m - 1, 1);
    return rec(m - 1, rec(m, n - 1));
}

Console.Clear();
Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));
