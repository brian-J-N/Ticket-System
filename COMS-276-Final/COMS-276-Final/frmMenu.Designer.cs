
namespace COMS_276_Final
{
    partial class frmMenu
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
            this.btnEventCreator = new System.Windows.Forms.Button();
            this.btnTicketPortal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEventCreator
            // 
            this.btnEventCreator.BackColor = System.Drawing.Color.Silver;
            this.btnEventCreator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventCreator.ForeColor = System.Drawing.Color.Black;
            this.btnEventCreator.Location = new System.Drawing.Point(144, 129);
            this.btnEventCreator.Name = "btnEventCreator";
            this.btnEventCreator.Size = new System.Drawing.Size(174, 82);
            this.btnEventCreator.TabIndex = 0;
            this.btnEventCreator.Text = "Create Event";
            this.btnEventCreator.UseVisualStyleBackColor = false;
            this.btnEventCreator.Click += new System.EventHandler(this.btnEventCreator_Click);
            // 
            // btnTicketPortal
            // 
            this.btnTicketPortal.BackColor = System.Drawing.Color.Silver;
            this.btnTicketPortal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicketPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketPortal.Location = new System.Drawing.Point(144, 242);
            this.btnTicketPortal.Name = "btnTicketPortal";
            this.btnTicketPortal.Size = new System.Drawing.Size(174, 82);
            this.btnTicketPortal.TabIndex = 1;
            this.btnTicketPortal.Text = "Ticket Portal";
            this.btnTicketPortal.UseVisualStyleBackColor = false;
            this.btnTicketPortal.Click += new System.EventHandler(this.btnTicketPortal_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Silver;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(144, 357);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(174, 82);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Event Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Event Ticket Manager";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(522, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTicketPortal);
            this.Controls.Add(this.btnEventCreator);
            this.Name = "frmMenu";
            this.Text = "Ticket System Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventCreator;
        private System.Windows.Forms.Button btnTicketPortal;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
    }
}

