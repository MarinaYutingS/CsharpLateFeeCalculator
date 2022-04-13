using System;
using System.Windows.Forms;

namespace LatefeeCalc_c0842810
{
    public partial class frmMainMenu : Form
    {
        //declare private member variables within class level
        //to have memories alloacte to
        //the three child windows when file 'frmMainMenu' is created
        private frmLateFeeCalculator newReleasesCalc;
        private frmLateFeeCalculator libraryMoviesCalc;
        private frmLateFeeCalculator kidsMoviesCalc;

        /// <summary>
        /// Constructor frmMainMenu() shares the name of the file (frmMainMenu)
        /// When form 'frmMainMenu' is created, also create the three child forms:
        /// frmNewReleases, frmLibraryMovies, frmKidsMovies
        /// </summary>
        public frmMainMenu()
        {
            InitializeComponent();

            newReleasesCalc = new frmLateFeeCalculator();
            libraryMoviesCalc = new frmLateFeeCalculator();
            kidsMoviesCalc = new frmLateFeeCalculator();
        }

        /// <summary>
        /// Click NewRelease button to show the Newrelease window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenNewReleases_Click(object sender, EventArgs e)
        {
            newReleasesCalc.SetupForType(frmLateFeeCalculator.CalculatorTypesWithFeeInCents.NewReleases);//pass late fee to the SetupForType function
            
            DialogResult clickBtn = newReleasesCalc.ShowDialog();
            if (clickBtn == DialogResult.Cancel)
            {
                SetLateFeeTotals();
            }
        }

        

        /// <summary>
        /// Click LibraryMovie button to show LibraryMovies form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenLibraryMovie_Click(object sender, EventArgs e)
        {
            libraryMoviesCalc.SetupForType(frmLateFeeCalculator.CalculatorTypesWithFeeInCents.LibraryMovies);//pass late fee to the SetupForType function
                                                                                                             //libraryMoviesCalc.Show();//show the child window 
            DialogResult clickBtn = libraryMoviesCalc.ShowDialog();
            if (clickBtn == DialogResult.Cancel)
            {
                SetLateFeeTotals();
                //frmLateFeeCalculator.totalLateFeeLM = 0;
            }

        }

        /// <summary>
        /// Click KidsMovie button to open KidsMovies form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenKidsMovies_Click(object sender, EventArgs e)
        {
            kidsMoviesCalc.SetupForType(frmLateFeeCalculator.CalculatorTypesWithFeeInCents.KidsMovies);//pass late fee to the SetupForType function

            DialogResult clickBtn = kidsMoviesCalc.ShowDialog();
            if (clickBtn == DialogResult.Cancel)
            {
                SetLateFeeTotals();
                //frmLateFeeCalculator.totalLateFeeKM = 0;
            }
        }

        /// <summary>
        /// Set total late fee 
        /// </summary>
        private void SetLateFeeTotals()
        {
            double sumFeeCurrent = frmLateFeeCalculator.totalLateFeeNR
                + frmLateFeeCalculator.totalLateFeeLM + frmLateFeeCalculator.totalLateFeeKM;
           txtCurrentSum.Text = sumFeeCurrent.ToString();
           txtTotalLateMain.Text = frmLateFeeCalculator.totalLateFee.ToString();
           
            
        }

        /// <summary>
        /// Click Exit button to exit MainMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
