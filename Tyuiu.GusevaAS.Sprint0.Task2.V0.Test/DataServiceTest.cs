namespace Tyuiu.GusevaAS.Sprint0.Task2.V0.Test
{
    using Tyuiu.GusevaAS.Sprint0.Task2.V0.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алиса";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Алиса", res);
        }
    }
}
