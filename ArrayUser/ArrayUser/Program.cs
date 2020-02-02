using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUser
{
    class Program
    {
        public int IsDual(List<int>  arr, int size)
        {
            if (size % 2 == 0)
            {
                int m, i;
                var mark = new List<int>();

                for (i = 0; i + 1 <= size; i++)
                {
                    if (i % 2 == 0)
                    {




                        m = arr[i] + arr[i + 1];

                        mark.Add(m);

                    }
                    m = 0;
                    

                }

                int K = mark.Count;
                
                int l;
                for (l = 0; l < K; l++)
                {
                    
                    
                        if (mark[l] != mark[0])
                        {
                            return 0;
                        }
                    
                }
                return 1;
            }
            return 0;
        }
        public static void Main(string[] args)
        {
            
            Console.WriteLine("enter the size of the array");
            string len = Console.ReadLine();
            int userLen = 0;
            bool x = int.TryParse(len, out userLen);

            while (!x)
            {
                Console.WriteLine("Enter integer value");
                 len = Console.ReadLine();
                x = int.TryParse(len, out userLen);
                
               
                


            }


            var userArray = new List<int>();
            Console.WriteLine("Enter the values to the array");
            for (int i = 0; i < userLen; i++)
            {
                string userValue = Console.ReadLine();
                int userInt;
                while (!int.TryParse(userValue, out userInt))
                {
                    Console.WriteLine("Enter integer value");
                    userValue= Console.ReadLine();
                    int.TryParse(userValue, out userInt);


                }
                userArray.Add(userInt);
            }
            Program pg = new Program();
            pg.IsDual( userArray, userLen);
            int value = pg.IsDual(userArray, userLen);
            Console.WriteLine(value);
            Console.ReadKey();

        }
    }
}

