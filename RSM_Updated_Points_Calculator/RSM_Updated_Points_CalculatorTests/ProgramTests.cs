using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using RSM_Updated_Points_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM_Updated_Points_Calculator.Tests
{
    public class ProgramTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            //Arrange            
            List<string> ops = new List<string>() { "5", "-2", "4", "C", "D", "9", "+", "+" };
            var expected = 27;

            //Act
            var result = Program.Calculate(ops);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}