# CsharpLateFeeCalculator

1. **frmMainMenu.cs :** main form, <br/>
-click button to open frmLateFeeCalculator.cs;<br/>
-go to one of the three types of late fee calculator;<br/><br/>

2. **frmLateFeeCalculator.cs :** instantiate into specific movie type calculator, <br/>
-click "Calculate" button to calculate late fees; <br/>
-click "Add" button to open frmNewMovie.cs;<br/><br/>

3. **frmRentalMaintenance.cs:** load rental items from rentalDB; <br/>
-click "Select" button to return number of selected movies and DialogResult back to frmLateFeeCalculator.cs;<br/>
-click "Add" button to open frmNewMovie.cs and save rental items to rentalDB; <br/>
-click "Delete" button to delete movie from frmRentalMaintenance.cs and RentalDB.cs;<br/><br/>

4. **frmNewMovie.cs:** <br/>
-click "Add" button to add new movies of the instantiated type to return; <br/>
-click "OK" button to send DialogResult back to frmRentalMaintenance.cs;<br/><br/>

5. **Validator.cs:** validate user input (date, decimal, int)<br/><br/>
6. **RentalItems.cs:** No-argument constructor and Three argument constructor<br/><br/>
7. **RentalDB.cs:** fetch and save data to an XML file on the local machine<br/><br/>
