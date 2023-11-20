
namespace COMS_276_Final
{
    partial class frmTicketOrder
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
            this.webTicketOrder = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webTicketOrder
            // 
            this.webTicketOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webTicketOrder.Location = new System.Drawing.Point(0, 0);
            this.webTicketOrder.MinimumSize = new System.Drawing.Size(20, 20);
            this.webTicketOrder.Name = "webTicketOrder";
            this.webTicketOrder.Size = new System.Drawing.Size(800, 594);
            this.webTicketOrder.TabIndex = 0;
            this.webTicketOrder.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // frmTicketOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.webTicketOrder);
            this.Name = "frmTicketOrder";
            this.Text = "frmViewData";
            this.Load += new System.EventHandler(this.frmViewData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webTicketOrder;
    }
}