using System;

class Program
{
    static int Recursive(int value, ref int count)
    {
        count++;
        if (value >= 10)
        {
            // throw new Exception("End");
            return value;
        }
        return Recursive(value + 1, ref count);
    }

    static int a = 5;

    static void Main()
    {
        Program.RMethod();
        Console.WriteLine(" {0} ", a);
    }

    static int RMethod()
    {
        a--;
        if (a == 0) return a; 
        return a += RMethod();
    }


}