/* Expected Output */
//l1 = {5, 1, 6, 3} l2= {4, 7, 1}
//Output = {4, 3, 6, 5}

using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr1 = {5,1,6, 3};
        int[] arr2 = {4, 7, 1};
        int arr1total = 0;
        int arr2total = 0;
        int arrtotal = 0;
        int i, newtemp;
        for(i=0;i<arr1.Length;i++){
            arr1total = arr1total*10 + arr1[i];
        }

        for(i=0;i<arr2.Length;i++){
            arr2total = arr2total*10 + arr2[i];
        }

        arrtotal = arr1total + arr2total;

         int temp = arrtotal, count = 0;
         while (temp != 0) {
            count++;
            temp /= 10;
        }

        int[] totalarr = new int [count];

        int index = 0;

        for(i=arrtotal;i!=0;i/=10){
            newtemp = i%10;
            totalarr[index] = newtemp;
            index++;
        }

        for(i=0;i<totalarr.Length;i++){
            Console.Write(totalarr[i]+" ");
        }
    }
}
