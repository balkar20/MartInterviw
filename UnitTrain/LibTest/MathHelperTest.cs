using System.Collections.Generic;
using System.Data;
using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibTest
{
    [TestClass]
    public class MathHelperTest
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(1, 2, 3)]
        [DataRow(1, -3, -2)]
        [DataRow(1, 0, 1)]
        public void Add(int a, int b, int expected)
        {
            var actual = MathHelper.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void Test_Add_DynamicData_Method(int a, int b, int expected)
        {
            var actual = MathHelper.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 12, 30, 42 };
            yield return new object[] { 14, 1, 15 };
        }

        [DataTestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Property)]
        public void Test_Add_DynamicData_Property(int a, int b, int expected)
        {
            var actual = MathHelper.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                yield return new object[] { 1, 1, 2 };
                yield return new object[] { 12, 30, 42 };
                yield return new object[] { 14, 1, 15 };
            }
        }
    }
}