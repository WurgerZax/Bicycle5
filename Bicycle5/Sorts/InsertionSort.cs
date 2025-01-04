using Bicycle5.Interfaces;

namespace Bicycle5.Sorts;

// for i = 2 to A.length do 
//     key = A[i]
// j = i-1
// while (j >= 0 and A[j] > key) do 
//     A[j + 1] = A[j]
// j = j - 1
// end while
// A[j+1] = key
// end [5]

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