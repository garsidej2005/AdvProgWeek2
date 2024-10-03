using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class MergeSort
    {
        public static void Sort(List<double> listToSort)
        {
            // Call the original Sort method with proper left and right bounds
            if (listToSort != null && listToSort.Count > 1)
            {
                Sort(listToSort, 0, listToSort.Count - 1);
            }
        }

        // Original Sort method that takes the list and left/right bounds
        public static void Sort(List<double> listToSort, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int middle = (left + right) / 2;

                // Recursively sort the first and second halves
                Sort(listToSort, left, middle);
                Sort(listToSort, middle + 1, right);

                // Merge the sorted halves
                Merge(listToSort, left, middle, right);
            }
        }

        // Function to merge two halves
        public static void Merge(List<double> listToSort, int left, int middle, int right)
        {
            // Find sizes of the two sublists to be merged
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Create temporary sublists
            List<double> leftList = new List<double>(n1);
            List<double> rightList = new List<double>(n2);

            // Copy data to temporary sublists
            for (int i = 0; i < n1; i++)
                leftList.Add(listToSort[left + i]);
            for (int j = 0; j < n2; j++)
                rightList.Add(listToSort[middle + 1 + j]);

            // Merge the temp sublists back into listToSort

            // Initial indices of first and second sublists
            int iIndex = 0, jIndex = 0;

            // Initial index of merged list
            int k = left;
            while (iIndex < n1 && jIndex < n2)
            {
                if (leftList[iIndex] <= rightList[jIndex])
                {
                    listToSort[k] = leftList[iIndex];
                    iIndex++;
                }
                else
                {
                    listToSort[k] = rightList[jIndex];
                    jIndex++;
                }
                k++;
            }

            // Copy the remaining elements of leftList, if any
            while (iIndex < n1)
            {
                listToSort[k] = leftList[iIndex];
                iIndex++;
                k++;
            }

            // Copy the remaining elements of rightList, if any
            while (jIndex < n2)
            {
                listToSort[k] = rightList[jIndex];
                jIndex++;
                k++;
            }
        }

        // Helper function to print the list
        public static void PrintList(List<double> listToSort)
        {
            foreach (double item in listToSort)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        // Driver code to test the merge sort
        static void Main()
        {
            List<double> listToSort = new List<double> { 12.5, 11.1, 13.3, 5.7, 6.9, 7.2 };

            Console.WriteLine("Given list:");
            PrintList(listToSort);

            // Using the simplified Sort method
            Sort(listToSort);

            Console.WriteLine("\nSorted list:");
            PrintList(listToSort);
        }
    }
}
