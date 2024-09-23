using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MedyanichevDI.Sprint1.Task7.V5.Lib
{
    public class DataService : ISprint1Task7V5
    {
        public double Calculate(double x)
        {
            double z=Math.Round((Math.Log(Math.Abs(Math.Cos(x))))/Math.Log(1+x*x),3) ;
            return z;
        }
    }
}
