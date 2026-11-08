//Remove Duplicates from Array
//arr = {1, 2, 2, 3, 4, 4, 5} → {1, 2, 3, 4, 5}

using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 2, 3, 4, 4, 5};
        int i,j,index=arr.Length;
        for(i=0;i<arr.Length;i++){
            for(j=0;j<i;j++){
                if(arr[i]==arr[j]){
                    index-=1;
                }
            }
        }
        
        int[] sortedarr = new int[index];
        int temp = 0;
        bool flag;

        for(i=0;i<arr.Length;i++){

            flag = true;
            for(j=0;j<i;j++){
                if(arr[i]==arr[j])
                {
                    flag=false;
                    break;
                }
            }

            if(flag==true){
                sortedarr[temp]=arr[i];
                temp++;
            }
        }

        Console.Write("Original Array:- ");
        for(i=0;i<arr.Length;i++)
        {
            Console.Write(arr[i]+" ");
        }

        Console.Write("\nNew Array:- ");
        for(i=0;i<sortedarr.Length;i++)
        {
            Console.Write(sortedarr[i]+" ");
        }
    }
}
