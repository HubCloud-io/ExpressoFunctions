using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressoFunctions.FunctionLibrary
{
    public class IsEmptyFunction
    {
        public delegate bool FunctionDelegate(object value);

        /// <summary>
        /// Chec is value empty or not.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool Eval(object value)
        {
            if (value == null)
            {
                return true;
            }

            if (value is int intValue)
            {
                return intValue == 0;
            }

            if (value is decimal decimalValue)
            {
                return decimalValue == 0M;
            }

            if (value is bool boolValue)
            {
                return boolValue == false;
            }

            if (value is DateTime dateTimeValue)
            {
                return dateTimeValue == DateTime.MinValue;
            }

            if (value is long longValue)
            {
                return longValue == 0;
            }

            if (value is byte byteValue)
            {
                return byteValue == 0;
            }

            if (string.IsNullOrEmpty(value?.ToString()))
            {
                return true;
            }

            if (string.IsNullOrWhiteSpace(value?.ToString()))
            {
                return true;
            }

            return false;
        }
    }
}
