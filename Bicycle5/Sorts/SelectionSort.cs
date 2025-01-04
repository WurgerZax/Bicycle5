using Bicycle5.Interfaces;

namespace Bicycle5.Sorts;

public class SelectionSort: ISort
{
    public int[] Sort(int[] source)
    {
        int[] result = (int[])source.Clone();

        for (int i = 0; i < result.Length; i++)
        {
            int currMinIndex = i;
            
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[j] < result[currMinIndex])
                {
                    currMinIndex = j;
                }    
            }
            (result[i], result[currMinIndex]) = (result[currMinIndex], result[i]);
        }
        
        return result;
    }   
}