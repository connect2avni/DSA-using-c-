﻿/*using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dsapratice
{
     class QuickSort
    {
        public void quicksort (int[] A, int low, int high)
        {
            if(low< high)
            {
                int pi= partition (A, low, high);
                quicksort(A, low, pi - 1);
                quicksort(A, pi + 1, high);
            }
        }
        public int partition(int[] A, int low, int high)
        {
            int pivot = A[low];
            int i = low + 1;
            int j = high;
            do
            {
                while (i < j &&  A[i] <= pivot);
                i = i + j;
                while (i <= j && A[j] > pivot)
                    j = j + 1;
                if (i <= j)
                    swap(A, i, j);
            } while (i < j);
            swap(A, low, j);
            return j;

        }
        public void swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i]= A[j];
            A[j]= temp;
        }
        public void display(int[] A,int n)
        {
            for(int i= 0;i< n; i++)
                Console.WriteLine(A[i]+"");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            QuickSort s= new QuickSort();
            int[] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array");
            s.display(A, 6);
            s.quicksort(A, 0,5);
            Console.WriteLine("Sorted Array");
            s.display(A, 6);
            Console.ReadKey();

        }
    }
}
*/