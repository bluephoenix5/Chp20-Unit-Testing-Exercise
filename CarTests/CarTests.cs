using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
            Assert.AreEqual(10, 10.0009, .001);
        }

        //TODO: constructor sets gasTankLevel properly
        Car test_car;
        
        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50, 4);
        }
        
        [TestMethod]
        public void TestInitialGasTank()
        {
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }

        [TestMethod]
        public void TestNumberOfWheels()
        {
            Assert.AreEqual(4, test_car.NumberOfWheels);
        }

        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestLevelInRange()
        {
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestLevelOutOfRange()
        {
            test_car.Drive(60);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }

        //TODO: can't have more gas than tank size, expect an exception

    }
}
