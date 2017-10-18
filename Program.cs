using System;
using System.Linq;

namespace heapsort
{
    class Program
    {
        static void HeapSort(int [] src)
        {
            for(int i = src.Length/2-1; i >= 0; i--)
                Heapify(i,src.Length);
            for (int i = src.Length-1; i > 0; i--)
            {
                Swap(ref src[i],ref src[0]);
                Heapify(0,i);
            }
            void Heapify(int from,int offset)
            {
                int l=from<<1;
                int r=l+1;
                int largest = ((l<offset)&&src[l]>src[from])?l:from;
                if((r<offset)&&(src[r]>src[largest]))
                    largest=r;
                if(largest!=from)
                {
                    Swap(ref src[from],ref src[largest]);
                    Heapify(largest,offset);
                }
            }
            void Swap(ref int left,ref int right)
            {
                left^=right;
                right^=left;
                left^=right;
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int [] a = Enumerable.Range(1,1000).Select(x=>r.Next(1,1000)).ToArray();
            HeapSort(a);
        }
    }
}
