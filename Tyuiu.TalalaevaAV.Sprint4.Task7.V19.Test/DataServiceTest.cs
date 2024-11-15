using Tyuiu.TalalaevaAV.Sprint4.Task7.V19.Lib;
namespace Tyuiu.TalalaevaAV.Sprint4.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds=new DataService();
            int rows = 4;
            int columns = 2;
            int[,] matr = new int[rows, columns];
            string s = "90817264";
            int res = ds.Calculate(rows, columns, s);
            Assert.AreEqual(3, res);

        }
    }
}