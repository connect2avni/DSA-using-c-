﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsapratice
{
     class BinarySearch_Recursion
    {
        public int binarysearch(int[] A,int key,int l,int r)
        {
            if (l > r)
                return -1;
            else
            {
                int mid=(l+r)/2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    return binarysearch(A, key, l, mid - 1);
                else if(key> A[mid])    
                    return binarysearch(A,key,mid+1, r);
            }
            return -1;
        }
        static void Main(string[] args)
        {
            BinarySearch_Recursion s = new BinarySearch_Recursion();
            int[] A = { 15, 21, 47, 84, 96 };
           int found= s.binarysearch(A, 96, 0, 4);
            Console.WriteLine("Result:" + found);



        }
    }
}
*/