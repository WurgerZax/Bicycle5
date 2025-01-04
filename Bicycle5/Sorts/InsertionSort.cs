using Bicycle5.Interfaces;

namespace Bicycle5.Sorts;

public class InsertionSort: ISort
{
    public int[] Sort(int[] source)
    {
        int[] result = new int[source.Length];

        for (int i = 0; i < result.Length; i++)
        {
            int j = i-1;
            while(j >= 0 && result[j] > source[i])
            {
                result[j + 1] = result[j];
                j--;
            }
            result[j+1] = source[i];
        }
        
        return result;
    }
}