using Bicycle5.Interfaces;

namespace Bicycle5.Sorts;

public class ShellSort: ISort
{
    public int[] Sort(int[] source)
    {
        int[] result = (int[])source.Clone();
        
        int gap = result.Length / 2;

        while (gap > 0)
        {
            for (int i = gap; i < source.Length; i++)
            {
                // remember current value and index
                int current = result[i];
                int j = i;

                // sort elements before CURRENT, but in gap distance
                while (j >= gap && result[j - gap] > current)
                {
                    result[j] = result[j - gap];
                    j -= gap;
                }
                
                // swapped element took position of current
                // so now on its position set current
                result[j] = current;
            }
            // decrease gap, to compare elements, a little closer to each other
            gap /= 2;
        }
        return result;
    }
}