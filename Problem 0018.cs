/* Expected Output */
// Initial array :- {7,5,1,3,9,6,2,5}
// Sorted array :- {1,2,3,5,5,6,7,9}

using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {7,5,1,3,9,6,2,5};
        int i, j, temp = 0;
        
        Console.Write("Initial Array:- ");
        Console.WriteLine(string.Join(" ", arr));
        
        for(i=0; i<arr.Length; i++){
            for(j=i+1; j<arr.Length; j++){
                if(arr[i]>arr[j]){
                   temp = arr[i];
                   arr[i] = arr[j];
                   arr[j] = temp;
                }
            }
        }

        Console.Write("Sorted Array:-  ");
        for(i=0;i<arr.Length;i++){
            Console.Write(arr[i]+" ");
        }
    }
}

/* Explanation */

/*
i = Current position that we want to put the smallest value into.

j = Checks all elements after i.

temp = Temporarily stores a value during swapping.
*/


// Example:
// arr[i] = 7
// arr[j] = 5
// temp = 0

/*
Step 1:
temp = arr[i];

temp = 7

Now:
arr[i] = 7
arr[j] = 5
temp   = 7
*/


/*
Step 2:
arr[i] = arr[j];

Now:
arr[i] = 5
arr[j] = 5
temp   = 7
*/


/*
Step 3:
arr[j] = temp;

Now:
arr[i] = 5
arr[j] = 7
temp   = 7

So:

Before:
7  5
[1, 7, 5, 3, 9, 6, 2, 5]

After:
5  7
[1, 5, 7, 3, 9, 6, 2, 5]
*/


// | `i` | Array after completing that round |
// | --: | --------------------------------- |
// |   0 | `[1, 7, 5, 3, 9, 6, 2, 5]`        |
// |   1 | `[1, 2, 7, 5, 9, 6, 3, 5]`        |
// |   2 | `[1, 2, 3, 7, 9, 6, 5, 5]`        |
// |   3 | `[1, 2, 3, 5, 9, 7, 6, 5]`        |
// |   4 | `[1, 2, 3, 5, 5, 9, 7, 6]`        |
// |   5 | `[1, 2, 3, 5, 5, 6, 9, 7]`        |
// |   6 | `[1, 2, 3, 5, 5, 6, 7, 9]`        |
// |   7 | `[1, 2, 3, 5, 5, 6, 7, 9]`        |
