// Написать программу вычисления функции Аккермана

static int A(int n, int m)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}

System.Console.WriteLine(A(1, 2));