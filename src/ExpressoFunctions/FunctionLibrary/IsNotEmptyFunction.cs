using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressoFunctions.FunctionLibrary
{
    public class IsNotEmptyFunction
    {
        public delegate bool FunctionDelegate(object value);

        public static bool Eval(object value)
        {
            return !IsEmptyFunction.Eval(value);
        }
    }
}
