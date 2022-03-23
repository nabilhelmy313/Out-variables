using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_variables
{
    internal class AreaAndCirumferance
    {
        public static double CalculateCircle(double radious,out double area)
        {

            area = (Math.PI * Math.Pow(radious, 2));
            double circumference = 2 * Math.PI * radious;
            return circumference;
        }
        public static void PrintStars(string s)
        {
            if (int.TryParse(s, out var i)) 
                Console.WriteLine(new string('*', i)); 
            else  
                Console.WriteLine("Cloudy - no stars tonight!"); 
        }

    }
}
