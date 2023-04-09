static int Power(int a, int n)
{
    if (n == 0)
    {
        return 1;
    }
    return a*Power(a,n-1);
}

int a,n;

a = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());

Console.WriteLine(Power(a,n));