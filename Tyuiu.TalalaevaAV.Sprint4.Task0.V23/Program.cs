using Tyuiu.TalalaevaAV.Sprint4.Task0.V23.Lib;
namespace Tyuiu.TalalaevaAV.Sprint4.Task0.V23
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Талалаева Александра Васильевна | ИИПБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить произведение нечетных элементов массива                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            int[] nums = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            Console.WriteLine("Исходный массив");
            for (int i = 0; i <= nums.Length -1; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int pr;
            pr = ds.GetMultOddArrEl(nums);
            Console.WriteLine(pr);
            Console.ReadKey();
        }
    }
}
