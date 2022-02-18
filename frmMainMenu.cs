using System;
using System.Windows.Forms;

namespace Assignment02_c0842810
{
    public partial class frmMainMenu : Form
    {
        //declare private member variables within class level
        //to have memories alloacte to
        //the three child windows when file 'frmMainMenu' is created
        private frmLateFeeCalculator newReleasesCalc;
        private frmLateFeeCalculator libraryMoviesCalc;
        private frmLateFeeCalculator kidsMoviesCalc;


        //constructor frmMainMenu() shares the name of the file (frmMainMenu)
        public frmMainMenu()
        {
            InitializeComponent();

            //when form 'frmMainMenu' is created, also create
            //the three child forms (frmNewReleases, frmLibraryMovies, frmKidsMovies):
            newReleasesCalc = new frmLateFeeCalculator();
            libraryMoviesCalc = new frmLateFeeCalculator();
            kidsMoviesCalc = new frmLateFeeCalculator();
        }

        //click NewRelease button to open NewReleases form
        private void btnOpenNewReleases_Click(object sender, EventArgs e)
        {
            newReleasesCalc.SetupForType(frmLateFeeCalculator.CalculatorTypesWithFeeInCents.NewReleases);//pass late fee to the SetupForType function
            newReleasesCalc.Show();//show the child window 
        }

        //click LibraryMovie button to open LibraryMovies form
        private void btnOpenLibraryMovie_Click(object sender, EventArgs e)
        {
            libraryMoviesCalc.SetupForType(frmLateFeeCalculator.CalculatorTypesWithFeeInCents.LibraryMovies);//pass late fee to the SetupForType function
            libraryMoviesCalc.Show();//show the child window 
            
        }

        //click KidsMovie button to open KidsMovies form
        private void btnOpenKidsMovies_Click(object sender, EventArgs e)
        {
            kidsMoviesCalc.SetupForType(frmLateFeeCalculator.CalculatorTypesWithFeeInCents.KidsMovies);//pass late fee to the SetupForType function
            kidsMoviesCalc.Show();//show the child window 
            
        }

        //click Exit button to exit MainMenu
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
