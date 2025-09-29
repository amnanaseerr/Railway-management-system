namespace RailwayReservationSystem
{
    partial class UC_BookTicket
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewAvailableTrains = new System.Windows.Forms.DataGridView();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.numericUpDownSeats = new System.Windows.Forms.NumericUpDown();
            this.lblSeats = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableTrains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book Ticket";
            // 
            // dataGridViewAvailableTrains
            // 
            this.dataGridViewAvailableTrains.AllowUserToAddRows = false;
            this.dataGridViewAvailableTrains.AllowUserToDeleteRows = false;
            this.dataGridViewAvailableTrains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAvailableTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableTrains.Location = new System.Drawing.Point(25, 70);
            this.dataGridViewAvailableTrains.Name = "dataGridViewAvailableTrains";
            this.dataGridViewAvailableTrains.ReadOnly = true;
            this.dataGridViewAvailableTrains.RowHeadersWidth = 51;
            this.dataGridViewAvailableTrains.RowTemplate.Height = 24;
            this.dataGridViewAvailableTrains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvailableTrains.Size = new System.Drawing.Size(730, 250);
            this.dataGridViewAvailableTrains.TabIndex = 1;
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(170, 340);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(250, 22);
            this.txtPassengerName.TabIndex = 2;
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Location = new System.Drawing.Point(25, 340);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(123, 17);
            this.lblPassengerName.TabIndex = 3;
            this.lblPassengerName.Text = "Passenger Name:";
            // 
            // numericUpDownSeats
            // 
            this.numericUpDownSeats.Location = new System.Drawing.Point(170, 380);
            this.numericUpDownSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeats.Name = "numericUpDownSeats";
            this.numericUpDownSeats.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSeats.TabIndex = 4;
            this.numericUpDownSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(25, 380);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(47, 17);
            this.lblSeats.TabIndex = 5;
            this.lblSeats.Text = "Seats:";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(170, 420);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(150, 35);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // UC_BookTicket
            // 
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.numericUpDownSeats);
            this.Controls.Add(this.lblPassengerName);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.dataGridViewAvailableTrains);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_BookTicket";
            this.Size = new System.Drawing.Size(780, 600);
            this.Load += new System.EventHandler(this.UC_BookTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableTrains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridViewAvailableTrains;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.NumericUpDown numericUpDownSeats;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Button btnBook;
    }
}
