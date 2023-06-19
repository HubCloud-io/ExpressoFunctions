using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressoFunctions.FunctionLibrary
{
    public class IfsFunction
    {
        public delegate object FunctionDelegate(params object[] args);

        // Calculate multiple if.
        // ifs(expression1, result1, [expression2, result2,...])
        // if first expression is true returns first result, else take next pair.
        public static object Eval(params object[] args)
        {
            for (var i = 0; i < args.Length; i += 2)
            {
                var expressionResult = args[i];

                if (expressionResult is bool boolResult)
                {
                    if (boolResult == true)
                    {
                        if (i + 1 < args.Length)
                        {
                            var currentValue = args[i + 1];

                            // It is neccessary to cast number to decimal to avoid errors in next operations.
                            if (currentValue is double doubleVal)
                            {
                                return (decimal)doubleVal;
                            }
                            else if (currentValue is float floatVal)
                            {
                                return (decimal)floatVal;
                            }
                            else
                            {
                                return currentValue;
                            }

                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }

            return null;
        }
    }
}
