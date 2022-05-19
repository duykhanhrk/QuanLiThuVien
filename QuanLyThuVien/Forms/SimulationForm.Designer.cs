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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addRoleBT = new System.Windows.Forms.Button();
            this.removeRoleBT = new System.Windows.Forms.Button();
            this.updateRoleBT = new System.Windows.Forms.Button();
            this.refreshRoleBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rolesDGV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loginsDGV = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // addRoleBT
            // 
            this.addRoleBT.Location = new System.Drawing.Point(23, 15);
            this.addRoleBT.Name = "addRoleBT";
            this.addRoleBT.Size = new System.Drawing.Size(75, 23);
            this.addRoleBT.TabIndex = 0;
            this.addRoleBT.Text = "Thêm";
            this.addRoleBT.UseVisualStyleBackColor = true;
            this.addRoleBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeRoleBT
            // 
            this.removeRoleBT.Location = new System.Drawing.Point(114, 15);
            this.removeRoleBT.Name = "removeRoleBT";
            this.removeRoleBT.Size = new System.Drawing.Size(75, 23);
            this.removeRoleBT.TabIndex = 1;
            this.removeRoleBT.Text = "Xóa";
            this.removeRoleBT.UseVisualStyleBackColor = true;
            // 
            // updateRoleBT
            // 
            this.updateRoleBT.Location = new System.Drawing.Point(213, 15);
            this.updateRoleBT.Name = "updateRoleBT";
            this.updateRoleBT.Size = new System.Drawing.Size(75, 23);
            this.updateRoleBT.TabIndex = 2;
            this.updateRoleBT.Text = "Sửa";
            this.updateRoleBT.UseVisualStyleBackColor = true;
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
            // panel2
            // 
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 53);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
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
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolesDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginsDGV)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}