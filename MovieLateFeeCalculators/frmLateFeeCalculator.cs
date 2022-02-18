using System;
using System.Windows.Forms;

namespace Assignment02_c0842810
{
    public partial class frmLateFeeCalculator : Form
    {
        //create a public enum
        /// <summary>
        /// WARNING *enum values should be multiplied by 0.01 for final calculation
        /// </summary>
        public enum CalculatorTypesWithFeeInCents
        {
            NewReleases = 200,
            LibraryMovies = 57,
            KidsMovies = 15,
            Unknown = 0
        }

        public enum CustomerTypeWithBreakInPercent
        {
            N = 0,
            J = 5,
            L = 10
        }
        //declare a type movieLateFeeCalcType
        private CalculatorTypesWithFeeInCents movieLateFeeCalcType;
        //private CustomerTypeWithBreakInPercent breakType;

        //declare a class variable for total number of movies
        private int totalNumberOfMovies;

        public frmLateFeeCalculator()
        {
            InitializeComponent();

            //populate Today`s date and show it in the textbox txtCurrent
            txtCurrent.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
        }

        private void frmNewReleases_Shown(object sender, EventArgs e)
        {
            SetupFormForType();

        }

        /// <summary>
        /// Initializes a form for a specific type of calculator
        /// </summary>
        private void SetupFormForType()
        {
            if (movieLateFeeCalcType == CalculatorTypesWithFeeInCents.Unknown)
            {
                MessageBox.Show("No Calculator Type Set");
                Close();
                return;
            }
            decimal currentMovieFee = (int)movieLateFeeCalcType * 0.01m;

            //based on different fee conditions, pops up different child windows
            lblLateFeeNoticeReadOnly.Text = String.Format("At {0:c} / day", currentMovieFee);

            switch (movieLateFeeCalcType)
            {
                case CalculatorTypesWithFeeInCents.NewReleases:
                    //New Releases window
                    Text = "New Releases Late Fee Calculator";
                    lblTitle.Text = "New Releases";
                    break;
                case CalculatorTypesWithFeeInCents.LibraryMovies:
                    //Library Movies window
                    Text = "Library Movies Late Fee Calculator";
                    lblTitle.Text = "Library Movies";
                    break;
                case CalculatorTypesWithFeeInCents.KidsMovies:
                    //Kids Movies window
                    Text = "Kids Movies Late Fee Calculator";
                    lblTitle.Text = "Kids Movies";
                    break;
                case CalculatorTypesWithFeeInCents.Unknown:
                    //other conditions
                    Text = "Unknown Calculator";
                    lblTitle.Text = "Unknown";
                    break;
            }
        }

        //created method: SetupForType()
        //access to the method: public
        //type of the method: void 
        //pass a variable(decimal fee) through the function(SetupForType)
        public void SetupForType(CalculatorTypesWithFeeInCents type)
        {
            movieLateFeeCalcType = type;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            //when click Exit button, hide this form to reveal MainMenu
            Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //INPUT VALIDATION:input format
            if (!CheckUserEnteredData(out int successParseNumOfMovies, 
                            out DateTime dayDue, out CustomerTypeWithBreakInPercent customerType))
            {
                return;
            };

            //Calculate the late fee
            double lateFee = CalculateLateFee(successParseNumOfMovies, dayDue, customerType,
                            out double numberOfDays);

            //Display the late fee as curreny in the textbox txtLateFee
            SetLateFee(numberOfDays, lateFee);

            //move the focus to the Return button
            btnReturn.Focus();
        }

        /// <summary>
        /// Calculate and return late fee
        /// Display the numbers of clicks on the 'calculate' button
        /// </summary>
        /// <param name="successParseNumOfMovies"></param>
        /// <param name="dayDue"></param>
        /// <param name="numberOfDays"></param>
        /// <returns></returns>
        private double CalculateLateFee(int successParseNumOfMovies, DateTime dayDue,
                                        CustomerTypeWithBreakInPercent customerType,
                                      out double numberOfDays)
        {
            //Generate the current date
            DateTime dayCurrent = DateTime.Now;
            //Calculate the number of days late
            TimeSpan dayTotal = dayCurrent.Date - dayDue.Date;
            numberOfDays = dayTotal.TotalDays;
            //INPUT VALIDATION:duedate time
            ValidateFutureDates(numberOfDays);

            double currentMovieFee = (int)movieLateFeeCalcType * 0.01;
            double currentFeeAfterBreak = 1 - (int)customerType * 0.01;

            //switch statement for the type of calcularors
            switch (movieLateFeeCalcType)
            {
                case CalculatorTypesWithFeeInCents.NewReleases:
                    //add and show the number of calculated movies
                    totalNumberOfMovies++;
                    txtTotalNum.Text = totalNumberOfMovies.ToString();
                    //calculate late fee total with the returned movie totals
                    double lateFeeNR = currentMovieFee * numberOfDays * successParseNumOfMovies;
                    // Apply break based on customer types
                    lateFeeNR = LateFeeWithBreak(customerType, currentFeeAfterBreak, lateFeeNR);
                    return lateFeeNR;

                case CalculatorTypesWithFeeInCents.LibraryMovies:
                    //add and show the number of calculated movies
                    totalNumberOfMovies++;
                    txtTotalNum.Text = totalNumberOfMovies.ToString();
                    //calculate late fee total with the returned movie totals
                    double lateFeeLM = currentMovieFee * numberOfDays * successParseNumOfMovies;
                    // Apply break based on customer types
                    lateFeeLM = LateFeeWithBreak(customerType, currentFeeAfterBreak, lateFeeLM);
                    return lateFeeLM;

                case CalculatorTypesWithFeeInCents.KidsMovies:
                    //add and show the number of calculated movies
                    totalNumberOfMovies++;
                    txtTotalNum.Text = totalNumberOfMovies.ToString();
                    //calculate late fee total with the returned movie totals
                    double lateFeeKM = currentMovieFee * numberOfDays * successParseNumOfMovies;
                    // Apply break based on customer types
                    lateFeeKM = LateFeeWithBreak(customerType, currentFeeAfterBreak, lateFeeKM);
                    return lateFeeKM;

                case CalculatorTypesWithFeeInCents.Unknown:
                    txtLateFee.Text = "Unknown late fees";
                    return 0;
            }
            return 1;
        }

        private static double LateFeeWithBreak(CustomerTypeWithBreakInPercent customerType, double currentFeeAfterBreak, double lateFee)
        {
            if (customerType == CustomerTypeWithBreakInPercent.J)
            {
                lateFee = lateFee * currentFeeAfterBreak;
            }
            if (customerType == CustomerTypeWithBreakInPercent.L)
            {
                lateFee = lateFee * currentFeeAfterBreak;
            }

            return lateFee;
        }

        /// <summary>
        /// Prevent user input of future dates
        /// </summary>
        /// <param name="numberOfDays"></param>
        private void ValidateFutureDates(double numberOfDays)
        {
            
            if (numberOfDays < 0)
            {
                txtDueDate.Text = "Due Date not come yet";
                txtLateDays.Text = "Not Available";
                txtLateFee.Text = "Not Available";
                return;
            }
        }

        /// <summary>
        /// Display the number of late days and late fee
        /// </summary>
        /// <param name="numberOfDays"></param>
        /// <param name="lateFee"></param>
        private void SetLateFee(double numberOfDays, double lateFee)
        {
            txtLateDays.Text = numberOfDays.ToString();
            txtLateFee.Text = lateFee.ToString("c");
        }

        private bool CheckUserEnteredData(out int successParseNumOfMovies, 
                                out DateTime dayDue, out CustomerTypeWithBreakInPercent customerType)
        {
            bool dataValid = true;
            //Get the total number of movies
            
            if (!Validator.TryParseInt(txtMovieNumber.Text, out successParseNumOfMovies))
            {
                txtMovieNumber.Text = "1";
                dataValid = false;
            }
            if (!Validator.TryParseCustomerType(txtCustomerType.Text, out customerType))
            {
                txtCustomerType.Text = "N";
                dataValid = false;
            }
            if (!Validator.TryParseDateTime(txtDueDate.Text, out dayDue))
            {
                txtDueDate.Text = "Invalid Input, try again";
                txtLateDays.Text = "Not Available";
                txtLateFee.Text = "Not Available";
                dataValid = false;
            }
            return dataValid;
        }



        //input validation for number of movies
        private void txtMovieNumber_TextChanged(object sender, EventArgs e)
        {
            //input validation for empty strings
            if (string.IsNullOrEmpty(txtMovieNumber.Text))
            {
                lblWarning.Show();
            }
            else if (Validator.IsValidInteger(txtMovieNumber.Text))
            {
                //disable any warnings
                lblWarning.Hide();
            }
            else
            {
                //enable the warning
                lblWarning.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            totalNumberOfMovies = 0;

            txtMovieNumber.Text = "";
            txtDueDate.Text = "";
            txtLateDays.Text = "";
            txtLateFee.Text = "";
            txtTotalNum.Text = "";
        }




    }
}
