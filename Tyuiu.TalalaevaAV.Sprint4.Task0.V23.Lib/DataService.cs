﻿using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TalalaevaAV.Sprint4.Task0.V23.Lib
{
    public class DataService : ISprint4Task0V23
    {
        public int GetMultOddArrEl(int[] array)
        {
            int pr=1;
            for (int i = 0; i <= array.Length - 1; i++) 
            {
                if (i % 2 == 1) 
                {
                    pr = pr * array[i];
                }
            }
            return pr;
        }
        
    }
}