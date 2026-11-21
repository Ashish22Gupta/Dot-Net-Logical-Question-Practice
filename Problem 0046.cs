//Count Frequency of Each Element
//arr = {1, 2, 2, 3, 3, 3, 4, 4} → 1:1, 2:2, 3:3, 4:2

using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr={1, 2, 2, 3, 3, 3, 4, 4};
        int i, j, count=0, index=0;
        bool flag;

        foreach(int num in arr)
        {
            count++;
        }
        
        for(i=0;i<count;i++)
        {
            flag=false;
            for(j=0;j<i;j++)
            {
                if(arr[i]==arr[j])
                {
                    flag=true;
                    break;
                }
            }

            if(flag==false)
            {
                index=0;
                for(j=0;j<count;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        index++;
                    }
                }
                Console.WriteLine(arr[i]+":" + index);
            }
        }
    }
}