using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TalalaevaAV.Sprint4.Task7.V19.Lib
{
    public class DataService : ISprint4Task7V19
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matr=new int[n, m];
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    matr[i,j] =int.Parse(value.Substring(i*m+j,1));
                }
            }
            int count = 0;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    if (matr[i, j] % 2 != 0) 
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
