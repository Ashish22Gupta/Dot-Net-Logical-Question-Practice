using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        int i, j, max, min;
        int[] arr = {8,3,5,2,6,1,4,2};
        max = arr[0];
        min = arr[0];
        for(i=0; i<arr.Length; i++){
            if(max < arr[i]){
                max = arr[i];
            }
            if(min > arr[i]){
                min = arr[i];
            }
        }
        Console.WriteLine("Max Value: "+max);
        Console.WriteLine("Max Value: "+min);

        int temp = 0;
        for(i=0;i<arr.Length;i++){
            for(j=i+1;j<arr.Length;j++){
                if(arr[i]>arr[j]){
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.Write("Sorted Array Become:- ");
        for(i=0; i<arr.Length; i++){
            Console.Write(arr[i]+" ");
        }
    }
}
