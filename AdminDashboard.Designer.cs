namespace RailwayReservationSystem
{
    partial class AdminDashboard
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
            this.PanelSideBar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.btnDeleteTrain = new System.Windows.Forms.Button();
            this.btnViewAllTrains = new System.Windows.Forms.Button();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.PanelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSideBar
            // 
            this.PanelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.PanelSideBar.Controls.Add(this.btnLogout);
            this.PanelSideBar.Controls.Add(this.btnDeleteUser);
            this.PanelSideBar.Controls.Add(this.btnViewUsers);
            this.PanelSideBar.Controls.Add(this.btnViewReservations);
            this.PanelSideBar.Controls.Add(this.btnDeleteTrain);
            this.PanelSideBar.Controls.Add(this.btnViewAllTrains);
            this.PanelSideBar.Controls.Add(this.btnAddTrain);
            this.PanelSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelSideBar.Location = new System.Drawing.Point(0, 0);
            this.PanelSideBar.Name = "PanelSideBar";
            this.PanelSideBar.Size = new System.Drawing.Size(279, 788);
            this.PanelSideBar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(34, 600);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(184, 41);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(43, 510);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(184, 41);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.FlatAppearance.BorderSize = 0;
            this.btnViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUsers.ForeColor = System.Drawing.Color.White;
            this.btnViewUsers.Location = new System.Drawing.Point(43, 442);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(184, 41);
            this.btnViewUsers.TabIndex = 6;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnViewReservations
            // 
            this.btnViewReservations.FlatAppearance.BorderSize = 0;
            this.btnViewReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReservations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReservations.ForeColor = System.Drawing.Color.White;
            this.btnViewReservations.Location = new System.Drawing.Point(25, 395);
            this.btnViewReservations.Name = "btnViewReservations";
            this.btnViewReservations.Size = new System.Drawing.Size(219, 41);
            this.btnViewReservations.TabIndex = 4;
            this.btnViewReservations.Text = "View Reservations";
            this.btnViewReservations.UseVisualStyleBackColor = true;
            this.btnViewReservations.Click += new System.EventHandler(this.btnViewReservations_Click);
            // 
            // btnDeleteTrain
            // 
            this.btnDeleteTrain.FlatAppearance.BorderSize = 0;
            this.btnDeleteTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTrain.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTrain.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTrain.Location = new System.Drawing.Point(43, 348);
            this.btnDeleteTrain.Name = "btnDeleteTrain";
            this.btnDeleteTrain.Size = new System.Drawing.Size(184, 41);
            this.btnDeleteTrain.TabIndex = 3;
            this.btnDeleteTrain.Text = "Delete Train";
            this.btnDeleteTrain.UseVisualStyleBackColor = true;
            this.btnDeleteTrain.Click += new System.EventHandler(this.btnDeleteTrain_Click);
            // 
            // btnViewAllTrains
            // 
            this.btnViewAllTrains.FlatAppearance.BorderSize = 0;
            this.btnViewAllTrains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllTrains.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllTrains.ForeColor = System.Drawing.Color.White;
            this.btnViewAllTrains.Location = new System.Drawing.Point(43, 288);
            this.btnViewAllTrains.Name = "btnViewAllTrains";
            this.btnViewAllTrains.Size = new System.Drawing.Size(184, 41);
            this.btnViewAllTrains.TabIndex = 2;
            this.btnViewAllTrains.Text = "View All Trains";
            this.btnViewAllTrains.UseVisualStyleBackColor = true;
            this.btnViewAllTrains.Click += new System.EventHandler(this.btnViewAllTrains_Click);
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.FlatAppearance.BorderSize = 0;
            this.btnAddTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrain.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrain.ForeColor = System.Drawing.Color.White;
            this.btnAddTrain.Location = new System.Drawing.Point(43, 229);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(184, 41);
            this.btnAddTrain.TabIndex = 1;
            this.btnAddTrain.Text = "Add train";
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // panelMainContent
            // 
            this.panelMainContent.Location = new System.Drawing.Point(284, 94);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1002, 694);
            this.panelMainContent.TabIndex = 1;
            this.panelMainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainContent_Paint);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 788);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.PanelSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.PanelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSideBar;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Button btnViewAllTrains;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnViewReservations;
        private System.Windows.Forms.Button btnDeleteTrain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Panel panelMainContent;
    }
}