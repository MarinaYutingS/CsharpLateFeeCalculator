# CsharpLateFeeCalculator
1. **frmMainMenu.cs :** main form, \n- click button to open frmLateFeeCalculator.cs, \n-go to one of the three types of late fee calculator;
2. **frmLateFeeCalculator.cs :** instantiate into specific movie type calculator, click "Calculate" button to calculate late fees; click "Add" button to open frmNewMovie.cs;
3. **frmRentalMaintenance.cs:** load rental items from rentalDB; click "Select" button to return number of selected movies and DialogResult back to frmLateFeeCalculator.cs;click "Add" button to open frmNewMovie.cs and save rental items to rentalDB; click "Delete" button to delete movie from frmRentalMaintenance.cs and RentalDB.cs;
4. **frmNewMovie.cs:** click "Add" button to add new movies of the instantiated type to return; click "OK" button to send DialogResult back to frmRentalMaintenance.cs;
5. **Validator.cs:** validate user input (date, decimal, int)
6. **RentalItems.cs:** No-argument constructor and Three argument constructor
7. **RentalDB.cs:** fetch and save data to an XML file on the local machine
