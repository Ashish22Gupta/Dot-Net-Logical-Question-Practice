//Rotate Array Left by K
//arr = {1, 2, 3, 4, 5}, k = 2 → {3, 4, 5, 1, 2}
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3,4,5};
        int k=2, i, newIndex;
        int[] result = new int[arr.Length];

        for(i=0;i<arr.Length;i++)
        {
            newIndex=(i-k+arr.Length)%arr.Length;
            result[newIndex]=arr[i];
        }

        for(i=0;i<result.Length;i++)
        {
            Console.Write(result[i]+" ");
        }
    }
}