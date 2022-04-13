using System;
using System.Windows.Forms;

namespace LatefeeCalc_c0842810
{
    internal static class Validator
    {
        /// <summary>
        /// Check if entry is empty or null
        /// Return false if entry is empty is empty or null
        /// </summary>
        /// <param name="toCheck"></param>
        /// <returns></returns>
        public static bool IsPresent(string toCheck) 
        {
            return string.IsNullOrEmpty(toCheck);
        }

        /// <summary>
        /// Wrapper for int tryParse
        /// Return false if try parse int fails
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <param name="intValue"></param>
        /// <returns></returns>
        public static bool IsInt32(string stringToParse, out int intValue)
        {
            bool parseSuccess = int.TryParse(stringToParse, out intValue);
            bool isPositive = true;
            if (frmLateFeeCalculator.errorNum == 0)
            {
                if (!parseSuccess)
                {
                    MessageBox.Show("Please enter valid number of movies you want to return!");
                }
                if (intValue <= 0)
                {
                    MessageBox.Show("The number of movies must be greater than 0.");
                    isPositive = false;
                }
            }

            return parseSuccess && isPositive;
        }

        /// <summary>
        /// Wrapper for date tryParse
        /// Check if the string is a valid datetime object
        /// Return false if the string is not a valis datetime object
        /// </summary>
        /// <param name="stringToParse">get the input from txtDueDate.Text </param>
        /// <param name="daytime">output a valid datetime object</param>
        /// <returns>boolean</returns>
        public static bool IsDateTime(string stringToParse,out DateTime daytime)
        {
            bool parseSuccess = DateTime.TryParse(stringToParse, out daytime);
            if (frmLateFeeCalculator.errorNum == 0)
            {
                if (!parseSuccess)
                {
                    MessageBox.Show("Please enter valid date time!");
                }
                if (!IsPast(daytime))
                {
                    MessageBox.Show("Due date cannot precedes the current date!");
                }
            }
               
            return parseSuccess && IsPast(daytime);
        }

        /// <summary>
        /// Return false if daytime comes after current day
        /// </summary>
        /// <param name="daytime"></param>
        /// <returns></returns>
        public static bool IsPast(DateTime daytime)
        {
            bool isValid;
            DateTime current = DateTime.Now;
            if (DateTime.Compare(current,daytime) <= 0)
            {
                isValid = false;
            }
            else { 
                isValid = true;
            }
            return isValid;
        }

        /// <summary>
        /// wrapper for char tryParse
        /// Return false if Customer Type is not in Enum
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <param name="customerType"></param>
        /// <returns></returns>
        public static bool IsCustType(string stringToParse, out frmLateFeeCalculator.CustomerTypeWithBreakInPercent customerType)
        {
            bool parseSuccess = Enum.TryParse(stringToParse, out customerType);
            if (frmLateFeeCalculator.errorNum == 0)
            {
                if (!parseSuccess)
                {
                    MessageBox.Show("Valid customer type : N / J / L ");
                }
            }
                
            return parseSuccess;
        }
        


    }
}
