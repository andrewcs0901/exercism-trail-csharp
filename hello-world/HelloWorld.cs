using System;

public static class HelloWorld
{

    struct Point
    {
        int x;
        int y;
    }

    public static void Main()
    {
        Console.WriteLine(sizeof(Point));
    }
}
