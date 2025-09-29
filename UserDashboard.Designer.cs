namespace RailwayReservationSystem
{
    partial class UserDashboard
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.btnViewTicket = new System.Windows.Forms.Button();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.btnSearchTrain = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnUserLogout = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panelSidebar.Controls.Add(this.btnUserLogout);
            this.panelSidebar.Controls.Add(this.btnCancelTicket);
            this.panelSidebar.Controls.Add(this.btnViewTicket);
            this.panelSidebar.Controls.Add(this.btnBookTicket);
            this.panelSidebar.Controls.Add(this.btnSearchTrain);
            this.panelSidebar.Controls.Add(this.lblWelcome);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(248, 750);
            this.panelSidebar.TabIndex = 0;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelTicket.FlatAppearance.BorderSize = 0;
            this.btnCancelTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTicket.ForeColor = System.Drawing.Color.White;
            this.btnCancelTicket.Location = new System.Drawing.Point(0, 236);
            this.btnCancelTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(248, 62);
            this.btnCancelTicket.TabIndex = 5;
            this.btnCancelTicket.Text = "Cancel Ticket";
            this.btnCancelTicket.UseVisualStyleBackColor = false;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // btnViewTicket
            // 
            this.btnViewTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnViewTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewTicket.FlatAppearance.BorderSize = 0;
            this.btnViewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTicket.ForeColor = System.Drawing.Color.White;
            this.btnViewTicket.Location = new System.Drawing.Point(0, 174);
            this.btnViewTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewTicket.Name = "btnViewTicket";
            this.btnViewTicket.Size = new System.Drawing.Size(248, 62);
            this.btnViewTicket.TabIndex = 4;
            this.btnViewTicket.Text = "View Ticket";
            this.btnViewTicket.UseVisualStyleBackColor = false;
            this.btnViewTicket.Click += new System.EventHandler(this.btnViewTicket_Click);
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnBookTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookTicket.FlatAppearance.BorderSize = 0;
            this.btnBookTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTicket.ForeColor = System.Drawing.Color.White;
            this.btnBookTicket.Location = new System.Drawing.Point(0, 112);
            this.btnBookTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(248, 62);
            this.btnBookTicket.TabIndex = 3;
            this.btnBookTicket.Text = "Book Ticket";
            this.btnBookTicket.UseVisualStyleBackColor = false;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // btnSearchTrain
            // 
            this.btnSearchTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchTrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchTrain.FlatAppearance.BorderSize = 0;
            this.btnSearchTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTrain.ForeColor = System.Drawing.Color.White;
            this.btnSearchTrain.Location = new System.Drawing.Point(0, 50);
            this.btnSearchTrain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchTrain.Name = "btnSearchTrain";
            this.btnSearchTrain.Size = new System.Drawing.Size(248, 62);
            this.btnSearchTrain.TabIndex = 1;
            this.btnSearchTrain.Text = "Search Train";
            this.btnSearchTrain.UseVisualStyleBackColor = false;
            this.btnSearchTrain.Click += new System.EventHandler(this.btnSearchTrain_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(248, 50);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, User!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(248, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(877, 750);
            this.panelMain.TabIndex = 1;
            // 
            // btnUserLogout
            // 
            this.btnUserLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnUserLogout.FlatAppearance.BorderSize = 0;
            this.btnUserLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLogout.ForeColor = System.Drawing.Color.White;
            this.btnUserLogout.Location = new System.Drawing.Point(38, 351);
            this.btnUserLogout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnUserLogout.Name = "btnUserLogout";
            this.btnUserLogout.Size = new System.Drawing.Size(165, 53);
            this.btnUserLogout.TabIndex = 6;
            this.btnUserLogout.Text = "Logout ";
            this.btnUserLogout.UseVisualStyleBackColor = false;
            this.btnUserLogout.Click += new System.EventHandler(this.btnUserLogout_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 750);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard - Railway Reservation System";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSearchTrain;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Button btnViewTicket;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Button btnUserLogout;
    }
}
