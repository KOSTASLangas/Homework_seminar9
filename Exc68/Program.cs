// Напишите программу вычесления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.

int f(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if (m != 0 && n == 0)
            return f(m - 1, 1);
        else
            return f(m - 1, f(m, n - 1));

}


int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m,n));
