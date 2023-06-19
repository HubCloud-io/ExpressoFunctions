using ExpressoFunctions.FunctionLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoFunctions.UnitTests
{
    [TestFixture]
    public class DateDiffFunctionTests
    {

        [Test]
        [TestCase("day", "2021-10-17", "2021-10-18", 1)]
        [TestCase("Day", "2021-10-17", "2021-10-15", -2)]
        [TestCase("month", "2021-08-17", "2021-10-18", 2)]
        public void Eval_CalcDateDifference_ReturnNumberOfIntervals(string datePart,
            string dateStartStr,
            string dateFinishStr,
            decimal expected)
        {
            var dateStart = DateTime.Parse(dateStartStr);
            var dateFinish = DateTime.Parse(dateFinishStr);

            var result = DateDiffFunction.Eval(datePart, dateStart, dateFinish);

            Assert.AreEqual(expected, result);
        }
    }
}
