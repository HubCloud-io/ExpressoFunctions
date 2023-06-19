using DynamicExpresso;
using ExpressoFunctions.FunctionLibrary;
using NUnit.Framework;

namespace ExpressoFunctions.UnitTests;

[TestFixture]
public class IfsFunctionTests
{

    [Test]
    public void Eval_SimpleIf_ReturnTrueValue()
    {
        var taxId = 1;
        var result = IfsFunction.Eval(taxId == 1, 10, true, 0);

        Assert.AreEqual(10, result);
    }

    [Test]
    public void Eval_SimpleIf_ReturnFalseValue()
    {
        var taxId = 2;
        var result = IfsFunction.Eval(taxId == 1, 10, true, 0);

        Assert.AreEqual(0, result);
    }

    [Test]
    public void Eval_MultipleIf_ReturnSecondValue()
    {
        var taxId = 2;
        var result = IfsFunction.Eval(taxId == 1, 10, taxId == 2, 20, true, 0);

        Assert.AreEqual(20, result);
    }

    [Test]
    public void Eval_MultipleIf_ReturnDefaultValue()
    {
        var taxId = 3;
        var result = IfsFunction.Eval(taxId == 1, 10, taxId == 2, 20, true, 0);

        Assert.AreEqual(0, result);
    }

    [Test]
    public void Eval_WrongParametersNumber_ReturnNull()
    {
        var taxId = 2;
        var result = IfsFunction.Eval(taxId == 1, 10, 20);

        Assert.Null(result);
    }

    [Test]
    public void Eval_WrongFirstConditionType_ReturnDefaultValue()
    {
        var result = IfsFunction.Eval(10, 10, true, 0);

        Assert.AreEqual(0, result);
    }

    [Test]
    public void Eval_WrongConditionType_ReturnDefaultValue()
    {
        var result = IfsFunction.Eval(10, 10);

        Assert.Null(result);
    }

    [Test]
    public void Eval_InterpreterTest()
    {
        var interpreter = new Interpreter(InterpreterOptions.DefaultCaseInsensitive);

        IfsFunction.FunctionDelegate ifsFunction = IfsFunction.Eval;
        interpreter.SetFunction("ifs", ifsFunction);

        interpreter.SetVariable("taxId", 2);

        var formula = "ifs( taxId == 2, 0.2, true, 0)";

        var result = interpreter.Eval(formula);

        Assert.AreEqual(0.2, result);
    }
}