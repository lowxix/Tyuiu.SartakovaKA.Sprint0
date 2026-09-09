using Tyuiu.SartakovaKA.Sprint0.Task2.V1.Lib;

namespace Tyuiu.SartakovaKA.Sprint0.Task2.V1.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void CheckGetMessageValid()
        {
            var name = "Ксения";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Ксения", res);
        }
    }
}