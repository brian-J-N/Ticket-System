
namespace COMS_276_Final
{
    partial class frmEventCreator
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.dtEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtPriceRowD = new System.Windows.Forms.TextBox();
            this.txtPriceRowC = new System.Windows.Forms.TextBox();
            this.txtPriceRowB = new System.Windows.Forms.TextBox();
            this.txtPriceRowA = new System.Windows.Forms.TextBox();
            this.txtPriceGeneral = new System.Windows.Forms.TextBox();
            this.txtNameOfEvent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbCreationMessage = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbCreationMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(371, 597);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 51);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Tag = "";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackColor = System.Drawing.Color.Silver;
            this.btnCreateEvent.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvent.ForeColor = System.Drawing.Color.Black;
            this.btnCreateEvent.Location = new System.Drawing.Point(122, 597);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(154, 52);
            this.btnCreateEvent.TabIndex = 32;
            this.btnCreateEvent.Tag = "";
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = false;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // dtEventDate
            // 
            this.dtEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEventDate.Location = new System.Drawing.Point(200, 226);
            this.dtEventDate.Name = "dtEventDate";
            this.dtEventDate.Size = new System.Drawing.Size(416, 30);
            this.dtEventDate.TabIndex = 31;
            this.dtEventDate.Value = new System.DateTime(2021, 4, 21, 0, 0, 0, 0);
            this.dtEventDate.ValueChanged += new System.EventHandler(this.dtEventDate_ValueChanged);
            // 
            // txtPriceRowD
            // 
            this.txtPriceRowD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceRowD.Location = new System.Drawing.Point(211, 517);
            this.txtPriceRowD.Name = "txtPriceRowD";
            this.txtPriceRowD.Size = new System.Drawing.Size(254, 30);
            this.txtPriceRowD.TabIndex = 30;
            // 
            // txtPriceRowC
            // 
            this.txtPriceRowC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceRowC.Location = new System.Drawing.Point(211, 467);
            this.txtPriceRowC.Name = "txtPriceRowC";
            this.txtPriceRowC.Size = new System.Drawing.Size(254, 30);
            this.txtPriceRowC.TabIndex = 29;
            // 
            // txtPriceRowB
            // 
            this.txtPriceRowB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceRowB.Location = new System.Drawing.Point(211, 416);
            this.txtPriceRowB.Name = "txtPriceRowB";
            this.txtPriceRowB.Size = new System.Drawing.Size(254, 30);
            this.txtPriceRowB.TabIndex = 28;
            // 
            // txtPriceRowA
            // 
            this.txtPriceRowA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceRowA.Location = new System.Drawing.Point(211, 369);
            this.txtPriceRowA.Name = "txtPriceRowA";
            this.txtPriceRowA.Size = new System.Drawing.Size(254, 30);
            this.txtPriceRowA.TabIndex = 27;
            // 
            // txtPriceGeneral
            // 
            this.txtPriceGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceGeneral.Location = new System.Drawing.Point(211, 323);
            this.txtPriceGeneral.Name = "txtPriceGeneral";
            this.txtPriceGeneral.Size = new System.Drawing.Size(254, 30);
            this.txtPriceGeneral.TabIndex = 26;
            this.txtPriceGeneral.TextChanged += new System.EventHandler(this.txtPriceGeneral_TextChanged);
            // 
            // txtNameOfEvent
            // 
            this.txtNameOfEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOfEvent.Location = new System.Drawing.Point(200, 121);
            this.txtNameOfEvent.Name = "txtNameOfEvent";
            this.txtNameOfEvent.Size = new System.Drawing.Size(416, 30);
            this.txtNameOfEvent.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Row D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Row C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Row B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Row A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "General";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Section Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date of Event:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name of Event";
            // 
            // txtEventLocation
            // 
            this.txtEventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventLocation.Location = new System.Drawing.Point(200, 172);
            this.txtEventLocation.Name = "txtEventLocation";
            this.txtEventLocation.Size = new System.Drawing.Size(416, 30);
            this.txtEventLocation.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(331, 34);
            this.label10.TabIndex = 36;
            this.label10.Text = "Enter Event Information";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // gbCreationMessage
            // 
            this.gbCreationMessage.Controls.Add(this.label11);
            this.gbCreationMessage.Location = new System.Drawing.Point(60, 189);
            this.gbCreationMessage.Name = "gbCreationMessage";
            this.gbCreationMessage.Size = new System.Drawing.Size(522, 174);
            this.gbCreationMessage.TabIndex = 37;
            this.gbCreationMessage.TabStop = false;
            this.gbCreationMessage.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(65, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(339, 34);
            this.label11.TabIndex = 37;
            this.label11.Text = "Event Is Being Created..";
            // 
            // frmEventCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(712, 688);
            this.Controls.Add(this.gbCreationMessage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEventLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.dtEventDate);
            this.Controls.Add(this.txtPriceRowD);
            this.Controls.Add(this.txtPriceRowC);
            this.Controls.Add(this.txtPriceRowB);
            this.Controls.Add(this.txtPriceRowA);
            this.Controls.Add(this.txtPriceGeneral);
            this.Controls.Add(this.txtNameOfEvent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "frmEventCreator";
            this.Text = "frmEventCreator";
            this.Load += new System.EventHandler(this.frmEventCreator_Load);
            this.gbCreationMessage.ResumeLayout(false);
            this.gbCreationMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.DateTimePicker dtEventDate;
        private System.Windows.Forms.TextBox txtPriceRowD;
        private System.Windows.Forms.TextBox txtPriceRowC;
        private System.Windows.Forms.TextBox txtPriceRowB;
        private System.Windows.Forms.TextBox txtPriceRowA;
        private System.Windows.Forms.TextBox txtPriceGeneral;
        private System.Windows.Forms.TextBox txtNameOfEvent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbCreationMessage;
        private System.Windows.Forms.Label label11;
    }
}