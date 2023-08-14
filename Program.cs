using System;

class Program
{
    static void Main()
    {
        string[] my_Array = { "Hello", "2", "world", ":-)" };

        string[] new_Array = FilterStrings(my_Array, 3);

        Console.WriteLine("My Array: [" + string.Join(", ", my_Array) + "]");
        Console.WriteLine("New Array: [" + string.Join(", ", new_Array) + "]");
    }

    static string[] FilterStrings(string[] input_Array, int max_Length)
    {
        int count = 0;
        foreach (string item in input_Array)
        {
            if (item.Length <= max_Length)
            {
                count++;
            }
        }

        string[] result_Array = new string[count];
        int index = 0;
        foreach (string item in input_Array)
        {
            if (item.Length <= max_Length)
            {
                result_Array[index] = item;
                index++;
            }
        }

        return result_Array;
    }
}
