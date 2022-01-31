using System;
using System.Windows.Forms;

namespace Assignment01_c0842810
{
    public partial class frmLateFeeCalculator : Form
    {
        //declare a member variable newReleaseLateFee
        private decimal movieLateFeeCalc;

        public frmLateFeeCalculator()
        {
            InitializeComponent();

            //populate Today`s date and show it in the textbox txtCurrent
            txtCurrent.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
        }

        private void frmNewReleases_Shown(object sender, EventArgs e)
        {   
            //based on different fee conditions, pops up different child windows
            lblLateFeeNoticeReadOnly.Text = String.Format("At ${0} / day", movieLateFeeCalc);
            if (movieLateFeeCalc == 2.00m)
            {
                //New Releases window
                this.Text = "New Releases Late Fee Calculator";
                lblTitle.Text = "New Releases";
            }
            else if (movieLateFeeCalc == .57m)
            {
                //Library Movies window
                this.Text = "Library Movies Late Fee Calculator";
                lblTitle.Text = "Library Movies";
            }
            else if (movieLateFeeCalc == .15m)
            {
                //Kids Movies window
                this.Text = "Kids Movies Late Fee Calculator";
                lblTitle.Text = "Kids Movies";
            }
            else
            {
                //other conditions
                this.Text = "Unknown Calculator";
                lblTitle.Text = "Unknown";
            }
            
        }

            //created method: SetupForType()
            //access to the method: public
            //type of the method: void 
            //pass a variable(decimal fee) through the function(SetupForType)
            public void SetupForType(decimal fee)
        {
            movieLateFeeCalc = fee;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //when click Exit button, hide this form to reveal MainMenu
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Generate the current date
            DateTime dCurrent = DateTime.Now;

            DateTime dDue;
            if (DateTime.TryParse(txtDueDate.Text, out dDue))
            {
                //INPUT VALIDATION:date format
                //Calculate the number of days late
                TimeSpan dTotal = dCurrent.Date - dDue.Date;
                double numberOfDays = dTotal.TotalDays;
                //INPUT VALIDATION:duedate time
                if (numberOfDays < 0)
                {
                    txtDueDate.Text = "Due Date not come yet";
                    txtLateDays.Text = "Not Available";
                    txtLateFee.Text = "Not Available";
                }
                else
                {
                    //Display the number of days late in the textbox txtLateDays
                    txtLateDays.Text = numberOfDays.ToString();

                    //Calculate the late fee
                    //Display the late fee as curreny in the textbox txtLateFee
                    if (movieLateFeeCalc == 2.00m)
                    {
                        double lateFee = 2.00 * numberOfDays;
                        txtLateFee.Text = lateFee.ToString("c");
                    }
                    else if (movieLateFeeCalc == .57m)
                    {
                        double lateFee = 0.57 * numberOfDays;
                        txtLateFee.Text = lateFee.ToString("c");
                    }
                    else if (movieLateFeeCalc == .15m)
                    {
                        double lateFee = 0.15 * numberOfDays;
                        txtLateFee.Text = lateFee.ToString("c");
                    }
                    else
                    {
                        txtLateFee.Text = "Unknown late fees";
                    }
                }
            } 
            else
            {
                //invalid user input date format:
                txtDueDate.Text = "Invalid Input, try again";
                txtLateDays.Text = "Not Available";
                txtLateFee.Text = "Not Available";
            } 
        }
    }
}
