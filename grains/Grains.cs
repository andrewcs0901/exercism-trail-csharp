using System;
using System.Threading.Tasks;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }
        return (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        ulong total = 0;
        for (int i = 1; i < 65; i++) total += Square(i);
        return total;
    }
}


/*
f(1) = 1
f(2) = f(2-1) * 2 = 2
f(3) = f(3-1) * 2 = 4
f(4) = f(4-1) * 2 = 8
(5) = f(5-1) * 2 = 16


*/