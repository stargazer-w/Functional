using NUnit.Framework;
using Functional.PipeFunction;
using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;

namespace Functional.PipeFunction.Tests
{
    [TestFixture()]
    public class EnumberableExtensionsTests
    {
        [Test()]
        public void FirstOrNullTestWithClass()
        {
            new string[0].FirstOrNull().ShouldBeNull();
            new string[] { "1" }.FirstOrNull(it => it == "2").ShouldBeNull();
        }

        [Test()]
        public void FirstOrNullTestWithNullable()
        {
            new int?[0].FirstOrNull().ShouldBeNull();
            new int?[] { 1 }.FirstOrNull(it => it == 2).ShouldBeNull();
        }

        [Test()]
        public void FirstOrNullTestWithStruct()
        {
            new int[0].FirstOrNull().ShouldBeNull();
            new int[] { 1 }.FirstOrNull(it => it == 2).ShouldBeNull();
        }
    }
}