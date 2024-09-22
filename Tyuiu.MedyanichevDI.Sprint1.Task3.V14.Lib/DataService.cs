
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MedyanichevDI.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            //string sr = Convert.ToString(number);
            double a = 0;
            double ost = number;
            double n = 1;
            while(ost%10 > 0){
                n++;
                ost =Math.Round( ost/10,0);
            }
            
            number = number * Math.Pow(10, n);
            while (number > 0)
            {
                a+=number %10;
                a *=10;
                
                number= Math.Round(number/10,0);
            }
             a = a * Math.Pow(10, -n);
            a = Math.Round(a,3);


            return a;  
        }
    }
}
