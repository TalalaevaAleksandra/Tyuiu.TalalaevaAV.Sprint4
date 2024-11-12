using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TalalaevaAV.Sprint4.Task2.V18.Lib
{
    public class DataService : ISprint4Task2V18
    {
        public int Calculate(int[] array)
        {
            int pr = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    pr = pr * array[i];
                }
            }
            return pr;
        }
    }
}
