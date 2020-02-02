using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Bus
    {

        public string GetBrandByModel(string brand)
        {
            string rtnvalues = "";
            if(brand == "suzuki")
            {
                rtnvalues = "xyz";
            }
            else
            {
                return rtnvalues;
            }
            return rtnvalues;
        }
        public string GetBrandByColor(string color)
        {
            string rtnvalues = "";
            if (color == "blue")
            {
                rtnvalues = "suzuki";
            }
            else
            {
                return rtnvalues;
            }
            return rtnvalues;
        }
        static void Main(string[] args)
        {
            Bus us = new Bus();
          string value1 = us.GetBrandByModel("suzuki");
            string value2 = us.GetBrandByColor("blue");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.ReadKey();
        }

        
    }
    
        
    
}
