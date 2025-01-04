using Bicycle5.Interfaces;
using Bicycle5.Sorts;

namespace Bicycle5;

public class Sorter
{
    private readonly InsertionSort _insertionSort = new InsertionSort();
    private readonly GnomeSort _gnomeSort = new GnomeSort();

    public int[] Sort(int[] source, SortType sortType)
    {
        return sortType switch
        {
            SortType.Insertion => _insertionSort.Sort(source),
            SortType.Gnome => _gnomeSort.Sort(source),
            _ => throw new Exception($"Invalid sort type: {sortType}")
        };
    }
}