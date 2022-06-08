namespace QuanLyThuVien.Forms
{
    partial class SimulationForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rolesDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshRoleBT = new System.Windows.Forms.Button();
            this.updateRoleBT = new System.Windows.Forms.Button();
            this.removeRoleBT = new System.Windows.Forms.Button();
            this.addRoleBT = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loginsDGV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.refreshLoginsButton = new System.Windows.Forms.Button();
            this.updateLoginBT = new System.Windows.Forms.Button();
            this.deleteLoginBT = new System.Windows.Forms.Button();
            this.addLoginBT = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restoreBT = new System.Windows.Forms.Button();
            this.fullRSBT = new System.Windows.Forms.Button();
            this.diffRSBT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullBKBT = new System.Windows.Forms.Button();
            this.diffBKBT = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginsDGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1192, 584);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1184, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Role";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rolesDGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 56);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(24);
            this.panel2.Size = new System.Drawing.Size(1178, 499);
            this.panel2.TabIndex = 1;
            // 
            // rolesDGV
            // 
            this.rolesDGV.BackgroundColor = System.Drawing.Color.White;
            this.rolesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesDGV.Location = new System.Drawing.Point(24, 24);
            this.rolesDGV.Name = "rolesDGV";
            this.rolesDGV.Size = new System.Drawing.Size(1130, 451);
            this.rolesDGV.TabIndex = 0;
            this.rolesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesDGV_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.refreshRoleBT);
            this.panel1.Controls.Add(this.updateRoleBT);
            this.panel1.Controls.Add(this.removeRoleBT);
            this.panel1.Controls.Add(this.addRoleBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 53);
            this.panel1.TabIndex = 0;
            // 
            // refreshRoleBT
            // 
            this.refreshRoleBT.Location = new System.Drawing.Point(311, 15);
            this.refreshRoleBT.Name = "refreshRoleBT";
            this.refreshRoleBT.Size = new System.Drawing.Size(75, 23);
            this.refreshRoleBT.TabIndex = 3;
            this.refreshRoleBT.Text = "Làm mới";
            this.refreshRoleBT.UseVisualStyleBackColor = true;
            this.refreshRoleBT.Click += new System.EventHandler(this.refreshRoleBT_Click);
            // 
            // updateRoleBT
            // 
            this.updateRoleBT.Location = new System.Drawing.Point(213, 15);
            this.updateRoleBT.Name = "updateRoleBT";
            this.updateRoleBT.Size = new System.Drawing.Size(75, 23);
            this.updateRoleBT.TabIndex = 2;
            this.updateRoleBT.Text = "Sửa";
            this.updateRoleBT.UseVisualStyleBackColor = true;
            this.updateRoleBT.Click += new System.EventHandler(this.updateRoleBT_Click);
            // 
            // removeRoleBT
            // 
            this.removeRoleBT.Location = new System.Drawing.Point(114, 15);
            this.removeRoleBT.Name = "removeRoleBT";
            this.removeRoleBT.Size = new System.Drawing.Size(75, 23);
            this.removeRoleBT.TabIndex = 1;
            this.removeRoleBT.Text = "Xóa";
            this.removeRoleBT.UseVisualStyleBackColor = true;
            this.removeRoleBT.Click += new System.EventHandler(this.removeRoleBT_Click);
            // 
            // addRoleBT
            // 
            this.addRoleBT.Location = new System.Drawing.Point(23, 15);
            this.addRoleBT.Name = "addRoleBT";
            this.addRoleBT.Size = new System.Drawing.Size(75, 23);
            this.addRoleBT.TabIndex = 0;
            this.addRoleBT.Text = "Thêm";
            this.addRoleBT.UseVisualStyleBackColor = true;
            this.addRoleBT.Click += new System.EventHandler(this.addRoleBT_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1184, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.loginsDGV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 56);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(24);
            this.panel4.Size = new System.Drawing.Size(1178, 499);
            this.panel4.TabIndex = 2;
            // 
            // loginsDGV
            // 
            this.loginsDGV.BackgroundColor = System.Drawing.Color.White;
            this.loginsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loginsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginsDGV.Location = new System.Drawing.Point(24, 24);
            this.loginsDGV.Name = "loginsDGV";
            this.loginsDGV.Size = new System.Drawing.Size(1130, 451);
            this.loginsDGV.TabIndex = 0;
            this.loginsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loginsDGV_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.refreshLoginsButton);
            this.panel3.Controls.Add(this.updateLoginBT);
            this.panel3.Controls.Add(this.deleteLoginBT);
            this.panel3.Controls.Add(this.addLoginBT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 53);
            this.panel3.TabIndex = 1;
            // 
            // refreshLoginsButton
            // 
            this.refreshLoginsButton.Location = new System.Drawing.Point(311, 15);
            this.refreshLoginsButton.Name = "refreshLoginsButton";
            this.refreshLoginsButton.Size = new System.Drawing.Size(75, 23);
            this.refreshLoginsButton.TabIndex = 3;
            this.refreshLoginsButton.Text = "Làm mới";
            this.refreshLoginsButton.UseVisualStyleBackColor = true;
            this.refreshLoginsButton.Click += new System.EventHandler(this.refreshLoginsButton_Click);
            // 
            // updateLoginBT
            // 
            this.updateLoginBT.Location = new System.Drawing.Point(213, 15);
            this.updateLoginBT.Name = "updateLoginBT";
            this.updateLoginBT.Size = new System.Drawing.Size(75, 23);
            this.updateLoginBT.TabIndex = 2;
            this.updateLoginBT.Text = "Sửa";
            this.updateLoginBT.UseVisualStyleBackColor = true;
            this.updateLoginBT.Click += new System.EventHandler(this.updateLoginBT_Click);
            // 
            // deleteLoginBT
            // 
            this.deleteLoginBT.Location = new System.Drawing.Point(114, 15);
            this.deleteLoginBT.Name = "deleteLoginBT";
            this.deleteLoginBT.Size = new System.Drawing.Size(75, 23);
            this.deleteLoginBT.TabIndex = 1;
            this.deleteLoginBT.Text = "Xóa";
            this.deleteLoginBT.UseVisualStyleBackColor = true;
            this.deleteLoginBT.Click += new System.EventHandler(this.deleteLoginBT_Click);
            // 
            // addLoginBT
            // 
            this.addLoginBT.Location = new System.Drawing.Point(23, 15);
            this.addLoginBT.Name = "addLoginBT";
            this.addLoginBT.Size = new System.Drawing.Size(75, 23);
            this.addLoginBT.TabIndex = 0;
            this.addLoginBT.Text = "Thêm";
            this.addLoginBT.UseVisualStyleBackColor = true;
            this.addLoginBT.Click += new System.EventHandler(this.addLoginBT_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1184, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Backup & Restore";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(24);
            this.panel5.Size = new System.Drawing.Size(1184, 558);
            this.panel5.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.restoreBT);
            this.groupBox2.Controls.Add(this.fullRSBT);
            this.groupBox2.Controls.Add(this.diffRSBT);
            this.groupBox2.Location = new System.Drawing.Point(27, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1130, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore";
            // 
            // restoreBT
            // 
            this.restoreBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreBT.Location = new System.Drawing.Point(1049, 41);
            this.restoreBT.Name = "restoreBT";
            this.restoreBT.Size = new System.Drawing.Size(75, 23);
            this.restoreBT.TabIndex = 2;
            this.restoreBT.Text = "Restore";
            this.restoreBT.UseVisualStyleBackColor = true;
            this.restoreBT.Click += new System.EventHandler(this.restoreBT_Click);
            // 
            // fullRSBT
            // 
            this.fullRSBT.Location = new System.Drawing.Point(20, 41);
            this.fullRSBT.Name = "fullRSBT";
            this.fullRSBT.Size = new System.Drawing.Size(75, 23);
            this.fullRSBT.TabIndex = 0;
            this.fullRSBT.Text = "Full";
            this.fullRSBT.UseVisualStyleBackColor = true;
            this.fullRSBT.Click += new System.EventHandler(this.fullRSBT_Click);
            // 
            // diffRSBT
            // 
            this.diffRSBT.Location = new System.Drawing.Point(101, 41);
            this.diffRSBT.Name = "diffRSBT";
            this.diffRSBT.Size = new System.Drawing.Size(75, 23);
            this.diffRSBT.TabIndex = 1;
            this.diffRSBT.Text = "Differential";
            this.diffRSBT.UseVisualStyleBackColor = true;
            this.diffRSBT.Click += new System.EventHandler(this.diffRSBT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fullBKBT);
            this.groupBox1.Controls.Add(this.diffBKBT);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1130, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // fullBKBT
            // 
            this.fullBKBT.Location = new System.Drawing.Point(20, 41);
            this.fullBKBT.Name = "fullBKBT";
            this.fullBKBT.Size = new System.Drawing.Size(75, 23);
            this.fullBKBT.TabIndex = 0;
            this.fullBKBT.Text = "Full";
            this.fullBKBT.UseVisualStyleBackColor = true;
            this.fullBKBT.Click += new System.EventHandler(this.fullBKBT_Click);
            // 
            // diffBKBT
            // 
            this.diffBKBT.Location = new System.Drawing.Point(101, 41);
            this.diffBKBT.Name = "diffBKBT";
            this.diffBKBT.Size = new System.Drawing.Size(75, 23);
            this.diffBKBT.TabIndex = 1;
            this.diffBKBT.Text = "Differential";
            this.diffBKBT.UseVisualStyleBackColor = true;
            this.diffBKBT.Click += new System.EventHandler(this.diffBKBT_Click);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 584);
            this.Controls.Add(this.tabControl1);
            this.Name = "SimulationForm";
            this.Text = "SimulationForm";
            this.Shown += new System.EventHandler(this.SimulationForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolesDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginsDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addRoleBT;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button refreshRoleBT;
        private System.Windows.Forms.Button updateRoleBT;
        private System.Windows.Forms.Button removeRoleBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView rolesDGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView loginsDGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button refreshLoginsButton;
        private System.Windows.Forms.Button deleteLoginBT;
        private System.Windows.Forms.Button addLoginBT;
        private System.Windows.Forms.Button updateLoginBT;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button fullRSBT;
        private System.Windows.Forms.Button diffRSBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fullBKBT;
        private System.Windows.Forms.Button diffBKBT;
        private System.Windows.Forms.Button restoreBT;
    }
}