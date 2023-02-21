using OrdinaryFraction;

namespace OrdinaryFractionTest


{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_constructor()
        {
            OrdinaryFractionCS f1 = new OrdinaryFractionCS(1,2);
            Assert.AreEqual(1, f1.get_a());
            Assert.AreEqual(2, f1.get_b());
        }

        [TestMethod]
        public void TestMethod_set()
        {
            OrdinaryFractionCS f1 = new OrdinaryFractionCS();
            f1.set_a(5);
            f1.set_b(6);
            Assert.AreEqual(5, f1.get_a());
            Assert.AreEqual(6, f1.get_b());
        }

        [TestMethod]
        public void TestMethod_common_denominator()
        {
            OrdinaryFractionCS f1 = new OrdinaryFractionCS();
            OrdinaryFractionCS f2 = new OrdinaryFractionCS();
            f1.common_denominator(f2);
            Assert.AreEqual(f1.get_b(), f2.get_b());
        }

        [TestMethod]
        public void TestMethod_sum()
        {
            OrdinaryFractionCS f1 = new OrdinaryFractionCS(1,5);
            OrdinaryFractionCS f2 = new OrdinaryFractionCS(2,3);
            OrdinaryFractionCS f3 = f1.sum(f2);
            Assert.AreEqual(13, f3.get_a());
            Assert.AreEqual(15, f3.get_b());
        }

        [TestMethod]
        public void TestMethod_diff()
        {
            OrdinaryFractionCS f1 = new OrdinaryFractionCS(3, 4);
            OrdinaryFractionCS f2 = new OrdinaryFractionCS(2, 5);
            OrdinaryFractionCS f3 = f1.diff(f2);
            Assert.AreEqual(7, f3.get_a());
            Assert.AreEqual(20, f3.get_b());
        }

        [TestMethod]
        public void TestMethod_mult()
        {
            OrdinaryFractionCS f1 = new OrdinaryFractionCS(3, 4);
            OrdinaryFractionCS f2 = new OrdinaryFractionCS(2, 5);
            OrdinaryFractionCS f3 = f1.mult(f2);
            Assert.AreEqual(6, f3.get_a());
            Assert.AreEqual(20, f3.get_b());
        }

        [TestMethod]
        public void TestMethod_division()
        {
            OrdinaryFractionCS f1 = new OrdinaryFractionCS(3, 4);
            OrdinaryFractionCS f2 = new OrdinaryFractionCS(2, 5);
            OrdinaryFractionCS f3 = f1.division(f2);
            Assert.AreEqual(15, f3.get_a());
            Assert.AreEqual(8, f3.get_b());
        }

        [TestMethod]
        public void TestMethod_decimal_fraction()
        {
            OrdinaryFractionCS f1 = new OrdinaryFractionCS(3, 4);
            Assert.AreEqual(0.75, f1.decimal_fraction());
        }

        [TestMethod]
        public void TestMethod_to_string()
        {
            OrdinaryFractionCS f1 = new OrdinaryFractionCS(3, 4);
            Assert.AreEqual("Numerator: " + 3 + "\ndenominator: " + 4, f1.to_string());
        }
    }
}