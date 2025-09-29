namespace RailwayReservationSystem
{
    partial class UC_ViewTrains
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
            this.dataGridViewTrains = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrains)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrains
            // 
            this.dataGridViewTrains.AllowUserToAddRows = false;
            this.dataGridViewTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrains.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTrains.Name = "dataGridViewTrains";
            this.dataGridViewTrains.ReadOnly = true;
            this.dataGridViewTrains.RowHeadersWidth = 62;
            this.dataGridViewTrains.RowTemplate.Height = 28;
            this.dataGridViewTrains.Size = new System.Drawing.Size(809, 421);
            this.dataGridViewTrains.TabIndex = 0;
            // 
            // UC_ViewTrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTrains);
            this.Name = "UC_ViewTrains";
            this.Size = new System.Drawing.Size(809, 421);
            this.Load += new System.EventHandler(this.UC_ViewTrains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrains)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrains;
    }
}
