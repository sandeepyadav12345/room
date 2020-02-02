using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        public int IsDual(int[] arr, int size)
        {
           

            if (size % 2 == 0)
            {
                int m = arr[0] + arr[1];
                int n = arr[2] + arr[3];
                int o = arr[4] + arr[5];
                if (m == n & n== o)
                {
                    return 1;
                }
               }
            return 0;
            
            



        }
        public static void Main(string[] args)
        {
           int[] a = { 1, 2, 2, 1, 3,0};
            int len = a.Length;
            Program pg = new Program();
            pg.IsDual(a, len);
            int value = pg.IsDual(a,len);
            Console.WriteLine(value);
            Console.ReadKey();

        }







    }
}
