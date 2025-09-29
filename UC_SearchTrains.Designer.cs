namespace RailwayReservationSystem
{
    partial class UC_SearchTrains
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSourceStation = new System.Windows.Forms.Label();
            this.lblDestinationStation = new System.Windows.Forms.Label();
            this.lblJourneyDate = new System.Windows.Forms.Label();
            this.txtSourceStation = new System.Windows.Forms.TextBox();
            this.txtDestinationStation = new System.Windows.Forms.TextBox();
            this.dateTimePickerJourneyDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchTrain = new System.Windows.Forms.Button();
            this.dataGridViewSearchResults = new System.Windows.Forms.DataGridView();
            this.lblSearchStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Search Trains";
            // 
            // lblSourceStation
            // 
            this.lblSourceStation.AutoSize = true;
            this.lblSourceStation.Location = new System.Drawing.Point(22, 70);
            this.lblSourceStation.Name = "lblSourceStation";
            this.lblSourceStation.Size = new System.Drawing.Size(110, 17);
            this.lblSourceStation.TabIndex = 1;
            this.lblSourceStation.Text = "Source Station:";
            // 
            // lblDestinationStation
            // 
            this.lblDestinationStation.AutoSize = true;
            this.lblDestinationStation.Location = new System.Drawing.Point(22, 110);
            this.lblDestinationStation.Name = "lblDestinationStation";
            this.lblDestinationStation.Size = new System.Drawing.Size(136, 17);
            this.lblDestinationStation.TabIndex = 2;
            this.lblDestinationStation.Text = "Destination Station:";
            // 
            // lblJourneyDate
            // 
            this.lblJourneyDate.AutoSize = true;
            this.lblJourneyDate.Location = new System.Drawing.Point(22, 150);
            this.lblJourneyDate.Name = "lblJourneyDate";
            this.lblJourneyDate.Size = new System.Drawing.Size(98, 17);
            this.lblJourneyDate.TabIndex = 3;
            this.lblJourneyDate.Text = "Journey Date:";
            // 
            // txtSourceStation
            // 
            this.txtSourceStation.Location = new System.Drawing.Point(170, 70);
            this.txtSourceStation.Name = "txtSourceStation";
            this.txtSourceStation.Size = new System.Drawing.Size(250, 22);
            this.txtSourceStation.TabIndex = 4;
            // 
            // txtDestinationStation
            // 
            this.txtDestinationStation.Location = new System.Drawing.Point(170, 110);
            this.txtDestinationStation.Name = "txtDestinationStation";
            this.txtDestinationStation.Size = new System.Drawing.Size(250, 22);
            this.txtDestinationStation.TabIndex = 5;
            // 
            // dateTimePickerJourneyDate
            // 
            this.dateTimePickerJourneyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerJourneyDate.Location = new System.Drawing.Point(170, 150);
            this.dateTimePickerJourneyDate.Name = "dateTimePickerJourneyDate";
            this.dateTimePickerJourneyDate.Size = new System.Drawing.Size(150, 22);
            this.dateTimePickerJourneyDate.TabIndex = 6;
            // 
            // btnSearchTrain
            // 
            this.btnSearchTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnSearchTrain.FlatAppearance.BorderSize = 0;
            this.btnSearchTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTrain.ForeColor = System.Drawing.Color.White;
            this.btnSearchTrain.Location = new System.Drawing.Point(170, 190);
            this.btnSearchTrain.Name = "btnSearchTrain";
            this.btnSearchTrain.Size = new System.Drawing.Size(150, 35);
            this.btnSearchTrain.TabIndex = 7;
            this.btnSearchTrain.Text = "Search";
            this.btnSearchTrain.UseVisualStyleBackColor = false;
            this.btnSearchTrain.Click += new System.EventHandler(this.btnSearchTrain_Click);
            // 
            // dataGridViewSearchResults
            // 
            this.dataGridViewSearchResults.AllowUserToAddRows = false;
            this.dataGridViewSearchResults.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResults.Location = new System.Drawing.Point(25, 240);
            this.dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            this.dataGridViewSearchResults.ReadOnly = true;
            this.dataGridViewSearchResults.RowHeadersWidth = 51;
            this.dataGridViewSearchResults.RowTemplate.Height = 24;
            this.dataGridViewSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchResults.Size = new System.Drawing.Size(730, 320);
            this.dataGridViewSearchResults.TabIndex = 8;
            // 
            // lblSearchStatus
            // 
            this.lblSearchStatus.AutoSize = true;
            this.lblSearchStatus.Location = new System.Drawing.Point(350, 200);
            this.lblSearchStatus.Name = "lblSearchStatus";
            this.lblSearchStatus.Size = new System.Drawing.Size(0, 17);
            this.lblSearchStatus.TabIndex = 9;
            // 
            // UC_SearchTrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSearchStatus);
            this.Controls.Add(this.dataGridViewSearchResults);
            this.Controls.Add(this.btnSearchTrain);
            this.Controls.Add(this.dateTimePickerJourneyDate);
            this.Controls.Add(this.txtDestinationStation);
            this.Controls.Add(this.txtSourceStation);
            this.Controls.Add(this.lblJourneyDate);
            this.Controls.Add(this.lblDestinationStation);
            this.Controls.Add(this.lblSourceStation);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_SearchTrains";
            this.Size = new System.Drawing.Size(780, 600);
            this.Load += new System.EventHandler(this.UC_SearchTrains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSourceStation;
        private System.Windows.Forms.Label lblDestinationStation;
        private System.Windows.Forms.Label lblJourneyDate;
        private System.Windows.Forms.TextBox txtSourceStation;
        private System.Windows.Forms.TextBox txtDestinationStation;
        private System.Windows.Forms.DateTimePicker dateTimePickerJourneyDate;
        private System.Windows.Forms.Button btnSearchTrain;
        private System.Windows.Forms.DataGridView dataGridViewSearchResults;
        private System.Windows.Forms.Label lblSearchStatus;
    }
}
