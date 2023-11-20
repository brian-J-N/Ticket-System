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
    public partial class frmTicketPortal : Form
    {

        //List to be parallel to listbox to hold ticket ID
        List<int> intTicketID = new List<int>();

        // create data table to update records
        DataTable dtUpdate;


        public frmTicketPortal()
        {
            InitializeComponent();
        }

        private void frmTicketPortal_Load(object sender, EventArgs e)
        {
            DisplayEventName();
        }

      
        // Method to fill list box with available tickets from General area

        /// <summary>
        /// This Method fills the list box with all the available general section tickets from the database.
        /// </summary>
        private void LoadAvaialbleTicketGeneral()
        {
            // clear out list box
            lstAvailableTickets.Items.Clear();
            lstAvailableTickets.Items.Clear();

            // clear out list
            intTicketID.Clear();

            // create instance of class
            clsData myData = new clsData();
            // send SQL statement to class
            myData.SQL = "SELECT ID, Available, Area, Seat FROM tblVenue WHERE Area = 'General' AND Available = 'Yes'";
            // loop through datatable to get values
            for (int i = 0; i < myData.dt.Rows.Count; i++)
            {
                lstAvailableTickets.Items.Add(myData.dt.Rows[i]["Area"].ToString() + ", Seat: " + (myData.dt.Rows[i]["Seat"].ToString()));

                // add equipment ID to list
                intTicketID.Add(int.Parse(myData.dt.Rows[i]["ID"].ToString()));

            }

        }// end method


        // Method to fill list box with available tickets from Row: A
        /// <summary>
        /// This Method fills the list box with all the available Row: A section tickets from the database.
        /// </summary>
        private void LoadAvaialbleTicketRowA()
        {
            // clear out list box
            lstAvailableTickets.Items.Clear();
            lstAvailableTickets.Items.Clear();

            // clear out list
            intTicketID.Clear();

            // create instance of class
            clsData myData = new clsData();
            // send SQL statement to class
            myData.SQL = "SELECT ID, Available, Area, Seat FROM tblVenue WHERE Area = 'Row: A' AND Available = 'Yes'";
            // loop through datatable to get values
            for (int i = 0; i < myData.dt.Rows.Count; i++)
            {
                // display area and seat number to list
                lstAvailableTickets.Items.Add(myData.dt.Rows[i]["Area"].ToString() + ", Seat: " + (myData.dt.Rows[i]["Seat"].ToString()));

                // add equipment ID to list
                intTicketID.Add(int.Parse(myData.dt.Rows[i]["ID"].ToString()));
            }

        }// end method


        // Method to fill list box with available tickets from Row: B
        /// <summary>
        /// This Method fills the list box with all the available Row: B section tickets from the database.
        /// </summary>
        private void LoadAvaialbleTicketRowB()
        {
            // clear out list box
            lstAvailableTickets.Items.Clear();
            lstAvailableTickets.Items.Clear();

            // clear out list
            intTicketID.Clear();

            // create instance of class
            clsData myData = new clsData();
            // send SQL statement to class
            myData.SQL = "SELECT ID, Available, Area, Seat FROM tblVenue WHERE Area = 'Row: B' AND Available = 'Yes'";
            // loop through datatable to get values
            for (int i = 0; i < myData.dt.Rows.Count; i++)
            {
                lstAvailableTickets.Items.Add(myData.dt.Rows[i]["Area"].ToString() + ", Seat: " + (myData.dt.Rows[i]["Seat"].ToString()));

                // add equipment ID to list
                intTicketID.Add(int.Parse(myData.dt.Rows[i]["ID"].ToString()));
            }

        }// end method



        // Method to fill list box with available tickets from Row: C
        // Method to fill list box with available tickets from Row: C
        /// <summary>
        /// This Method fills the list box with all the available Row: C section tickets from the database.
        private void LoadAvaialbleTicketRowC()
        {
            // clear out list box
            lstAvailableTickets.Items.Clear();
            lstAvailableTickets.Items.Clear();

            // clear out list
            intTicketID.Clear();

            // create instance of class
            clsData myData = new clsData();
            // send SQL statement to class
            myData.SQL = "SELECT ID, Available, Area, Seat FROM tblVenue WHERE Area = 'Row: C' AND Available = 'Yes'";
            // loop through datatable to get values
            for (int i = 0; i < myData.dt.Rows.Count; i++)
            {
                // display area and seat number to list
                lstAvailableTickets.Items.Add(myData.dt.Rows[i]["Area"].ToString() + ", Seat: " + (myData.dt.Rows[i]["Seat"].ToString()));

                // add equipment ID to list
                intTicketID.Add(int.Parse(myData.dt.Rows[i]["ID"].ToString()));
            }

        }// end method


        // Method to fill list box with available tickets from Row: D
        /// <summary>
        /// This Method fills the list box with all the available Row: D section tickets from the database.
        /// </summary>
        private void LoadAvaialbleTicketRowD()
        {
            // clear out list box
            lstAvailableTickets.Items.Clear();
            lstAvailableTickets.Items.Clear();

            // clear out list
            intTicketID.Clear();

            // create instance of class
            clsData myData = new clsData();
            // send SQL statement to class
            myData.SQL = "SELECT ID, Available, Area, Seat FROM tblVenue WHERE Area = 'Row: D' AND Available = 'Yes'";
            // loop through datatable to get values
            for (int i = 0; i < myData.dt.Rows.Count; i++)
            {
                // display area and seat number to list
                lstAvailableTickets.Items.Add(myData.dt.Rows[i]["Area"].ToString() + ", Seat: " + (myData.dt.Rows[i]["Seat"].ToString()));

                // add equipment ID to list
                intTicketID.Add(int.Parse(myData.dt.Rows[i]["ID"].ToString()));
            }

        }// end method


        // method to display selected ticket to screen

        // method to display selected ticket to screen.
        /// <summary>
        /// This Method displays information about the selected ticket to screen.
        /// </summary>
        private void LoadSelectedItem(int ID)
        {
            // connect to data
            clsData Item = new clsData();
            // pass sql to item
            Item.SQL = "SELECT ID, Available, Area, Seat, Participant, Email, Phone, Event, Price FROM tblVenue WHERE ID = " + ID;
            // get values from data table and dispay to screen
            lblSelectedArea.Tag = ID.ToString(); // capture uniqe id 
            lblSelectedArea.Text = Item.dt.Rows[0]["Area"].ToString();
            lblSelectedSeat.Text = Item.dt.Rows[0]["Seat"].ToString();
            lblPrice.Text = "$" + Item.dt.Rows[0]["Price"].ToString();
            txtName.Text =  Item.dt.Rows[0]["Participant"].ToString();
            txtPhone.Text = Item.dt.Rows[0]["Phone"].ToString();
            txtEmail.Text = Item.dt.Rows[0]["Email"].ToString();

            // get information for update
            dtUpdate = Item.dt;
        }//end method

        // method to display event name, date/time, and location to screen        
        /// <summary>
        /// method to display event name, date/time, and location to screen 
        /// </summary>

        private void DisplayEventName()
        { // create instance of class
            clsData myData = new clsData();
            // send SQL statement to class
            myData.SQL = "SELECT ID, Event, EventDate, EventLocation FROM tblVenue '";

            // display area and seat number to list
            lblDisplayEvent.Text = (myData.dt.Rows[0]["Event"].ToString());
            lblEventDate.Text = (myData.dt.Rows[0]["EventDate"].ToString());
            lblEventLocation.Text = (myData.dt.Rows[0]["EventLocation"].ToString());

        }// end method
      
        // method to check if phone number is only numbers
        /// <summary>
        /// This Method loops through a string of characters to check if it contains anything other then a number.
        /// If any charcter that is not a number is found in the string the method returns boolean value of false other wise it returns true.
        /// </summary>
        public static bool CheckNumber(string number)
        {
            // initialize boolean variables               
            Boolean onlynumbers = true;

            // loop through string to check for a number and a letter
            foreach (char c in number)
            {

                // check if string is only numbers
                if (c < '0' || c >'9')
                {
                    onlynumbers = false;

                }//end if
            }// end foreach
            return onlynumbers;
        }// end method
                
            


        private void btnRowA_Click(object sender, EventArgs e)
        {
            LoadAvaialbleTicketRowA();

            // show group box
            gbSelectTicket.Visible = true;

            // clear labels
            lblSelectedArea.Text = "";
            lblSelectedSeat.Text = "";
            lblPrice.Text = "";
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            // call method
            LoadAvaialbleTicketGeneral();

            // show group box
            gbSelectTicket.Visible = true;

            // clear labels
            lblSelectedArea.Text = "";
            lblSelectedSeat.Text = "";
            lblPrice.Text = "";
        }

        private void btnRowB_Click(object sender, EventArgs e)
        {
            LoadAvaialbleTicketRowB();
            // show group box
            gbSelectTicket.Visible = true;

            // clear labels
            lblSelectedArea.Text = "";
            lblSelectedSeat.Text = "";
            lblPrice.Text = "";
        }

        private void btnRowC_Click(object sender, EventArgs e)
        {
            LoadAvaialbleTicketRowC();
            // show group box
            gbSelectTicket.Visible = true;

            // clear labels
            lblSelectedArea.Text = "";
            lblSelectedSeat.Text = "";
            lblPrice.Text = "";
        }

        private void btnRowD_Click(object sender, EventArgs e)
        {
            LoadAvaialbleTicketRowD();
            // show group box
            gbSelectTicket.Visible = true;

            // clear labels
            lblSelectedArea.Text = "";
            lblSelectedSeat.Text = "";
            lblPrice.Text = "";
        }

        private void lstAvailableTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            // call method to display avaialbe tickets to lables
            LoadSelectedItem(intTicketID[lstAvailableTickets.SelectedIndex]);
        }

        private void btnSelectTicket_Click(object sender, EventArgs e)
        {
            // check if a ticket was selected
            if (lstAvailableTickets.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select A Ticket!");
            }
            else {
                // hide group box
                gbSelectTicket.Visible = false;


                // show group box
                gbOrderTicket.Visible = true; 
            }

        }
        /// <summary>
        /// This Button calls methods to check input from the user, call method to update database with the user input.
        /// Call method to display the HTML report of ticket selected.
        /// </summary>
        private void btnOrderTicket_Click(object sender, EventArgs e)
        {
            // error handling
            // validate information
            if (txtName.Text == "")
            {
                // error message
                MessageBox.Show("Please Enter Your Name!.");
            }// end if
            else 
            {

                // call method to check phone number
                bool check = CheckNumber(txtPhone.Text) ;

                if (check == false || txtPhone.Text == "")
                {
                    // error message
                    MessageBox.Show("Please Enter Your Phone Number!.");
                }// end if
                else
                {

                    if (txtEmail.Text == "")
                    {
                        // error message
                        MessageBox.Show("Please Enter Your Email!.");
                    }// end if
                
                    // update data table with customer information
                    clsData myUpdateData = new clsData();
                //clsData myData = new clsData();
                // updae local data table
                dtUpdate.Rows[0]["Participant"] = txtName.Text;
                dtUpdate.Rows[0]["Phone"] = txtPhone.Text;
                dtUpdate.Rows[0]["Email"] = txtEmail.Text;
                dtUpdate.Rows[0]["Available"] = "No";
                // send update to database
                myUpdateData.UpdateData(dtUpdate, "SELECT ID, Available, Participant, Phone, Email FROM tblVenue WHERE ID = " + intTicketID[lstAvailableTickets.SelectedIndex]);

                    // show group box
                    gbOrderTicket.Visible = false;

                    // make sure something was selected
                    if (lstAvailableTickets.SelectedIndex > -1)
                    {
                        // display to screen
                        //MessageBox.Show(intEquipmentID[lstEquipment.SelectedIndex].ToString());
                        // create instance of the second form
                        frmTicketOrder EquipmentReport = new frmTicketOrder(intTicketID[lstAvailableTickets.SelectedIndex]);
                        EquipmentReport.ShowDialog(); // show equipment detail
                                                      // refresh list box
                        //LoadEquipment();
                    }
                    else
                    {
                        // no equipment selected
                        MessageBox.Show("Select an item to view the report");
                    }

                }// end else
            }// end else
        }

        private void lblDisplayEvent_Click(object sender, EventArgs e)
        {

        }

        private void gbSelectTicket_Enter(object sender, EventArgs e)
        {

        }

        private void gbOrderTicket_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbOrderTicket.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectedArea_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectedSeat_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
