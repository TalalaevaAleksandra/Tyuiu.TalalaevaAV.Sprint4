using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TalalaevaAV.Sprint4.Task5.V23.Lib
{
    public class DataService : ISprint4Task5V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {

                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }

                }
            }
            return matrix;
        }
    }
}
