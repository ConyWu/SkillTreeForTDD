using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;


namespace CountProductsLibrary.Tests
{
    [TestClass()]
    public class CountProductsTests
    {
        [TestMethod()]
        public void calculationOfCostTest()
        {
            //Arrange
            var expected = new int[] { 6, 15, 24, 21 };
            int number = 3;
            IProperty stubCost = Substitute.For<IProperty>();
            stubCost.GetCost().Returns(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });

            CountProducts target = new CountProducts();

            //Act
            var actual = target.calculation(number, stubCost);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void calculationOfRevenueTest()
        {
            //Arrange
            var expected = new int[] { 50, 66, 60 };
            int number = 4;

            IProperty stubRevenue = Substitute.For<IProperty>();
            stubRevenue.GetRevenue().Returns(new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 });

            CountProducts target = new CountProducts();

            //Act
            var actual = target.calculation(number, stubRevenue);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }

}
