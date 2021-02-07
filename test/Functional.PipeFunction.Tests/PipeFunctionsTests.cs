using NUnit.Framework;
using Functional.PipeFunction;
using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;

namespace Functional.PipeFunction.Tests
{
    [TestFixture()]
    public class PipeFunctionsTests
    {
        [Test()]
        public void ToTest()
        {
            "4".Let(int.Parse)
               .Let(it => Math.Sqrt(it))
               .To(out var result);

            result.ShouldBe(2);
        }
    }
}