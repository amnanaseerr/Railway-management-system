
namespace RailwayReservationSystem
{
    partial class UC_AddTrain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.dtDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtArrival = new System.Windows.Forms.DateTimePicker();
            this.numSeats = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Train Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(132, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departure Time ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arrival Time ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Seats";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.Location = new System.Drawing.Point(316, 388);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(120, 38);
            this.btnAddTrain.TabIndex = 6;
            this.btnAddTrain.Text = "Add Train ";
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click_1);
            // 
            // txtTrainName
            // 
            this.txtTrainName.Location = new System.Drawing.Point(258, 83);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(285, 26);
            this.txtTrainName.TabIndex = 7;
            this.txtTrainName.TextChanged += new System.EventHandler(this.txtTrainName_TextChanged);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(258, 129);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(285, 26);
            this.txtSource.TabIndex = 8;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(258, 174);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(285, 26);
            this.txtDestination.TabIndex = 9;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // dtDeparture
            // 
            this.dtDeparture.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDeparture.Location = new System.Drawing.Point(258, 219);
            this.dtDeparture.Name = "dtDeparture";
            this.dtDeparture.ShowUpDown = true;
            this.dtDeparture.Size = new System.Drawing.Size(285, 26);
            this.dtDeparture.TabIndex = 10;
            this.dtDeparture.ValueChanged += new System.EventHandler(this.dtDeparture_ValueChanged);
            // 
            // dtArrival
            // 
            this.dtArrival.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArrival.Location = new System.Drawing.Point(258, 262);
            this.dtArrival.Name = "dtArrival";
            this.dtArrival.ShowUpDown = true;
            this.dtArrival.Size = new System.Drawing.Size(285, 26);
            this.dtArrival.TabIndex = 11;
            this.dtArrival.ValueChanged += new System.EventHandler(this.dtArrival_ValueChanged);
            // 
            // numSeats
            // 
            this.numSeats.Location = new System.Drawing.Point(258, 306);
            this.numSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(120, 26);
            this.numSeats.TabIndex = 12;
            this.numSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UC_AddTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.numSeats);
            this.Controls.Add(this.dtArrival);
            this.Controls.Add(this.dtDeparture);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.txtTrainName);
            this.Controls.Add(this.btnAddTrain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddTrain";
            this.Size = new System.Drawing.Size(766, 771);
            this.Load += new System.EventHandler(this.UC_AddTrain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.TextBox txtTrainName;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.DateTimePicker dtDeparture;
        private System.Windows.Forms.DateTimePicker dtArrival;
        private System.Windows.Forms.NumericUpDown numSeats;
    }
}
