using Tyuiu.SartakovaKA.Sprint0.Task3.V1.Lib;

namespace Tyuiu.SartakovaKA.Sprint0.Task3.V1.Test
{
    [TestFixture]
    public class DataServiceTest()
    {
        [Test]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5,5));
        }
    }
}