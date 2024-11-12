using Tyuiu.TalalaevaAV.Sprint4.Task2.V18.Lib;
namespace Tyuiu.TalalaevaAV.Sprint4.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 2,6,7,9,3,5,7 };
            int res = ds.Calculate(nums);
            Assert.AreEqual(12, res);
        }
    }
}