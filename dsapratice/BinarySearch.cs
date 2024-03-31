using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsapratice
{
     class BinarySearch
    {
        public int binarySearch(int[] A, int n, int Key)
        {
            int l = 0;
            int r = n - 1;
            while(l<=r)
            {
                int mid=(l+r)/2;
                if (Key == A[mid])
                    return mid;
                else if (Key < A[mid])
                    r = mid - 1;
                else if (Key > A[mid])
                    l=mid + 1;
                    

            }
            return -1;
        }
        static void Main(string[] args)
        {
            BinarySearch s = new BinarySearch();
            int[] A = { 15, 21, 47, 84, 96 };
            int found=s.binarySearch(A, 5, 96);
            Console.WriteLine(found);
        }
    }
}
