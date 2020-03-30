namespace ProjectTopDesk
{
    partial class TopDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopDesk));
            this.lblFirstNameFlatText = new System.Windows.Forms.Label();
            this.lblLastNameFlatText = new System.Windows.Forms.Label();
            this.lblEmailFlatText = new System.Windows.Forms.Label();
            this.lblPhoneNumberFlatText = new System.Windows.Forms.Label();
            this.lblCurrentFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.pnlChangeUserData = new System.Windows.Forms.Panel();
            this.btnUpdateUserData = new System.Windows.Forms.Button();
            this.lblCurrentPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.lblCurrentEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblCurrentLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblNoDesk = new System.Windows.Forms.Label();
            this.lblLicensed = new System.Windows.Forms.Label();
            this.gbUnresolved = new System.Windows.Forms.GroupBox();
            this.lblPanelTitel = new System.Windows.Forms.Label();
            this.gbDeadline = new System.Windows.Forms.GroupBox();
            this.lblUnresolved = new System.Windows.Forms.Label();
            this.lblTotalIncident = new System.Windows.Forms.Label();
            this.lblLateIncident = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbUnresolved = new CircularProgressBar.CircularProgressBar();
            this.pbLate = new CircularProgressBar.CircularProgressBar();
            this.btnIncidentList = new System.Windows.Forms.Button();
            this.pnlChangeUserData.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbUnresolved.SuspendLayout();
            this.gbDeadline.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstNameFlatText
            // 
            this.lblFirstNameFlatText.AutoSize = true;
            this.lblFirstNameFlatText.Location = new System.Drawing.Point(41, 44);
            this.lblFirstNameFlatText.Name = "lblFirstNameFlatText";
            this.lblFirstNameFlatText.Size = new System.Drawing.Size(58, 13);
            this.lblFirstNameFlatText.TabIndex = 0;
            this.lblFirstNameFlatText.Text = "First name:";
            // 
            // lblLastNameFlatText
            // 
            this.lblLastNameFlatText.AutoSize = true;
            this.lblLastNameFlatText.Location = new System.Drawing.Point(40, 96);
            this.lblLastNameFlatText.Name = "lblLastNameFlatText";
            this.lblLastNameFlatText.Size = new System.Drawing.Size(59, 13);
            this.lblLastNameFlatText.TabIndex = 1;
            this.lblLastNameFlatText.Text = "Last name:";
            // 
            // lblEmailFlatText
            // 
            this.lblEmailFlatText.AutoSize = true;
            this.lblEmailFlatText.Location = new System.Drawing.Point(18, 147);
            this.lblEmailFlatText.Name = "lblEmailFlatText";
            this.lblEmailFlatText.Size = new System.Drawing.Size(81, 13);
            this.lblEmailFlatText.TabIndex = 2;
            this.lblEmailFlatText.Text = "E-mail address: ";
            // 
            // lblPhoneNumberFlatText
            // 
            this.lblPhoneNumberFlatText.AutoSize = true;
            this.lblPhoneNumberFlatText.Location = new System.Drawing.Point(18, 193);
            this.lblPhoneNumberFlatText.Name = "lblPhoneNumberFlatText";
            this.lblPhoneNumberFlatText.Size = new System.Drawing.Size(79, 13);
            this.lblPhoneNumberFlatText.TabIndex = 3;
            this.lblPhoneNumberFlatText.Text = "Phone number:";
            // 
            // lblCurrentFirstName
            // 
            this.lblCurrentFirstName.AutoSize = true;
            this.lblCurrentFirstName.Location = new System.Drawing.Point(111, 25);
            this.lblCurrentFirstName.Name = "lblCurrentFirstName";
            this.lblCurrentFirstName.Size = new System.Drawing.Size(85, 13);
            this.lblCurrentFirstName.TabIndex = 4;
            this.lblCurrentFirstName.Text = "current firstname";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(105, 41);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // pnlChangeUserData
            // 
            this.pnlChangeUserData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlChangeUserData.Controls.Add(this.btnUpdateUserData);
            this.pnlChangeUserData.Controls.Add(this.lblCurrentPhone);
            this.pnlChangeUserData.Controls.Add(this.textBoxPhone);
            this.pnlChangeUserData.Controls.Add(this.lblCurrentEmail);
            this.pnlChangeUserData.Controls.Add(this.textBoxEmail);
            this.pnlChangeUserData.Controls.Add(this.lblCurrentLastName);
            this.pnlChangeUserData.Controls.Add(this.textBoxLastName);
            this.pnlChangeUserData.Controls.Add(this.lblCurrentFirstName);
            this.pnlChangeUserData.Controls.Add(this.lblPhoneNumberFlatText);
            this.pnlChangeUserData.Controls.Add(this.textBoxFirstName);
            this.pnlChangeUserData.Controls.Add(this.lblEmailFlatText);
            this.pnlChangeUserData.Controls.Add(this.lblLastNameFlatText);
            this.pnlChangeUserData.Controls.Add(this.lblFirstNameFlatText);
            this.pnlChangeUserData.Location = new System.Drawing.Point(100, 185);
            this.pnlChangeUserData.Name = "pnlChangeUserData";
            this.pnlChangeUserData.Size = new System.Drawing.Size(557, 438);
            this.pnlChangeUserData.TabIndex = 6;
            // 
            // btnUpdateUserData
            // 
            this.btnUpdateUserData.Location = new System.Drawing.Point(338, 288);
            this.btnUpdateUserData.Name = "btnUpdateUserData";
            this.btnUpdateUserData.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUserData.TabIndex = 12;
            this.btnUpdateUserData.Text = "Update";
            this.btnUpdateUserData.UseVisualStyleBackColor = true;
            this.btnUpdateUserData.Click += new System.EventHandler(this.btnUpdateUserData_Click);
            // 
            // lblCurrentPhone
            // 
            this.lblCurrentPhone.AutoSize = true;
            this.lblCurrentPhone.Location = new System.Drawing.Point(102, 174);
            this.lblCurrentPhone.Name = "lblCurrentPhone";
            this.lblCurrentPhone.Size = new System.Drawing.Size(111, 13);
            this.lblCurrentPhone.TabIndex = 11;
            this.lblCurrentPhone.Text = "current phone number";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(103, 190);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 10;
            // 
            // lblCurrentEmail
            // 
            this.lblCurrentEmail.AutoSize = true;
            this.lblCurrentEmail.Location = new System.Drawing.Point(111, 128);
            this.lblCurrentEmail.Name = "lblCurrentEmail";
            this.lblCurrentEmail.Size = new System.Drawing.Size(67, 13);
            this.lblCurrentEmail.TabIndex = 9;
            this.lblCurrentEmail.Text = "current email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(105, 144);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 8;
            // 
            // lblCurrentLastName
            // 
            this.lblCurrentLastName.AutoSize = true;
            this.lblCurrentLastName.Location = new System.Drawing.Point(111, 77);
            this.lblCurrentLastName.Name = "lblCurrentLastName";
            this.lblCurrentLastName.Size = new System.Drawing.Size(85, 13);
            this.lblCurrentLastName.TabIndex = 7;
            this.lblCurrentLastName.Text = "current lastname";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(105, 93);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.btnIncidentList);
            this.pnlDashboard.Controls.Add(this.gbDeadline);
            this.pnlDashboard.Controls.Add(this.lblPanelTitel);
            this.pnlDashboard.Controls.Add(this.gbUnresolved);
            this.pnlDashboard.Location = new System.Drawing.Point(12, 121);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(646, 507);
            this.pnlDashboard.TabIndex = 7;
            this.pnlDashboard.VisibleChanged += new System.EventHandler(this.pnlDashboard_VisibleChanged);
            // 
            // menuMain
            // 
            this.menuMain.AutoSize = false;
            this.menuMain.BackColor = System.Drawing.Color.Transparent;
            this.menuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.incidentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(12, 78);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(646, 40);
            this.menuMain.TabIndex = 8;
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(142, 36);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(263, 36);
            this.incidentManagementToolStripMenuItem.Text = "Incident Management";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(15, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(172, 50);
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // lblNoDesk
            // 
            this.lblNoDesk.AutoSize = true;
            this.lblNoDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDesk.Location = new System.Drawing.Point(556, 9);
            this.lblNoDesk.Name = "lblNoDesk";
            this.lblNoDesk.Size = new System.Drawing.Size(90, 26);
            this.lblNoDesk.TabIndex = 10;
            this.lblNoDesk.Text = "NoDesk";
            // 
            // lblLicensed
            // 
            this.lblLicensed.AutoSize = true;
            this.lblLicensed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicensed.Location = new System.Drawing.Point(447, 38);
            this.lblLicensed.Name = "lblLicensed";
            this.lblLicensed.Size = new System.Drawing.Size(210, 17);
            this.lblLicensed.TabIndex = 11;
            this.lblLicensed.Text = "Licensed to: The Garden Group";
            // 
            // gbUnresolved
            // 
            this.gbUnresolved.Controls.Add(this.label1);
            this.gbUnresolved.Controls.Add(this.lblTotalIncident);
            this.gbUnresolved.Controls.Add(this.lblUnresolved);
            this.gbUnresolved.Controls.Add(this.pbUnresolved);
            this.gbUnresolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUnresolved.Location = new System.Drawing.Point(12, 108);
            this.gbUnresolved.Name = "gbUnresolved";
            this.gbUnresolved.Size = new System.Drawing.Size(300, 373);
            this.gbUnresolved.TabIndex = 0;
            this.gbUnresolved.TabStop = false;
            this.gbUnresolved.Text = "Unresolved Incidents";
            // 
            // lblPanelTitel
            // 
            this.lblPanelTitel.AutoSize = true;
            this.lblPanelTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelTitel.Location = new System.Drawing.Point(6, 43);
            this.lblPanelTitel.Name = "lblPanelTitel";
            this.lblPanelTitel.Size = new System.Drawing.Size(239, 31);
            this.lblPanelTitel.TabIndex = 1;
            this.lblPanelTitel.Text = "Current Incidents";
            // 
            // gbDeadline
            // 
            this.gbDeadline.Controls.Add(this.lblLateIncident);
            this.gbDeadline.Controls.Add(this.pbLate);
            this.gbDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeadline.Location = new System.Drawing.Point(334, 108);
            this.gbDeadline.Name = "gbDeadline";
            this.gbDeadline.Size = new System.Drawing.Size(300, 373);
            this.gbDeadline.TabIndex = 1;
            this.gbDeadline.TabStop = false;
            this.gbDeadline.Text = "Incidents past deadline";
            // 
            // lblUnresolved
            // 
            this.lblUnresolved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUnresolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnresolved.Location = new System.Drawing.Point(59, 169);
            this.lblUnresolved.Name = "lblUnresolved";
            this.lblUnresolved.Size = new System.Drawing.Size(75, 46);
            this.lblUnresolved.TabIndex = 0;
            this.lblUnresolved.Text = "1000";
            this.lblUnresolved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalIncident
            // 
            this.lblTotalIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotalIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncident.Location = new System.Drawing.Point(158, 169);
            this.lblTotalIncident.Name = "lblTotalIncident";
            this.lblTotalIncident.Size = new System.Drawing.Size(74, 46);
            this.lblTotalIncident.TabIndex = 1;
            this.lblTotalIncident.Text = "1000";
            this.lblTotalIncident.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLateIncident
            // 
            this.lblLateIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLateIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateIncident.Location = new System.Drawing.Point(62, 169);
            this.lblLateIncident.Name = "lblLateIncident";
            this.lblLateIncident.Size = new System.Drawing.Size(176, 46);
            this.lblLateIncident.TabIndex = 2;
            this.lblLateIncident.Text = "1000";
            this.lblLateIncident.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // pbUnresolved
            // 
            this.pbUnresolved.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbUnresolved.AnimationSpeed = 500;
            this.pbUnresolved.BackColor = System.Drawing.Color.Transparent;
            this.pbUnresolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbUnresolved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbUnresolved.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbUnresolved.InnerMargin = 2;
            this.pbUnresolved.InnerWidth = -1;
            this.pbUnresolved.Location = new System.Drawing.Point(22, 68);
            this.pbUnresolved.MarqueeAnimationSpeed = 2000;
            this.pbUnresolved.Name = "pbUnresolved";
            this.pbUnresolved.OuterColor = System.Drawing.Color.Gray;
            this.pbUnresolved.OuterMargin = -25;
            this.pbUnresolved.OuterWidth = 26;
            this.pbUnresolved.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbUnresolved.ProgressWidth = 25;
            this.pbUnresolved.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pbUnresolved.Size = new System.Drawing.Size(250, 250);
            this.pbUnresolved.StartAngle = 270;
            this.pbUnresolved.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbUnresolved.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbUnresolved.SubscriptText = ".23";
            this.pbUnresolved.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbUnresolved.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbUnresolved.SuperscriptText = "°C";
            this.pbUnresolved.TabIndex = 4;
            this.pbUnresolved.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbUnresolved.Value = 68;
            // 
            // pbLate
            // 
            this.pbLate.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbLate.AnimationSpeed = 500;
            this.pbLate.BackColor = System.Drawing.Color.Transparent;
            this.pbLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbLate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbLate.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbLate.InnerMargin = 2;
            this.pbLate.InnerWidth = -1;
            this.pbLate.Location = new System.Drawing.Point(25, 64);
            this.pbLate.MarqueeAnimationSpeed = 2000;
            this.pbLate.Maximum = 4;
            this.pbLate.Name = "pbLate";
            this.pbLate.OuterColor = System.Drawing.Color.Gray;
            this.pbLate.OuterMargin = -25;
            this.pbLate.OuterWidth = 26;
            this.pbLate.ProgressColor = System.Drawing.Color.Crimson;
            this.pbLate.ProgressWidth = 25;
            this.pbLate.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pbLate.Size = new System.Drawing.Size(250, 250);
            this.pbLate.StartAngle = 270;
            this.pbLate.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbLate.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbLate.SubscriptText = ".23";
            this.pbLate.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbLate.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbLate.SuperscriptText = "°C";
            this.pbLate.TabIndex = 5;
            this.pbLate.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbLate.Value = 4;
            // 
            // btnIncidentList
            // 
            this.btnIncidentList.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIncidentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncidentList.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnIncidentList.FlatAppearance.BorderSize = 0;
            this.btnIncidentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidentList.ForeColor = System.Drawing.Color.White;
            this.btnIncidentList.Location = new System.Drawing.Point(498, 43);
            this.btnIncidentList.Name = "btnIncidentList";
            this.btnIncidentList.Size = new System.Drawing.Size(136, 31);
            this.btnIncidentList.TabIndex = 2;
            this.btnIncidentList.Text = "Show List";
            this.btnIncidentList.UseVisualStyleBackColor = false;
            // 
            // frmTopDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 621);
            this.Controls.Add(this.lblLicensed);
            this.Controls.Add(this.lblNoDesk);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlChangeUserData);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmTopDesk";
            this.Text = "TopDesk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlChangeUserData.ResumeLayout(false);
            this.pnlChangeUserData.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbUnresolved.ResumeLayout(false);
            this.gbUnresolved.PerformLayout();
            this.gbDeadline.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNameFlatText;
        private System.Windows.Forms.Label lblLastNameFlatText;
        private System.Windows.Forms.Label lblEmailFlatText;
        private System.Windows.Forms.Label lblPhoneNumberFlatText;
        private System.Windows.Forms.Label lblCurrentFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Panel pnlChangeUserData;
        private System.Windows.Forms.Label lblCurrentLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label lblCurrentPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label lblCurrentEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button btnUpdateUserData;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblNoDesk;
        private System.Windows.Forms.Label lblLicensed;
        private System.Windows.Forms.GroupBox gbDeadline;
        private System.Windows.Forms.Label lblPanelTitel;
        private System.Windows.Forms.GroupBox gbUnresolved;
        private System.Windows.Forms.Label lblLateIncident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalIncident;
        private System.Windows.Forms.Label lblUnresolved;
        private CircularProgressBar.CircularProgressBar pbUnresolved;
        private CircularProgressBar.CircularProgressBar pbLate;
        private System.Windows.Forms.Button btnIncidentList;
    }
}

