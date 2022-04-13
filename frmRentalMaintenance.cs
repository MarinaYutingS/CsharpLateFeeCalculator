using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatefeeCalc_c0842810
{
    public partial class frmRentalMaintenance : Form
    {
        //static variable 
        public static int numberOfLateMovies = 0;

        public frmRentalMaintenance()
        {
            InitializeComponent();
        }

        //class variable
        private List<RentalItem> rentalItems = null;

        /// <summary>
        /// Use the GetMovies method of RentalItemDB class to load the item list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRentalMaintenance_Load(object sender, EventArgs e)
        {
            rentalItems = RentalItemDB.GetMovies();
            FillMovieListBox();
        }

        /// <summary>
        /// FillMovieListBox () method
        /// Add items in the list to the items list box
        /// Use GetDisplayText method to format the data
        /// </summary>
        private void FillMovieListBox()
        {
            lstMovies.Items.Clear();
            foreach (RentalItem item in rentalItems) { 
                lstMovies.Items.Add(item.GetDisplayText());
            }
        }

        /// <summary>
        /// Create a new instance of the New Movie form
        /// Execute the GetNewRental method of newMovieForm
        /// Add new item to the list if the object is not null
        /// Save the rentalItems list to the RentalItemDB
        /// Refresh the listbox by FillMovieListBox method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewMovie newMovieForm = new frmNewMovie();
            RentalItem item = newMovieForm.GetNewRental();
            if (item != null) { 
                rentalItems.Add(item);
                RentalItemDB.SaveRentalItems(rentalItems);
                FillMovieListBox();
            }
        }

        /// <summary>
        /// Remove the selected movie from the list
        /// Save the list to the RentalItemDB
        /// Refresh the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstMovies.SelectedIndex;
            if (i != -1) {
                RentalItem item = rentalItems[i];
                string message = "Are you sre you want to delete " + item.Description + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    rentalItems.Remove(item);
                    RentalItemDB.SaveRentalItems(rentalItems);
                    FillMovieListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            numberOfLateMovies = 0;
            for (int x = 0; x < lstMovies.Items.Count; x++) { 
                //determine if the item is selected
                if (lstMovies.GetSelected(x) == true)
                {
                    numberOfLateMovies++;
                }
            }
            MessageBox.Show("number of selected late movies: " + numberOfLateMovies);
            DialogResult = DialogResult.OK;
        }
    }
}
