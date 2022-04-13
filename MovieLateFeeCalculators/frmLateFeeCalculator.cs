using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace LatefeeCalc_c0842810
{
    public partial class frmLateFeeCalculator : Form
    {
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

        //declare a class variable for total number of movies
        private int totalNumberOfMovies;
        private int totalNumberOfSelectedMovies;

        //static variables
        public static double totalLateFee;
        public static double totalLateFeeNR;
        public static double totalLateFeeLM;
        public static double totalLateFeeKM;
        //only check 1 validation per time
        public static int errorNum = 0;

        /// <summary>
        /// Initialize the form
        /// Populate Today`s date and show it in the textbox txtCurrent
        /// </summary>
        public frmLateFeeCalculator()
        {
            InitializeComponent();
            txtCurrent.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
        }

        /// <summary>
        /// Initializes the late fee calculate form for a specific type of calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNewReleases_Shown(object sender, EventArgs e)
        {
            SetupFormForType();

        }

        /// <summary>
        /// Initializes a form for a specific type of calculator
        /// Based on different fee conditions, pops up different child windows
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

        /// <summary>
        /// Pass a variable(decimal fee) through the function(SetupForType) in the frmMainMenu
        /// </summary>
        /// <param name="type"></param>
        public void SetupForType(CalculatorTypesWithFeeInCents type)
        {
            movieLateFeeCalcType = type;
        }

        /// <summary>
        /// Hide the form window when Return button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            //frmNewMovie.numberOfLateMovies = 0;
            frmRentalMaintenance.numberOfLateMovies = 0;
            totalNumberOfSelectedMovies = 0;
            Clear();
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Calculate Late Fee for the specific type of movie when Calculate button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateLateFee();
        }

        /// <summary>
        /// CalculateLateFee() function
        /// Try Catch any expections after data validation
        /// Call Calculation function to calculate the late fee
        /// Call SetLateFee function to display the late fee and days late
        /// Move the focus to the Return button
        /// </summary>
        private void CalculateLateFee()
        {
            try
            {
                if (CheckUserEnteredValidData(
                      out int successParseNumOfMovies,
                      out DateTime dayDue,
                      out CustomerTypeWithBreakInPercent customerType)
                  ) {
                    double lateFee =
                        Calculation(successParseNumOfMovies, dayDue, customerType,
                                    out double numberOfDays);
                    //set total late fee for all mocvies and all calculations
                    totalLateFee += lateFee;
                    //set total late fee for all movie types
                    switch (movieLateFeeCalcType) {
                        case CalculatorTypesWithFeeInCents.NewReleases:
                            totalLateFeeNR = lateFee;
                            break;
                        case CalculatorTypesWithFeeInCents.LibraryMovies:
                            totalLateFeeLM = lateFee;
                            break;
                        case CalculatorTypesWithFeeInCents.KidsMovies:
                            totalLateFeeKM = lateFee;
                            break;


                    }

                    SetLateFee(numberOfDays, lateFee);

                    btnReturn.Focus();
                } 
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + "\n\nError of type: " + ex.GetType() + "\n\nStack trace: \n\n" + ex.StackTrace, "Error Encountered");
            }

            
        }

        /// <summary>
        /// Calculate and return late fee
        /// Display the total number of movies 
        /// </summary>
        /// <param name="successParseNumOfMovies"></param>
        /// <param name="dayDue"></param>
        /// <param name="numberOfDays"></param>
        /// <returns>lateFee</returns>
        private double Calculation(int successParseNumOfMovies, DateTime dayDue,
                                        CustomerTypeWithBreakInPercent customerType,
                                      out double numberOfDays)
        {
            DateTime dayCurrent = DateTime.Now;

            TimeSpan dayTotal = dayCurrent.Date - dayDue.Date;
            numberOfDays = dayTotal.TotalDays;

            double currentMovieFee = (int)movieLateFeeCalcType * 0.01;
            double currentFeeAfterBreak = 1 - (int)customerType * 0.01;

            
            totalNumberOfMovies += successParseNumOfMovies;
            txtTotalNum.Text = totalNumberOfMovies.ToString();

            double lateFee = currentMovieFee * numberOfDays * successParseNumOfMovies;

            lateFee = LateFeeWithBreak(customerType, currentFeeAfterBreak, lateFee);

            return lateFee;
        }

        /// <summary>
        /// Calculate late fee based on Customer Type
        /// </summary>
        /// <param name="customerType"></param>
        /// <param name="currentFeeAfterBreak"></param>
        /// <param name="lateFee"></param>
        /// <returns></returns>
        private static double LateFeeWithBreak(
            CustomerTypeWithBreakInPercent customerType, 
            double currentFeeAfterBreak,
            double lateFee)
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
        /// Display the number of late days and late fee
        /// </summary>
        /// <param name="numberOfDays"></param>
        /// <param name="lateFee"></param>
        private void SetLateFee(double numberOfDays, double lateFee)
        {
            txtLateDays.Text = numberOfDays.ToString();
            txtLateFee.Text = lateFee.ToString("c");
        }

        /// <summary>
        /// IsInt32: check number of movies is a positive integer
        /// IsCustType: check customer type is N / J / L 
        /// IsDateTime: check due date is a validate date that has passed the current date
        /// </summary>
        /// <param name="successParseNumOfMovies"></param>
        /// <param name="dayDue"></param>
        /// <param name="customerType"></param>
        /// <returns></returns>
        private bool CheckUserEnteredValidData(
            out int successParseNumOfMovies, 
            out DateTime dayDue, 
            out CustomerTypeWithBreakInPercent customerType)
        {
            bool dataValid = true;
            //Get and validate the due date
            if (!Validator.IsDateTime(txtDueDate.Text, out dayDue))
            {
                txtDueDate.Text = "Invalid Input, try again";
                txtLateDays.Text = "Not Available";
                txtLateFee.Text = "Not Available";
                dataValid = false;
                errorNum++;
            }
            //Get and validate the total number of movies
            if (!Validator.IsInt32(txtMovieNumber.Text, out successParseNumOfMovies))
            {

                txtMovieNumber.Text = "0";
                dataValid = false;
                errorNum++;
            }
            
            //Get and validate the customer type
            if (!Validator.IsCustType(txtCustomerType.Text, out customerType) )
            {
                txtCustomerType.Text = "N";
                errorNum++;
            }
            errorNum = 0;
            
            return dataValid;
        }



        /// <summary>
        /// Clear all the user entries when Clear button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            totalNumberOfMovies = 0;

            txtMovieNumber.Text = "";
            txtDueDate.Text = "";
            txtLateDays.Text = "";
            txtLateFee.Text = "";
            txtTotalNum.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRentalMaintenance frmSelectMovie = new frmRentalMaintenance();
            DialogResult addBtn = frmSelectMovie.ShowDialog();
            if (addBtn == DialogResult.OK)
            {
                totalNumberOfSelectedMovies += frmRentalMaintenance.numberOfLateMovies;
                txtMovieNumber.Text = totalNumberOfSelectedMovies.ToString();
            }
            DialogResult = DialogResult.None;
        }
    }
}
