using Tyuiu.TalalaevaAV.Sprint4.Task6.V7.Lib;
namespace Tyuiu.TalalaevaAV.Sprint4.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            var pred = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика" };
            int res=ds.Calculate(pred);
            Assert.AreEqual(3, res);
        }
    }
}