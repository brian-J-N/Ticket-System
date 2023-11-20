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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {// call method to show HTML report on ticket sales
            EventReport();
        }



        // method to create an HTML report on the ticket sales from the database.
        /// <summary>
        /// This method creates an HTML Report on the ticket sales from the database.
        /// </summary>

        public void EventReport()
        {
            try
            {

                // variable to hold total sales
                decimal TotalSales = 0;
                // variable to hold the amount of sales
                int SalesAmount = 0;
                // variable to hold the string price from database
                string price;
                // variable to hold the amount of tickets not sold
                int TicketsRemaining = 500;

                string strReportHeader;
                strReportHeader = "<HTML><HEAD><TITLE>Event Report Report</TITLE></HEAD>";
                string strReportBody = "<BODY>";
                strReportBody += "<H1>Event Report</H1>";
                strReportBody += "<chr/>"; // horizontal line

                // create table to display content
                strReportBody += "<table>"; // create table
                strReportBody += "<tr>"; // create table row
                strReportBody += "<td><strong>Section</td><td><strong>Seat&nbsp;&nbsp;&nbsp;&nbsp;</td><td><strong>Participant</td><td><strong>Phone</td><td>E-mail</td><td><strong>Price</strong></td>";// create cells
                strReportBody += "</td>";

                // create instance of class
                clsData myData = new clsData();
                // send SQL statement to class
                myData.SQL = "SELECT ID, Available, Area, Seat, Participant, Email, Phone, Event, Price, EventDate, EventLocation FROM tblVenue WHERE Available = 'No'"; ;


                // loop through datatable to get values

                for (int i = 0; i < myData.dt.Rows.Count; i++)
                {
                    strReportBody += "<tr>"; // create new table row
                    strReportBody += "<td>" + myData.dt.Rows[i]["Area"].ToString() + "&nbsp;&nbsp;&nbsp; " + "</td>";
                    strReportBody += "<td>" + myData.dt.Rows[i]["Seat"].ToString() + "&nbsp;&nbsp;&nbsp; " + "</td>";
                    strReportBody += "<td>" + myData.dt.Rows[i]["Participant"].ToString() + "&nbsp;&nbsp;&nbsp; " + "</td>";
                    strReportBody += "<td>" + myData.dt.Rows[i]["Phone"].ToString() + "&nbsp;&nbsp;&nbsp; " + "</td>";
                    strReportBody += "<td>" + myData.dt.Rows[i]["Email"].ToString() + "&nbsp;&nbsp;&nbsp; " + "</td>";
                    strReportBody += "<td>" + myData.dt.Rows[i]["Price"].ToString() + "&nbsp;&nbsp;&nbsp; " + "</td>";
                    strReportBody += "</tr>"; // close row

                    // get the price from database
                    price = myData.dt.Rows[i]["Price"].ToString();

                    // accumulate price
                    TotalSales += Convert.ToDecimal(price);
                    // accumulate total amount of tickets sold
                    SalesAmount += 1;
                }
                // calculate the amount of ticket remaining
                TicketsRemaining = TicketsRemaining - SalesAmount;

                strReportBody += "<tr>"; // create new table row
                                         // display event name
                strReportBody += "<td><strong>Event Name: </strong>" + myData.dt.Rows[0]["Event"].ToString() + "</td>";
                strReportBody += "</tr>"; // close row

                strReportBody += "<tr>"; // create new table row
                                         // display event date
                strReportBody += "<td><strong>Date: </strong>" + myData.dt.Rows[0]["EventDate"].ToString() + "</td>";
                strReportBody += "</tr>"; // close row

                strReportBody += "<tr>"; // create new table row
                                         // display event location
                strReportBody += "<td><strong>Location: </strong>" + myData.dt.Rows[0]["EventLocation"].ToString() + "</td>";
                strReportBody += "</tr>"; // close row

                strReportBody += "<tr>"; // create new table row
                                         // display amount of tickets sold
                strReportBody += "<td><strong>Tickets Sold: </strong>" + SalesAmount.ToString() + "</td>";
                strReportBody += "</tr>"; // close row

                strReportBody += "<tr>"; // create new table row
                                         // display amount of tickets remaining
                strReportBody += "<td><strong>Tickets Remaining: </strong>" + TicketsRemaining.ToString() + "</td>";
                strReportBody += "</tr>"; // close row

                strReportBody += "<tr>"; // create new table row
                                         // display total sales
                strReportBody += "<td><strong>Total Sales: $</strong>" + TotalSales.ToString() + "</td>";
                strReportBody += "</table>"; // close table
                strReportBody += "</body></html>"; // close report

                // display report in browser control
                webVenueReport.DocumentText = strReportHeader + strReportBody;
            }
            catch (Exception e)
            {
                MessageBox.Show("No Sales To Report.");
            }
        }


        private void webVenueReport_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
        
}
