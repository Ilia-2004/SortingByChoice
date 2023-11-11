using System.Linq;

namespace SortingByChoice
{
    internal class Program
    {
        // method for finding the smallest element of an array
        private static int _findSmallest(int[] arr)
        {
            int smallest = arr[0];      // to store the smallest value

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < smallest)
                    smallest = arr[i];

            return smallest;
        }

        // sorting method by choice
        private static int[] _selectionSort(int[] arr)      // sorts an array
        {
            int size = arr.Length;
            int smallest;
            int[] newArr = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                smallest = _findSmallest(arr);      // finds the smallest element in the array 
                newArr[i] = smallest;               // and adds it to a new array      
                arr = arr.Except(new int[] { smallest }).ToArray();
            }

            return newArr;
        } 

        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 3, 6, 2, 10 };
            
            _selectionSort(arr);
        }
    }
}   
