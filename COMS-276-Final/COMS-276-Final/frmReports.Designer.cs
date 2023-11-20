
namespace COMS_276_Final
{
    partial class frmReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webVenueReport = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1060, 639);
            this.webBrowser1.TabIndex = 0;
            // 
            // webVenueReport
            // 
            this.webVenueReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webVenueReport.Location = new System.Drawing.Point(0, 0);
            this.webVenueReport.MinimumSize = new System.Drawing.Size(20, 20);
            this.webVenueReport.Name = "webVenueReport";
            this.webVenueReport.Size = new System.Drawing.Size(1060, 639);
            this.webVenueReport.TabIndex = 1;
            this.webVenueReport.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webVenueReport_DocumentCompleted);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 639);
            this.Controls.Add(this.webVenueReport);
            this.Controls.Add(this.webBrowser1);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webVenueReport;
    }
}