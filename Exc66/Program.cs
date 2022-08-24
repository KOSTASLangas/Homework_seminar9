// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.
string f(int m, int n)
{
    if (n == m)
        return Convert.ToString(m);

    return f(m, n-1) + ", " + n;
}


int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));

int sum = 0;
while (m <= n)
{
    sum = sum + m ;
    m++;
}
Console.WriteLine(sum);


