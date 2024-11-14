using Tyuiu.TalalaevaAV.Sprint4.Task5.V23.Lib;
namespace Tyuiu.TalalaevaAV.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matr = new int[3,3] { { -2, 5, 5}, { 7, 8, -4 }, { 5, 0, -2} };
            int[,] res = ds.Calculate(matr);
            int[,] wait = new int[3,3] { { 0, 5, 5}, { 7, 8, 0 }, { 5, 0, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}