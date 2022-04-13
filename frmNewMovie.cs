using System;
using System.Collections;
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
    public partial class frmNewMovie : Form
    {
        //static variable 
        public static int numberOfLateMovies = 0;

        SortedList lateMovies = new SortedList();

        public frmNewMovie()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add movie names to the sorted list and increase the number of late movies
        /// when click Add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String lateMoviesToAdd = txtMovieNo.Text;
            
            lateMovies.Add(lateMoviesToAdd,1);

            numberOfLateMovies++;


        }

        /// <summary>
        /// Hide the form when click Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        /// <summary>
        /// Set DialogResult to OK when click OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        //declare a class variable 
        private RentalItem rentalItem = null;

        /// <summary>
        /// GetNewRental method 
        /// displays the form as a dialog box
        /// </summary>
        /// <returns> rentalItem RentalItem object</returns>
        public RentalItem GetNewRental()
        {
            this.ShowDialog();
            return rentalItem;
        }

        /// <summary>
        /// Create a new RentalItem object and closes the form if the data is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Validator.IsInt32(txtMovieNo.Text, out int movieNo);

            if (IsValidData())
            {
                rentalItem = new RentalItem(movieNo, txtDescription.Text, txtRating.Text);
                this.Close();
            }
        }

        /// <summary>
        /// Return true if data entered is valid
        /// </summary>
        /// <returns></returns>
        private Boolean IsValidData()
        {
            Boolean isValid = true;
            if (!Validator.IsInt32(txtMovieNo.Text, out int movieNo))
            {
                MessageBox.Show("Please enter valid Movie No!");
                isValid = false;
            }
            else if (Validator.IsPresent(txtDescription.Text))
            {
                MessageBox.Show("Please enter the movie description!");
                isValid=false;
            }
            else if (Validator.IsPresent(txtRating.Text)) {
                MessageBox.Show("Please enter the movie rating!");
                isValid = false;
            }

            return isValid;
        }
    }
}
