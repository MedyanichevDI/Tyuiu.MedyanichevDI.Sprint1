using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MedyanichevDI.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            double h = Convert.ToDouble(k);

            h = (h % 1000) / 100;
            h = Math.Round(h, 1);
            
            
            return (int)h;
       }
    }
}
