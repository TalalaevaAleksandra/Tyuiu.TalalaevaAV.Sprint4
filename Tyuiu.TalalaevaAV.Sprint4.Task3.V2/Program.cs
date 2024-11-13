using Tyuiu.TalalaevaAV.Sprint4.Task3.V2.Lib;
namespace Tyuiu.TalalaevaAV.Sprint4.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнила: Талалаева А.В. | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Талалаева Александра Васильевна | ИИПБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти значение максимального элемента первой строки                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            int[,] matr = new int[5, 5] { { 4, 3, 2, 8, 7 }, { 4, 6, 5, 5, 7 }, { 3, 8, 8, 3, 5 }, { 5, 7, 5, 4, 4 }, { 8, 8, 3, 7, 6 } };
            int rows = matr.GetUpperBound(0) + 1;
            int colums = matr.GetUpperBound(1) + 1;
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"{matr[i, j]} \t");
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(matr);
            Console.WriteLine("Максимальное значение первой строки "+res);
            Console.ReadKey();
        }
    }
}
