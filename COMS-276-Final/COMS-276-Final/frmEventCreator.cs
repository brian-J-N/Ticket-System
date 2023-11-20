using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMS_276_Final
{
    public partial class frmEventCreator : Form
    {

       

        // create data table to update records
        DataTable dtUpdate;



        public frmEventCreator()
        {
            InitializeComponent();

            //hide message
            gbCreationMessage.Visible = false;
          
            // forma date time picker
           dtEventDate.Format = DateTimePickerFormat.Custom;
            dtEventDate.CustomFormat = "MM/dd/yyyy hh:mm:tt";


        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            // error handling
            // validate information
            if (txtNameOfEvent.Text == "")
            {
                // error message
                MessageBox.Show("Please Enter Name of Event!.");
            }// end if
            else
            {
              
                if (txtEventLocation.Text == "")
                {
                    // error message
                    MessageBox.Show("Please Enter Location of Event!.");
                }// end if
                else
                {
                    bool check = CheckNumber(txtPriceGeneral.Text);
                    if (check == false || txtPriceGeneral.Text == "")

                    {
                        // error message
                        MessageBox.Show("Please Enter Price of Genral Area!.");

                    }// end if
                    else
                    {
                        check = CheckNumber(txtPriceRowA.Text);
                        if (check == false || txtPriceRowA.Text == "")

                        {
                            // error message
                            MessageBox.Show("Please Enter Price of Row: A!.");
                        }// end if
                        else
                        {
                            check = CheckNumber(txtPriceRowB.Text);
                            if (check == false || txtPriceRowB.Text == "")

                            {
                                // error message
                                MessageBox.Show("Please Enter Price of Row: B!.");
                            }// end if
                            else
                            {
                                check = CheckNumber(txtPriceRowC.Text);
                                if (check == false || txtPriceRowC.Text == "")

                                {
                                    // error message
                                    MessageBox.Show("Please Enter Price of Row: C!.");
                                }// end if
                                else
                                {
                                    check = CheckNumber(txtPriceRowD.Text);
                                    if (check == false || txtPriceRowD.Text == "")

                                    {
                                        // error message
                                        MessageBox.Show("Please Enter Price of Row: D!.");
                                    }// end if
                                    else
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Creating new event will delete the event currently in progress. Do you wish to continue?","Please Be Advised", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {

                                            // initalize variables
                                            string EventDate = "";
                                            string EventLocation = "";
                                            // assign value to EventDate
                                            EventDate = dtEventDate.Text;
                                            EventLocation = txtEventLocation.Text;
                                            // convert text box text to decimal
                                            decimal generalprice = Convert.ToDecimal(txtPriceGeneral.Text);
                                            decimal rowAprice = Convert.ToDecimal(txtPriceRowA.Text);
                                            decimal rowBprice = Convert.ToDecimal(txtPriceRowB.Text);
                                            decimal rowCprice = Convert.ToDecimal(txtPriceRowC.Text);
                                            decimal rowDprice = Convert.ToDecimal(txtPriceRowD.Text);

                                            gbCreationMessage.Visible = true;
                                            // call create event and pass values.
                                            CreateEvent(txtNameOfEvent.Text, generalprice, rowAprice, rowBprice, rowCprice, rowDprice, EventDate, EventLocation);

                                            MessageBox.Show("Event Created");

                                            this.Close();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }// end else
            }// end else
           
        }// end private void

        private void frmEventCreator_Load(object sender, EventArgs e)
        {

        }

        // ****************************************************************************************************************************************************
       
        // method to update database with new event information.
        /// <summary>
        /// This Method accepts arguments and uses the excepted data to update information in the database.
        /// </summary>
        private void CreateEvent(string name, decimal general, decimal rowA, decimal rowB, decimal rowC, decimal rowD, string date, string location)
        {

                // connect to data
                clsData NewEvent = new clsData();

          
                // send SQL statement to class
                NewEvent.SQL = "SELECT ID, Available, Area, Seat, Participant, Email, Phone, Event, EventDate, Price, EventLocation  FROM tblVenue ";
            
                // add data to dtupdate table
                dtUpdate = NewEvent.dt;

                // update data table with customer information
                clsData myUpdateData = new clsData();

            // loop through rows to update database
            int i = 0;
            while (i < 500)

                {   dtUpdate.Rows[i]["Participant"] = "";
                    dtUpdate.Rows[i]["Event"] = name;
                    dtUpdate.Rows[i]["Email"] = "";
                    dtUpdate.Rows[i]["Phone"] = "";
                    dtUpdate.Rows[i]["Available"] = "Yes";
                    dtUpdate.Rows[i]["EventDate"] = date;
                    dtUpdate.Rows[i]["EventLocation"] = location;
                i += 1;
                }

            // update database
                myUpdateData.UpdateData(dtUpdate, "SELECT ID, Available, Participant, Email, Phone, Event, EventDate, EventLocation FROM tblVenue");


            // loop through rows to update price for General Area Price
             i = 0;
            while (i < 100)
            {
                dtUpdate.Rows[i]["Price"] = general;          
                i += 1;
            }

            // update database
            myUpdateData.UpdateData(dtUpdate, "SELECT ID, Available, Participant, Email, Event, Price FROM tblVenue");

            // loop throgh rows to update Row: A Price
            while (i < 200)
            {
                dtUpdate.Rows[i]["Price"] = rowA;
                i += 1;
            }
            // update database
            myUpdateData.UpdateData(dtUpdate, "SELECT ID, Available, Participant, Email, Event, Price FROM tblVenue");

            // loop through rows to update price for Row: B Area          
            while (i < 300)
            {
                dtUpdate.Rows[i]["Price"] = rowB;
                i += 1;
            }

            // update database
            myUpdateData.UpdateData(dtUpdate, "SELECT ID, Available, Participant, Email, Event, Price FROM tblVenue");


            // loop through rows to update price for Row: C Area
            
            while (i < 400)
            {
                dtUpdate.Rows[i]["Price"] = rowC;
                i += 1;
            }

            // update database
            myUpdateData.UpdateData(dtUpdate, "SELECT ID, Available, Participant, Email, Event, Price FROM tblVenue");

          
            while (i < 500)
            {
                dtUpdate.Rows[i]["Price"] = rowD;
                i += 1;
            }

            // update database
            myUpdateData.UpdateData(dtUpdate, "SELECT ID, Available, Participant, Email, Event, Price FROM tblVenue");
   

        }// end method
         //*************************************************************************************************************************

        
        // method to check if string is only a number and if string has 0 or 1 decimal.

        /// <summary>
        /// This Method checks if a string is only a number and if string has 0 or 1 decimal.
        /// </summary>
        public static bool CheckNumber(string number)
        {
            // initialize boolean variables               
            Boolean onlynumbers = true;

            int DecimalCount = 0;
            string DecimalCheck = number;

            // loop through string to check for a number and a letter
            foreach (char c in number)
            {


                if (c == '.')

                {
                    DecimalCount += 1;
                    
                }
                 
                
                // check if string is only numbers and decimals
                if (DecimalCount > 1 && c < '0' || c > '9') 
                    
                {


                    onlynumbers = false;
                     
                }//end if
            }// end foreach
            return onlynumbers;
        }// end method

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }

        private void dtEventDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPriceGeneral_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }//end method

   


    
}
