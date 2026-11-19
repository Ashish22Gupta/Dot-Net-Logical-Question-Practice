//Merge Two Sorted Arrays
//arr1 = {1, 3, 5}, arr2 = {2, 4, 6} → {1, 2, 3, 4, 5, 6}
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr1 = {1,3,5};
        int[] arr2 = {2,4,6};
        int i;
        int[] result = new int[arr1.Length+arr2.Length];
        result = arr1.Concat(arr2).ToArray();
        Array.Sort(result);
        
        Console.Write("Array after merge & Short:- ");

        for(i=0;i<result.Length;i++)
        {
           Console.Write(result[i]+" ");
        }
        
        Console.WriteLine("\n\n|||*-*-*-*-*-*-*-*-OR-*-*-*-*-*-*-*-*|||\n");
        
        int[] mergearr = new int[arr1.Length+arr2.Length];
        int count1=0, count2=0, totalcount=0, index=0, j, temp=0;
        foreach(int num in arr1)
        {
            count1++;
        }
        
        foreach(int num in arr2)
        {
            count2++;
        }
        
        totalcount = count1+count2;
        
        for(i=0;i<count1;i++){
            mergearr[index] = arr1[i];
            index++;
        }
        
        for(i=0;i<count2;i++){
            mergearr[index] = arr2[i];
            index++;
        }
        
        for(i=0;i<totalcount;i++){
            for(j=0;j<totalcount;j++){
                if(mergearr[i] < mergearr[j]){
                   temp = mergearr[i];
                   mergearr[i] = mergearr[j];
                   mergearr[j] = temp;
                }
            }
        }
        
        Console.Write("Array after merge & Short:- ");
        for(i=0;i<totalcount;i++)
        {
           Console.Write(mergearr[i]+" ");
        }
    }
}