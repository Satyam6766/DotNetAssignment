using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyUnitTestingExercise;

namespace MyMSTest_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        MyClass myClass = new MyClass();

        [TestMethod]
        public void Test_Add()
        {
            //Here we follow AAA
            //A=arrange
            //A=act
            //A=assert
            double a, b;
            a = 10; b = 20;
            double result = myClass.Add(a, b);
            Assert.AreEqual(result, 30);
        }

        [TestMethod]
        public void Test_Sub()
        {
            double a, b;
            a = 20; b = 10;
            double result = myClass.Sub(a, b);
            Assert.AreEqual(result, 10);
        }
        
        [TestMethod]
        public void Test_Mul()
        {
            double a, b;
            a = 10; b = 20;
            double result = myClass.Mul(a, b);
            Assert.AreEqual(result, 200);
        }
        [TestMethod]
        public void Test_Div()
        {
            double a, b;
            a = 20; b = 10;
            double result = myClass.Div(a, b);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void Test_Equal()
        {
            double a, b;
            a = 10; b = 10;
            bool result = myClass.IsEqual(a, b);
            // Assert.AreEqual(result, 30);
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void Test_AccDebit()
        {
            double a=60000;           
            string result = myClass.AccDebit(a);
            //Assert.AreEqual(result, 30);
            Assert.AreNotEqual(result, "Insufficient funds in your account.");
        }
    }
}
