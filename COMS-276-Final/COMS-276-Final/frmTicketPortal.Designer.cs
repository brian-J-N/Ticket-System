
namespace COMS_276_Final
{
    partial class frmTicketPortal
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
            this.gbOrderTicket = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOrderTicket = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRowD = new System.Windows.Forms.Button();
            this.btnRowC = new System.Windows.Forms.Button();
            this.btnRowB = new System.Windows.Forms.Button();
            this.btnRowA = new System.Windows.Forms.Button();
            this.gbSelectTicket = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectedSeat = new System.Windows.Forms.Label();
            this.btnSelectTicket = new System.Windows.Forms.Button();
            this.lblSelectedArea = new System.Windows.Forms.Label();
            this.lstAvailableTickets = new System.Windows.Forms.ListBox();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.lblDisplayEvent = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbOrderTicket.SuspendLayout();
            this.gbSelectTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrderTicket
            // 
            this.gbOrderTicket.BackColor = System.Drawing.Color.Teal;
            this.gbOrderTicket.Controls.Add(this.label13);
            this.gbOrderTicket.Controls.Add(this.label12);
            this.gbOrderTicket.Controls.Add(this.btnCancel);
            this.gbOrderTicket.Controls.Add(this.txtEmail);
            this.gbOrderTicket.Controls.Add(this.txtPhone);
            this.gbOrderTicket.Controls.Add(this.txtName);
            this.gbOrderTicket.Controls.Add(this.btnOrderTicket);
            this.gbOrderTicket.Controls.Add(this.label5);
            this.gbOrderTicket.Controls.Add(this.label4);
            this.gbOrderTicket.Controls.Add(this.label2);
            this.gbOrderTicket.Location = new System.Drawing.Point(294, 202);
            this.gbOrderTicket.Name = "gbOrderTicket";
            this.gbOrderTicket.Size = new System.Drawing.Size(572, 503);
            this.gbOrderTicket.TabIndex = 16;
            this.gbOrderTicket.TabStop = false;
            this.gbOrderTicket.Visible = false;
            this.gbOrderTicket.Enter += new System.EventHandler(this.gbOrderTicket_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(344, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Format 1234567890";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(52, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(463, 34);
            this.label12.TabIndex = 24;
            this.label12.Text = "Please Enter Your Information";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(327, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 71);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(196, 275);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 27);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(196, 201);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 27);
            this.txtPhone.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(113, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(402, 28);
            this.txtName.TabIndex = 0;
            // 
            // btnOrderTicket
            // 
            this.btnOrderTicket.BackColor = System.Drawing.Color.Silver;
            this.btnOrderTicket.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderTicket.Location = new System.Drawing.Point(42, 365);
            this.btnOrderTicket.Name = "btnOrderTicket";
            this.btnOrderTicket.Size = new System.Drawing.Size(178, 71);
            this.btnOrderTicket.TabIndex = 3;
            this.btnOrderTicket.Text = "Order Ticket";
            this.btnOrderTicket.UseVisualStyleBackColor = false;
            this.btnOrderTicket.Click += new System.EventHandler(this.btnOrderTicket_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(15, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(16, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(15, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // btnRowD
            // 
            this.btnRowD.BackColor = System.Drawing.Color.Silver;
            this.btnRowD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRowD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRowD.Location = new System.Drawing.Point(53, 648);
            this.btnRowD.Name = "btnRowD";
            this.btnRowD.Size = new System.Drawing.Size(202, 56);
            this.btnRowD.TabIndex = 4;
            this.btnRowD.Text = "Row: D";
            this.btnRowD.UseVisualStyleBackColor = false;
            this.btnRowD.Click += new System.EventHandler(this.btnRowD_Click);
            // 
            // btnRowC
            // 
            this.btnRowC.BackColor = System.Drawing.Color.Silver;
            this.btnRowC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRowC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRowC.Location = new System.Drawing.Point(53, 545);
            this.btnRowC.Name = "btnRowC";
            this.btnRowC.Size = new System.Drawing.Size(202, 61);
            this.btnRowC.TabIndex = 3;
            this.btnRowC.Text = "Row: C";
            this.btnRowC.UseVisualStyleBackColor = false;
            this.btnRowC.Click += new System.EventHandler(this.btnRowC_Click);
            // 
            // btnRowB
            // 
            this.btnRowB.BackColor = System.Drawing.Color.Silver;
            this.btnRowB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRowB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRowB.Location = new System.Drawing.Point(53, 444);
            this.btnRowB.Name = "btnRowB";
            this.btnRowB.Size = new System.Drawing.Size(202, 60);
            this.btnRowB.TabIndex = 2;
            this.btnRowB.Text = "Row: B";
            this.btnRowB.UseVisualStyleBackColor = false;
            this.btnRowB.Click += new System.EventHandler(this.btnRowB_Click);
            // 
            // btnRowA
            // 
            this.btnRowA.BackColor = System.Drawing.Color.Silver;
            this.btnRowA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRowA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRowA.Location = new System.Drawing.Point(53, 350);
            this.btnRowA.Name = "btnRowA";
            this.btnRowA.Size = new System.Drawing.Size(202, 59);
            this.btnRowA.TabIndex = 1;
            this.btnRowA.Text = "Row: A";
            this.btnRowA.UseVisualStyleBackColor = false;
            this.btnRowA.Click += new System.EventHandler(this.btnRowA_Click);
            // 
            // gbSelectTicket
            // 
            this.gbSelectTicket.BackColor = System.Drawing.Color.Teal;
            this.gbSelectTicket.Controls.Add(this.label11);
            this.gbSelectTicket.Controls.Add(this.label10);
            this.gbSelectTicket.Controls.Add(this.label1);
            this.gbSelectTicket.Controls.Add(this.lblPrice);
            this.gbSelectTicket.Controls.Add(this.label3);
            this.gbSelectTicket.Controls.Add(this.lblSelectedSeat);
            this.gbSelectTicket.Controls.Add(this.btnSelectTicket);
            this.gbSelectTicket.Controls.Add(this.lblSelectedArea);
            this.gbSelectTicket.Controls.Add(this.lstAvailableTickets);
            this.gbSelectTicket.Location = new System.Drawing.Point(294, 202);
            this.gbSelectTicket.Name = "gbSelectTicket";
            this.gbSelectTicket.Size = new System.Drawing.Size(572, 503);
            this.gbSelectTicket.TabIndex = 11;
            this.gbSelectTicket.TabStop = false;
            this.gbSelectTicket.Visible = false;
            this.gbSelectTicket.Enter += new System.EventHandler(this.gbSelectTicket_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(321, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 34);
            this.label11.TabIndex = 26;
            this.label11.Text = "Seat";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(321, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 34);
            this.label10.TabIndex = 25;
            this.label10.Text = "Seating Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Choose Available Seat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrice.Location = new System.Drawing.Point(406, 277);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(21, 23);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(321, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // lblSelectedSeat
            // 
            this.lblSelectedSeat.AutoSize = true;
            this.lblSelectedSeat.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSeat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSelectedSeat.Location = new System.Drawing.Point(406, 206);
            this.lblSelectedSeat.Name = "lblSelectedSeat";
            this.lblSelectedSeat.Size = new System.Drawing.Size(135, 23);
            this.lblSelectedSeat.TabIndex = 6;
            this.lblSelectedSeat.Text = "Selected Seat";
            this.lblSelectedSeat.Click += new System.EventHandler(this.lblSelectedSeat_Click);
            // 
            // btnSelectTicket
            // 
            this.btnSelectTicket.BackColor = System.Drawing.Color.Silver;
            this.btnSelectTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectTicket.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTicket.ForeColor = System.Drawing.Color.Black;
            this.btnSelectTicket.Location = new System.Drawing.Point(333, 392);
            this.btnSelectTicket.Name = "btnSelectTicket";
            this.btnSelectTicket.Size = new System.Drawing.Size(171, 64);
            this.btnSelectTicket.TabIndex = 1;
            this.btnSelectTicket.Text = "Select";
            this.btnSelectTicket.UseVisualStyleBackColor = false;
            this.btnSelectTicket.Click += new System.EventHandler(this.btnSelectTicket_Click);
            // 
            // lblSelectedArea
            // 
            this.lblSelectedArea.AutoSize = true;
            this.lblSelectedArea.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedArea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSelectedArea.Location = new System.Drawing.Point(352, 139);
            this.lblSelectedArea.Name = "lblSelectedArea";
            this.lblSelectedArea.Size = new System.Drawing.Size(152, 25);
            this.lblSelectedArea.TabIndex = 3;
            this.lblSelectedArea.Text = "Selected Area";
            this.lblSelectedArea.Click += new System.EventHandler(this.lblSelectedArea_Click);
            // 
            // lstAvailableTickets
            // 
            this.lstAvailableTickets.BackColor = System.Drawing.Color.Silver;
            this.lstAvailableTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstAvailableTickets.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAvailableTickets.FormattingEnabled = true;
            this.lstAvailableTickets.ItemHeight = 23;
            this.lstAvailableTickets.Location = new System.Drawing.Point(30, 77);
            this.lstAvailableTickets.Name = "lstAvailableTickets";
            this.lstAvailableTickets.Size = new System.Drawing.Size(263, 395);
            this.lstAvailableTickets.TabIndex = 5;
            this.lstAvailableTickets.SelectedIndexChanged += new System.EventHandler(this.lstAvailableTickets_SelectedIndexChanged);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.Silver;
            this.btnGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneral.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.Location = new System.Drawing.Point(53, 256);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(202, 57);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "General";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // lblDisplayEvent
            // 
            this.lblDisplayEvent.AutoSize = true;
            this.lblDisplayEvent.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayEvent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDisplayEvent.Location = new System.Drawing.Point(182, 40);
            this.lblDisplayEvent.Name = "lblDisplayEvent";
            this.lblDisplayEvent.Size = new System.Drawing.Size(469, 39);
            this.lblDisplayEvent.TabIndex = 17;
            this.lblDisplayEvent.Text = "Event Name Appears Here";
            this.lblDisplayEvent.Click += new System.EventHandler(this.lblDisplayEvent_Click);
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEventDate.Location = new System.Drawing.Point(221, 94);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(217, 28);
            this.lblEventDate.TabIndex = 18;
            this.lblEventDate.Text = "Date appears here";
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventLocation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEventLocation.Location = new System.Drawing.Point(307, 142);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(119, 21);
            this.lblEventLocation.TabIndex = 19;
            this.lblEventLocation.Text = "Location here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(97, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Event:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(146, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(192, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Location:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(48, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Select Seating Area";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(766, 726);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 48);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTicketPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(945, 786);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEventLocation);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblDisplayEvent);
            this.Controls.Add(this.gbOrderTicket);
            this.Controls.Add(this.btnRowD);
            this.Controls.Add(this.btnRowC);
            this.Controls.Add(this.btnRowB);
            this.Controls.Add(this.btnRowA);
            this.Controls.Add(this.gbSelectTicket);
            this.Controls.Add(this.btnGeneral);
            this.Name = "frmTicketPortal";
            this.Text = "frmTicketPortal";
            this.Load += new System.EventHandler(this.frmTicketPortal_Load);
            this.gbOrderTicket.ResumeLayout(false);
            this.gbOrderTicket.PerformLayout();
            this.gbSelectTicket.ResumeLayout(false);
            this.gbSelectTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrderTicket;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOrderTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRowD;
        private System.Windows.Forms.Button btnRowC;
        private System.Windows.Forms.Button btnRowB;
        private System.Windows.Forms.Button btnRowA;
        private System.Windows.Forms.GroupBox gbSelectTicket;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectedSeat;
        private System.Windows.Forms.Button btnSelectTicket;
        private System.Windows.Forms.Label lblSelectedArea;
        private System.Windows.Forms.ListBox lstAvailableTickets;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Label lblDisplayEvent;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventLocation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExit;
    }
}