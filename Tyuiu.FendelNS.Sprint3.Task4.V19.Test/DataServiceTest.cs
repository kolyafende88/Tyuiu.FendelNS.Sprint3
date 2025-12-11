using Tyuiu.FendelNS.Sprint3.Task4.V19.Lib;
namespace Tyuiu.FendelNS.Sprint3.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 5;
            int stopValue = 5;
            double wait = 1.446;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}