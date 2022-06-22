using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void ConstraintCTDatePassesTest()
        {
            //Assert.Fail();
            //Arrange
            var testDate = DateTime.Now.AddDays(-59);

            //Act
            var acutal = new CTDateConstraint().ConstraintCTDate(testDate).ResultType;

            //Assert
            var expected = ResultType.PASSED;
            Assert.AreEqual(expected, acutal);
        }
        [TestMethod()]
        public void ConstraintCTDateFailsTest()
        {
            //Assert.Fail();
            //Assert.Fail();
            //Arrange
            var testDate = DateTime.Now.AddDays(-61);

            //Act
            var acutal = new CTDateConstraint().ConstraintCTDate(testDate).ResultType;

            //Assert
            var expected = ResultType.ACTION_LEVEL_3;
            Assert.AreEqual(expected, acutal);
        }
    }
}