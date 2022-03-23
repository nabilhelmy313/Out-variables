using System;
using static System.Console;
namespace Out_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Out version Out");
            Write("enter radious ");
            double radious=Convert.ToDouble(ReadLine());
            double OldVerisonArea;
            double circumference = AreaAndCirumferance.CalculateCircle(radious,  out OldVerisonArea);
            WriteLine($"circumference is {circumference}");
            WriteLine($"Area is {OldVerisonArea}");
            ///<sammary>
            ///common use of out parameters
            /// </sammary>
            /// 
            AreaAndCirumferance.PrintStars("25");
            WriteLine("new  version Out variables");
            double newcircumference = AreaAndCirumferance.CalculateCircle(radious, out double newVersionArea);
            WriteLine($"circumference is {newcircumference}");
            WriteLine($"Area is {newVersionArea}");
            


        }


    }
}
