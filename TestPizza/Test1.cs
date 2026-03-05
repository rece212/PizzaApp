using prjPizzaApp;

namespace TestPizza
{
    [TestClass]
    public sealed class Test1
    {
        PlainPizza testObject = new PlainPizza();
        BaconCheesePizzaBannanaPineapple baconObject = new BaconCheesePizzaBannanaPineapple();
        [TestMethod]
        public void TestPlainPizzaNamePass()
        {
            String expect = "Plain pizza with nothing else";
            String actual = testObject.Name;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestPlainPizzaNameFail()
        {
            String expect = "Plain pizza with nothing else ";
            String actual = testObject.Name;
            Assert.AreNotEqual(expect, actual);
        }
        [TestMethod]
        public void TestPlainCheese()
        {
            String expect = "";
            String actual = testObject.Cheese;
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestBaconPizza()
        {
            String expect = "The yellow stuff ";
            String actual = baconObject.Cheese;
            Assert.AreEqual(expect, actual);
        }
    }
}
