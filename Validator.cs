using System;
using System.Windows.Forms;

namespace Assignment02_c0842810
{
    internal static class Validator
    {
        /// <summary>
        /// wrapper for int tryParse
        /// </summary>
        /// <param name="toCheck"></param>
        /// <returns></returns>
        public static bool IsValidInteger(string toCheck)
        {
            return Int32.TryParse(toCheck,out Int32 _);
        }

        /// <summary>
        /// wrapper for int tryParse
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <param name="intValue"></param>
        /// <returns></returns>
        public static bool TryParseInt(string stringToParse, out int intValue)
        {
            bool parseSuccess = int.TryParse(stringToParse, out intValue);
            if (!parseSuccess)
            {
                MessageBox.Show("Please enter valid number of movies you want to return!");
            }
            return parseSuccess;
        }

        /// <summary>
        /// wrapper for date tryParse
        /// </summary>
        /// <param name="stringToParse">replace the input txtDueDate.Text </param>
        /// <param name="dayDue"></param>
        /// <returns></returns>
        public static bool TryParseDateTime(string stringToParse,out DateTime dayDue)
        {
            bool parseSuccess = DateTime.TryParse(stringToParse, out dayDue);
            //INPUT VALIDATION: date format
            if (!parseSuccess)
            {
                MessageBox.Show("Please enter valid date time!");
            }
            return parseSuccess;
        }

        /// <summary>
        /// wrapper for char tryParse
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <param name="customerType"></param>
        /// <returns></returns>
        public static bool TryParseCustomerType(string stringToParse, out frmLateFeeCalculator.CustomerTypeWithBreakInPercent customerType)
        {
            bool parseSuccess = Enum.TryParse(stringToParse, out customerType);
            if (!parseSuccess)
            {
                MessageBox.Show("Please enter valid type input !");
            }
            return parseSuccess;
        }
        


    }
}
