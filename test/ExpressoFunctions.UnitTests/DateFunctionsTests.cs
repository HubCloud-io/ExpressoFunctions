using System;
using ExpressoFunctions.FunctionLibrary;
using NUnit.Framework;

namespace ExpressoFunctions.UnitTests;

[TestFixture]
public class DateFunctionsTests
{
    [Test]
    public void EndQuarter_ReturnEndQuarterDate()
    {
        var date = new DateTime(2021, 04, 05, 10, 46, 12);
        var result = date.EndQuarter();
            
        Assert.AreEqual(new DateTime(2021, 6, 30, 23, 59, 59), result);
    }
}