using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TalalaevaAV.Sprint4.Task6.V7.Lib
{
    public class DataService : ISprint4Task6V7
    {
        public int Calculate(string[] array)
        {
            string[] mass = Array.FindAll(array, (a) => a.Length > 8);
            return mass.Length;
        }
    }
}
