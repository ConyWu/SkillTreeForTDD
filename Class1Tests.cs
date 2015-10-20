using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;


namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void calculationOfCostTest()
        {
            //Arrange
            var expected = new int[] { 6, 15, 24, 21 };
            int number = 3;
            ICost stubCost = Substitute.For<ICost>();
            stubCost.GetCost().Returns(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });

            IRevenue stubRevenue = Substitute.For<IRevenue>();
            stubRevenue.GetRevenue().Returns(new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 });

            Class1 target = new Class1(stubCost, stubRevenue);

            //Act
            var actual = target.calculationOfCost(number);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void calculationOfRevenueTest()
        {
            //Arrange
            var expected = new int[] { 50, 66, 60 };
            int number = 4;
            ICost stubCost = Substitute.For<ICost>();
            stubCost.GetCost().Returns(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });

            IRevenue stubRevenue = Substitute.For<IRevenue>();
            stubRevenue.GetRevenue().Returns(new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 });

            Class1 target = new Class1(stubCost, stubRevenue);

            //Act
            var actual = target.calculationOfCost(number);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }

}
