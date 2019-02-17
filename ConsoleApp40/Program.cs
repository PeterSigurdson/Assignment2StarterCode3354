using System;

class Program
{
    static void Main2()
    {
        bool period; // Used as out parameter.
        bool comma;
        bool semicolon;
        const string value = "has period, comma."; // Used as input string.

        TestString(value, out period, out comma, out semicolon);

        Console.WriteLine(value); // Display value.
        Console.Write("period: "); // Display labels and bools.
        Console.WriteLine(period);
        Console.Write("comma: ");
        Console.WriteLine(comma);
        Console.Write("semicolon: ");
        Console.WriteLine(semicolon);
    }

    static void TestString(string value,
        out bool period,
        out bool comma,
        out bool semicolon)
    {
        // Assign all out parameters to false.
        period = comma = semicolon = false;

        for (int i = 0; i < value.Length; i++)
        {
            switch (value[i])
            {
                case '.':
                    {
                        period = true; // Set out parameter.
                        break;
                    }
                case ',':
                    {
                        comma = true; // Set out parameter.
                        break;
                    }
                case ';':
                    {
                        semicolon = true; // Set out parameter.
                        break;
                    }
            }
        }
    }


    static bool Test(out int size)
    {
        // This method has an out parameter.
        size = 1000;
        return size >= 1000;
    }

    static void Main()
    {
        // Declare out parameter directly inside method call.
        if (Test(out int size))
        {
            Console.WriteLine(size);
        }
    }
}

