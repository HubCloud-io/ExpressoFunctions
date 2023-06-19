using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressoFunctions.FunctionLibrary
{
    public class IifFunction
    {
        public static object Eval(bool logicResult, object valueTrue, object valueFalse)
        {
            return logicResult ? valueTrue : valueFalse;
        }

        public static T Eval<T>(bool logicResult, T valueTrue, T valueFalse)
        {
            return logicResult ? valueTrue : valueFalse;
        }
    }
}
