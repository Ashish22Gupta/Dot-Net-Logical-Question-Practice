//Rotate Array Right by K
//arr = {1, 2, 3, 4, 5}, k = 2 → {4, 5, 1, 2, 3}
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3,4,5};
        int[] result = new int[arr.Length];
        int k=2, i, newIndex;
        
        for(i=0;i<arr.Length;i++)
        {
            newIndex=(i+k)%arr.Length;
            result[newIndex]=arr[i];
        }

        for(i=0;i<result.Length;i++)
        {
           Console.Write(result[i]+" ");
        }
    }
}