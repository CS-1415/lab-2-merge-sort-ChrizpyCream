//Christopher Hercules, 1410, 1/22/2025

using System.Diagnostics;

public class TDD

{
    static void Main(string[] args)
    {
       System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(CombineArrays(new int[]{1, 3, 5}, new int []{-5, 3, 6, 7}), new int[]{-5, 1, 3, 3, 5, 6, 7}));
    System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(CombineArrays(new int[]{-5, 2, 5, 8, 10}, new int[]{1, 2, 5}), new int[]{-5, 1, 2, 2, 5, 5, 8, 10}));
    System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(SortViaMergesort(new int[]{6, 1, -5, 3, 5, 3, 7}), new int[]{-5, 1, 3, 3, 5, 6, 7}));
    System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(SortViaMergesort(new int[]{1, 10, -5, 2, 5, 2, 5, 8}), new int[]{-5, 1, 2, 2, 5, 5, 8, 10}));
    Console.WriteLine("pass");
    }
    static int[] CombineArrays(int[] a, int[] b)
    {
        
    }
}