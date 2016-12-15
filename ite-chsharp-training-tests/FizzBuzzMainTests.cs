using System;
using ita_chsharp_training;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ite_chsharp_training_tests
{
    [TestClass]
    public class FizzBuzzMainTests
    {
        private FizzBuzzMain _classUnderTest;

        [TestInitialize]
        public void Initialize()
        {
            _classUnderTest = new FizzBuzzMain();
        }

        [TestMethod]
        public void ClassUnderTest_Is_Intialized_And_Is_Of_The_Right_Type()
        {
            Assert.IsInstanceOfType(_classUnderTest, typeof(FizzBuzzMain));
        }

        [TestMethod]
        public void The_ExecuteFizzBuzz_Method_Executes_Without_Exception()
        {


        }
    }
}
