namespace RailwayReservationSystem
{
    partial class DeleteTrainControl
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
            this.txtTrainID = new System.Windows.Forms.TextBox();
            this.btnDeleteTrain = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Train ID to Delete";
            // 
            // txtTrainID
            // 
            this.txtTrainID.Location = new System.Drawing.Point(470, 245);
            this.txtTrainID.Name = "txtTrainID";
            this.txtTrainID.Size = new System.Drawing.Size(100, 26);
            this.txtTrainID.TabIndex = 1;
            this.txtTrainID.TextChanged += new System.EventHandler(this.txtTrainID_TextChanged);
            // 
            // btnDeleteTrain
            // 
            this.btnDeleteTrain.Location = new System.Drawing.Point(610, 235);
            this.btnDeleteTrain.Name = "btnDeleteTrain";
            this.btnDeleteTrain.Size = new System.Drawing.Size(112, 40);
            this.btnDeleteTrain.TabIndex = 2;
            this.btnDeleteTrain.Text = "Delete Train";
            this.btnDeleteTrain.UseVisualStyleBackColor = true;
            this.btnDeleteTrain.Click += new System.EventHandler(this.btnDeleteTrain_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(450, 314);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 3;
            // 
            // DeleteTrainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDeleteTrain);
            this.Controls.Add(this.txtTrainID);
            this.Controls.Add(this.label1);
            this.Name = "DeleteTrainControl";
            this.Size = new System.Drawing.Size(1057, 747);
            this.Load += new System.EventHandler(this.DeleteTrainControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrainID;
        private System.Windows.Forms.Button btnDeleteTrain;
        private System.Windows.Forms.Label lblStatus;
    }
}
