using Bicycle5.Interfaces;

namespace Bicycle5;

class Program
{
    static void Main(string[] args)
    {
        Sorter sorter = new Sorter();
        
        int[] array = [5, 4, 1, 12, 8, 2, 9, 0, 15];
        
        foreach (SortType type in Enum.GetValues(typeof(SortType)))
        {
            int[] result = sorter.Sort(array, type);
            Console.Write(type + ":");
            ArrayPrinter(result);
        }
    }

    private static void ArrayPrinter(int[] array)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }
}