using Bicycle5.Interfaces;

namespace Bicycle5.Sorts;

public class GnomeSort: ISort
{
    public int[] Sort(int[] source)
    {
        int[] result = (int[])source.Clone();
        
        for (int i = 1; i < result.Length;)
        {
            if (result[i] < result[i-1])
            {
                (result[i-1], result[i]) = (result[i], result[i-1]);
                i--; // go "left" -> check previous elements with current
                i = i < 1 ? 1 : i; // if got to start of array -> we checked all elements from start to current with current
            }
            else
            {
                i++;
            }
        }
        
        return result;
    }
}