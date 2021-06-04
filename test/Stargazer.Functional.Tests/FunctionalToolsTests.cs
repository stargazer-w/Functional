using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stargazer.Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stargazer.Functional.FunctionalTools;

namespace Stargazer.Functional.Tests
{
    [TestClass()]
    public class FunctionalToolsTests
    {
        static int Sum(int i1, int i2, int i3, int i4)
        {
            return i1 + i2 + i3 + i4;
        }

        [TestMethod()]
        public void CurryingTest()
        {

            Func<int, int, int, int, int> sum = Sum;
            Assert.AreEqual(sum.Currying(1).Currying(2).Currying(3)(4), sum(1, 2, 3, 4));
        }

        [TestMethod]
        public void CallWithArgsTest()
        {
            Func<int, int, int, int, int> sum = Sum;
            var args = (1, 2, 3, 4);
            Assert.AreEqual(sum.CallWithArgs(args), sum(args.Item1, args.Item2, args.Item3, args.Item4));
        }

        public record Numbers(int i1, int i2, int i3, int i4);

        [TestMethod]
        public void ToTupleTest()
        {
            var numbers = new Numbers(1, 2, 3, 4);
            var t = ToTuple<int, int, int, int>(numbers.Deconstruct);
            Assert.AreEqual(numbers.i1, t.Item1);
            Assert.AreEqual(numbers.i2, t.Item2);
            Assert.AreEqual(numbers.i3, t.Item3);
            Assert.AreEqual(numbers.i4, t.Item4);
        }
    }
}