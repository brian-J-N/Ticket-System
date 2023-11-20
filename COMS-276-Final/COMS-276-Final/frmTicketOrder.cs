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
    public partial class frmTicketOrder : Form
    {
        public frmTicketOrder(int TicketID)
        {
            InitializeComponent();
            // call method to show the ordered ticket. 
            TicketOrderReport(TicketID);

        }

        private void frmViewData_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }


        /// <summary>
        /// This method excepts and int argument to use as an index for displaying the selcted ticket from the database to an HTML report.
        /// </summary>
        public void TicketOrderReport(int Order)
        {
            string strReportHeader;
            strReportHeader = "<HTML><HEAD><TITLE>Your Order</TITLE></HEAD>";
            string strReportBody = "<BODY>";
            strReportBody += "<H1>Your Order</H1>";
            strReportBody += "<chr/>"; // horizontal line

            // get equipment info
            // connect to data
            clsData Item = new clsData();
            // pass sql to item
            Item.SQL = "SELECT ID, Available, Area, Seat, Participant, Email, Phone, Event, Price, EventDate, EventLocation FROM tblVenue WHERE ID = " + Order;

            // add item name to report
            strReportBody += "<br/>" +"<h2>" + "Event Name: " + "</h2>";
            strReportBody += "<h3>" + Item.dt.Rows[0]["Event"].ToString() + "</h3>";
            strReportBody += "<br/>" + "<h2>" + "Date: " + "</h2>"; // add line break
            strReportBody += "<h3>"  + Item.dt.Rows[0]["EventDate"].ToString() + "</h3>";
            strReportBody += "<br/>"; // add line break
            strReportBody += "<br/>"+"<h2>" + "Location: " + "</h2>";
            strReportBody += "<h3>" + Item.dt.Rows[0]["EventLocation"].ToString() + "</h3>";

            strReportBody += "<br/>" + "<h2>" + "Seating Location: " + "</h2>";
            strReportBody += "<h3>" + Item.dt.Rows[0]["Area"].ToString()  + "  Seat # " + Item.dt.Rows[0]["Seat"].ToString() + "</h3>";

            strReportBody += "<br/>" + "<h2>" + "Purchase Price: " + "</h2>"; // add line break
            strReportBody += "<h3>" + "$" + Item.dt.Rows[0]["Price"].ToString() + "</h3>";
            strReportBody += "<br/>"; // add line break
            strReportBody += "<br/>" + "<h2>" + "Customer Name: " + "</h2>";
            strReportBody += "<h3>" + Item.dt.Rows[0]["Participant"].ToString() + "</h3>";
            strReportBody += "<br/>" + "<h2>" + "Phone: " + "</h2>"; // add line break
            strReportBody += "<h3>" + Item.dt.Rows[0]["Phone"].ToString() + "</h3>";
            strReportBody += "<br/>"; // add line break
            strReportBody += "<br/>" + "<h2>" + "Email: " + "</h2>";
            strReportBody += "<h3>" + Item.dt.Rows[0]["Email"].ToString() + "</h3>";
           

            // close report
            strReportBody += "</body></html>";

            // display in browser
            webTicketOrder.DocumentText = strReportHeader + strReportBody;

        }

    }
}
