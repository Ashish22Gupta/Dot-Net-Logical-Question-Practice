// Binary Search
// Binary Search is a searching technique used to find an element in a sorted array.
// It repeatedly divides the search range into two halves.

// Working Process:
// 1. Initialize low = 0 and high = arr.Length - 1.
// 2. Calculate the middle index: mid = (low + high) / 2.
// 3. If arr[mid] == search, the element is found. Print its index.
// 4. If arr[mid] < search, search the right half by updating low = mid + 1.
// 5. If arr[mid] > search, search the left half by updating high = mid - 1.
// 6. Repeat until the element is found or low > high.
// 7. If the element is not found, print "Not Found".

// Example:
// arr = {1, 3, 5, 7, 9, 11, 13}
// search = 7
// low = 0, high = 6
// mid = (0 + 6) / 2 = 3
// arr[3] = 7
// Since arr[mid] == search, the element is found.
// Output: Found at index 3

// Note:
// Binary Search works only on a sorted array.
// Time Complexity: O(log n)
// Space Complexity: O(1) for the iterative approach.
         
using System;

namespace HelloWorld;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 9,7,1,11,5,13,3 };
        int i,j,temp=0;
        
        Console.Write("Array Before Sorting:- ");
        for(i=0;i<arr.Length;i++){
            Console.Write(arr[i]+" ");
        }
        
        for(i=0;i<arr.Length;i++){
            for(j=0;j<i;j++){
                if(arr[i]<arr[j]){
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        Console.Write("\nArray After Sorting:- ");
        for(i=0;i<arr.Length;i++){
            Console.Write(arr[i]+" ");
        }

        int search,low=0,high=arr.Length-1;
        int mid,flag=-1;

        Console.Write("\nEnter the number to search: ");
        search = Convert.ToInt32(Console.ReadLine());

        while(low<=high)
        {
            mid=(low+high)/2;

            if(arr[mid]==search)
            {
                flag=mid;
                break;
            }
            else if(arr[mid]<search)
            {
                low=mid+1;
            }
            else
            {
                high=mid-1;
            }
        }

        if (flag!=-1)
        {
            Console.WriteLine("Number "+search+" Found at index " + flag+".");
        }
        else
        {
            Console.WriteLine("Number "+search+" Not Found.");
        }
    }
}
