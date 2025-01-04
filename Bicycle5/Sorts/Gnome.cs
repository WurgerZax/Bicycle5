using Bicycle5.Interfaces;

namespace Bicycle5.Sorts;

public class GnomeSort: ISort
{
    public int[] Sort(int[] source)
    {
        for (int i = 1; i < source.Length;)
        {
            if (source[i] < source[i-1])
            {
                (source[i-1], source[i]) = (source[i], source[i-1]);
                i--; // go "left" -> check previous elements with current
                i = i < 1 ? 1 : i; // if got to start of array -> we checked all elements from start to current with current
            }
            else
            {
                i++;
            }
        }
        
        return source;
    }
}