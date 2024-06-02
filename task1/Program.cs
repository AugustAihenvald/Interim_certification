
void PrintNumbersFromMtoN(int m, int n)
{
    if (m <= 0 || n <= 0)
    {
        Console.WriteLine("Одно из чисел является не натуральным!");
    }
    else if (m < n)
    {
        Console.Write($"{m}, ");
        PrintNumbersFromMtoN(m + 1, n);
    }
    else if (m >= n)
    {
        Console.Write($"{m}, ");
        if(m==n) return;
        PrintNumbersFromMtoN(m - 1, n);
    }

}

int m = 10;
int n = 40;
PrintNumbersFromMtoN(m, n);