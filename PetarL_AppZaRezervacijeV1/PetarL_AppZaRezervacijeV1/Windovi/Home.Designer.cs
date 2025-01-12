namespace PetarL_AppZaRezervacijeV1.Windovi
{
    partial class Home
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.addGuestsButton = new System.Windows.Forms.Button();
            this.addRoomsButton = new System.Windows.Forms.Button();
            this.guestsTabButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.roomsTabButton = new System.Windows.Forms.Button();
            this.reservationsTabButton = new System.Windows.Forms.Button();
            this.selectGuestButton = new System.Windows.Forms.Button();
            this.selectRoomButton = new System.Windows.Forms.Button();
            this.reserveRoomLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkInDateLabel = new System.Windows.Forms.Label();
            this.checkOutDateLabel = new System.Windows.Forms.Label();
            this.reserveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(464, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Hotel Reservation App";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // addGuestsButton
            // 
            this.addGuestsButton.BackColor = System.Drawing.Color.Gray;
            this.addGuestsButton.Location = new System.Drawing.Point(12, 23);
            this.addGuestsButton.Name = "addGuestsButton";
            this.addGuestsButton.Size = new System.Drawing.Size(75, 23);
            this.addGuestsButton.TabIndex = 1;
            this.addGuestsButton.Text = "Add Guests";
            this.addGuestsButton.UseVisualStyleBackColor = false;
            this.addGuestsButton.Click += new System.EventHandler(this.addGuestsButton_Click);
            // 
            // addRoomsButton
            // 
            this.addRoomsButton.BackColor = System.Drawing.Color.Gray;
            this.addRoomsButton.Location = new System.Drawing.Point(93, 23);
            this.addRoomsButton.Name = "addRoomsButton";
            this.addRoomsButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomsButton.TabIndex = 2;
            this.addRoomsButton.Text = "Add Rooms";
            this.addRoomsButton.UseVisualStyleBackColor = false;
            this.addRoomsButton.Click += new System.EventHandler(this.addRoomsButton_Click);
            // 
            // guestsTabButton
            // 
            this.guestsTabButton.BackColor = System.Drawing.Color.Gray;
            this.guestsTabButton.Location = new System.Drawing.Point(12, 52);
            this.guestsTabButton.Name = "guestsTabButton";
            this.guestsTabButton.Size = new System.Drawing.Size(75, 23);
            this.guestsTabButton.TabIndex = 3;
            this.guestsTabButton.Text = "Guests";
            this.guestsTabButton.UseVisualStyleBackColor = false;
            this.guestsTabButton.Click += new System.EventHandler(this.guestsTabButton_Click);
            // 
            // roomsTabButton
            // 
            this.roomsTabButton.BackColor = System.Drawing.Color.Gray;
            this.roomsTabButton.Location = new System.Drawing.Point(93, 52);
            this.roomsTabButton.Name = "roomsTabButton";
            this.roomsTabButton.Size = new System.Drawing.Size(75, 23);
            this.roomsTabButton.TabIndex = 4;
            this.roomsTabButton.Text = "Rooms";
            this.roomsTabButton.UseVisualStyleBackColor = false;
            this.roomsTabButton.Click += new System.EventHandler(this.roomsTabButton_Click);
            // 
            // reservationsTabButton
            // 
            this.reservationsTabButton.BackColor = System.Drawing.Color.Gray;
            this.reservationsTabButton.Location = new System.Drawing.Point(174, 52);
            this.reservationsTabButton.Name = "reservationsTabButton";
            this.reservationsTabButton.Size = new System.Drawing.Size(82, 23);
            this.reservationsTabButton.TabIndex = 5;
            this.reservationsTabButton.Text = "Reservations";
            this.reservationsTabButton.UseVisualStyleBackColor = false;
            this.reservationsTabButton.Click += new System.EventHandler(this.reservationsTabButton_Click);
            // 
            // selectGuestButton
            // 
            this.selectGuestButton.BackColor = System.Drawing.Color.Gray;
            this.selectGuestButton.Location = new System.Drawing.Point(15, 166);
            this.selectGuestButton.Name = "selectGuestButton";
            this.selectGuestButton.Size = new System.Drawing.Size(92, 23);
            this.selectGuestButton.TabIndex = 6;
            this.selectGuestButton.Text = "Select Guest";
            this.selectGuestButton.UseVisualStyleBackColor = false;
            this.selectGuestButton.Click += new System.EventHandler(this.selectGuestButton_Click);
            // 
            // selectRoomButton
            // 
            this.selectRoomButton.BackColor = System.Drawing.Color.Gray;
            this.selectRoomButton.Location = new System.Drawing.Point(113, 166);
            this.selectRoomButton.Name = "selectRoomButton";
            this.selectRoomButton.Size = new System.Drawing.Size(92, 23);
            this.selectRoomButton.TabIndex = 7;
            this.selectRoomButton.Text = "Select Room";
            this.selectRoomButton.UseVisualStyleBackColor = false;
            this.selectRoomButton.Click += new System.EventHandler(this.selectRoomButton_Click);
            // 
            // reserveRoomLabel
            // 
            this.reserveRoomLabel.AutoSize = true;
            this.reserveRoomLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.reserveRoomLabel.Location = new System.Drawing.Point(12, 150);
            this.reserveRoomLabel.Name = "reserveRoomLabel";
            this.reserveRoomLabel.Size = new System.Drawing.Size(78, 13);
            this.reserveRoomLabel.TabIndex = 10;
            this.reserveRoomLabel.Text = "Reserve Room";
            this.reserveRoomLabel.Click += new System.EventHandler(this.reserveRoomLabel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 263);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // checkInDateLabel
            // 
            this.checkInDateLabel.AutoSize = true;
            this.checkInDateLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.checkInDateLabel.Location = new System.Drawing.Point(12, 208);
            this.checkInDateLabel.Name = "checkInDateLabel";
            this.checkInDateLabel.Size = new System.Drawing.Size(75, 13);
            this.checkInDateLabel.TabIndex = 13;
            this.checkInDateLabel.Text = "Check-in Date";
            this.checkInDateLabel.Click += new System.EventHandler(this.checkInDateLabel_Click);
            // 
            // checkOutDateLabel
            // 
            this.checkOutDateLabel.AutoSize = true;
            this.checkOutDateLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.checkOutDateLabel.Location = new System.Drawing.Point(12, 247);
            this.checkOutDateLabel.Name = "checkOutDateLabel";
            this.checkOutDateLabel.Size = new System.Drawing.Size(82, 13);
            this.checkOutDateLabel.TabIndex = 14;
            this.checkOutDateLabel.Text = "Check-out Date";
            this.checkOutDateLabel.Click += new System.EventHandler(this.checkOutDateLabel_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.Gray;
            this.reserveButton.Location = new System.Drawing.Point(19, 289);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(75, 23);
            this.reserveButton.TabIndex = 15;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.checkOutDateLabel);
            this.Controls.Add(this.checkInDateLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reserveRoomLabel);
            this.Controls.Add(this.selectRoomButton);
            this.Controls.Add(this.selectGuestButton);
            this.Controls.Add(this.reservationsTabButton);
            this.Controls.Add(this.roomsTabButton);
            this.Controls.Add(this.guestsTabButton);
            this.Controls.Add(this.addRoomsButton);
            this.Controls.Add(this.addGuestsButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addGuestsButton;
        private System.Windows.Forms.Button addRoomsButton;
        private System.Windows.Forms.Button guestsTabButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button roomsTabButton;
        private System.Windows.Forms.Button reservationsTabButton;
        private System.Windows.Forms.Button selectGuestButton;
        private System.Windows.Forms.Button selectRoomButton;
        private System.Windows.Forms.Label reserveRoomLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label checkInDateLabel;
        private System.Windows.Forms.Label checkOutDateLabel;
        private System.Windows.Forms.Button reserveButton;
    }
}