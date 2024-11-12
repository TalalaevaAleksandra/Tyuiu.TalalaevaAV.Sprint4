using Tyuiu.TalalaevaAV.Sprint4.Task1.V23.Lib;
namespace Tyuiu.TalalaevaAV.Sprint4.Task1.V23
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Талалаева Александра Васильевна | ИИПБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму четных элементов массива                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива");
            len=Convert.ToInt32(Console.ReadLine());
            int[]nums = new int[len];
            for (int i = 0; i < len; i++) 
            {
                Console.WriteLine("Введите  значение " +i+" элемента массива");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Исходный массив");
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                Console.WriteLine(nums[i] + "\t");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int pr;
            pr = ds.Calculate(nums);
            Console.WriteLine(pr);
            Console.ReadKey();
        }
    }
}
