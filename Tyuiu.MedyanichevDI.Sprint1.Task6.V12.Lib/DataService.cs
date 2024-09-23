using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MedyanichevDI.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            string[] spl= value.Split(' ');
            string word = spl[spl.Length - 1];
            bool nal = false;
            for (int i = 0; i < spl.Length; i++) 
            { 
                
                if (spl[i] == word)
                    {
                    nal = true;
                    break;
                }
            }
            return nal;
        }   
    }
}
