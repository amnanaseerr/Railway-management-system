namespace RailwayReservationSystem
{
    partial class UC_CancelTicket
    {
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.Button btnCancelReservation;

        private void InitializeComponent()
        {
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassengerName.Location = new System.Drawing.Point(20, 20);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(160, 20);
            this.lblPassengerName.TabIndex = 0;
            this.lblPassengerName.Text = "Enter Your Name:";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassengerName.Location = new System.Drawing.Point(200, 17);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(250, 26);
            this.txtPassengerName.TabIndex = 1;
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.AllowUserToAddRows = false;
            this.dataGridViewReservations.AllowUserToDeleteRows = false;
            this.dataGridViewReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.ReadOnly = true;
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.RowTemplate.Height = 24;
            this.dataGridViewReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReservations.Size = new System.Drawing.Size(760, 350);
            this.dataGridViewReservations.TabIndex = 2;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnCancelReservation.FlatAppearance.BorderSize = 0;
            this.btnCancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelReservation.ForeColor = System.Drawing.Color.White;
            this.btnCancelReservation.Location = new System.Drawing.Point(20, 430);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(200, 40);
            this.btnCancelReservation.TabIndex = 3;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // UC_CancelTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.lblPassengerName);
            this.Name = "UC_CancelTicket";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.UC_CancelTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
