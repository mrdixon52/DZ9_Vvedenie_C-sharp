int rec(int m, int n)
{
    if (n == m)
        return m;
    return rec(m, n - 1) + n;
}

Console.Clear();
Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));