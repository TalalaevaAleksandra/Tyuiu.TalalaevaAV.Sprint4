using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TalalaevaAV.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int rows=array.GetUpperBound(0)+1;
            int colums=array.GetUpperBound(1)+1;
            int count = 0;
            
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    
                     if (array[i, j] > count && i==0 )
                     {
                        count=array[i, j];
                     }
                    
                }
            }
            return count;
        }
    }
}
