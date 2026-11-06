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
        for(i=0;i<arr.Length;i++){
            for(j=i;j<arr.Length;j++){
                if(arr[i]!=arr[j]){
                    sortedarr[temp]=arr[i];
                    temp++;
                }
            }
        }
    }
}
