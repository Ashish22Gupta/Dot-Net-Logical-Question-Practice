//Count Frequency of Each Element
//arr = {1, 2, 2, 3, 3, 3} → 1:1, 2:2, 3:3
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 2, 3, 3, 3};
        int i, j, count=0, index=1;
        
        foreach(int num in arr)
        {
            count++;
        }
        
        for(i=0;i<count;i++){
            for(j=0;j<count;j++){
                index=1;
                if(arr[i]==arr[j]){
                    index++;
                }
            }
            Console.WriteLine(arr[i]+":"+index);
        }
    }
}

//Working On it...