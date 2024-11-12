﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TalalaevaAV.Sprint4.Task1.V23.Lib
{
    public class DataService : ISprint4Task1V23
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum+= array[i];
                }
            }
            return sum;

        }
    }
}
