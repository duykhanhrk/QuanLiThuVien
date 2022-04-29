namespace QuanLyThuVien.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties33 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties34 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties35 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties36 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties37 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties38 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties39 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties40 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iDTB = new Bunifu.UI.WinForms.BunifuTextBox();
            this.passwordTB = new Bunifu.UI.WinForms.BunifuTextBox();
            this.loginBT = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // iDTB
            // 
            this.iDTB.AcceptsReturn = false;
            this.iDTB.AcceptsTab = false;
            this.iDTB.AnimationSpeed = 200;
            this.iDTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.iDTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.iDTB.BackColor = System.Drawing.Color.Transparent;
            this.iDTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iDTB.BackgroundImage")));
            this.iDTB.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.iDTB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.iDTB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(73)))), ((int)(((byte)(154)))));
            this.iDTB.BorderColorIdle = System.Drawing.Color.Silver;
            this.iDTB.BorderRadius = 8;
            this.iDTB.BorderThickness = 1;
            this.iDTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.iDTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iDTB.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.iDTB.DefaultText = "";
            this.iDTB.FillColor = System.Drawing.Color.White;
            this.iDTB.HideSelection = true;
            this.iDTB.IconLeft = null;
            this.iDTB.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.iDTB.IconPadding = 10;
            this.iDTB.IconRight = null;
            this.iDTB.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.iDTB.Lines = new string[0];
            this.iDTB.Location = new System.Drawing.Point(96, 29);
            this.iDTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iDTB.MaxLength = 32767;
            this.iDTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.iDTB.Modified = false;
            this.iDTB.Multiline = false;
            this.iDTB.Name = "iDTB";
            stateProperties33.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            stateProperties33.FillColor = System.Drawing.Color.Empty;
            stateProperties33.ForeColor = System.Drawing.Color.Empty;
            stateProperties33.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.iDTB.OnActiveState = stateProperties33;
            stateProperties34.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties34.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.iDTB.OnDisabledState = stateProperties34;
            stateProperties35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(73)))), ((int)(((byte)(154)))));
            stateProperties35.FillColor = System.Drawing.Color.Empty;
            stateProperties35.ForeColor = System.Drawing.Color.Empty;
            stateProperties35.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.iDTB.OnHoverState = stateProperties35;
            stateProperties36.BorderColor = System.Drawing.Color.Silver;
            stateProperties36.FillColor = System.Drawing.Color.White;
            stateProperties36.ForeColor = System.Drawing.Color.Empty;
            stateProperties36.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.iDTB.OnIdleState = stateProperties36;
            this.iDTB.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iDTB.PasswordChar = '\0';
            this.iDTB.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.iDTB.PlaceholderText = "Enter text";
            this.iDTB.ReadOnly = false;
            this.iDTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iDTB.SelectedText = "";
            this.iDTB.SelectionLength = 0;
            this.iDTB.SelectionStart = 0;
            this.iDTB.ShortcutsEnabled = true;
            this.iDTB.Size = new System.Drawing.Size(303, 37);
            this.iDTB.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.iDTB.TabIndex = 2;
            this.iDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.iDTB.TextMarginBottom = 0;
            this.iDTB.TextMarginLeft = 3;
            this.iDTB.TextMarginTop = 0;
            this.iDTB.TextPlaceholder = "Enter text";
            this.iDTB.UseSystemPasswordChar = false;
            this.iDTB.WordWrap = true;
            // 
            // passwordTB
            // 
            this.passwordTB.AcceptsReturn = false;
            this.passwordTB.AcceptsTab = false;
            this.passwordTB.AnimationSpeed = 200;
            this.passwordTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTB.BackColor = System.Drawing.Color.Transparent;
            this.passwordTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTB.BackgroundImage")));
            this.passwordTB.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.passwordTB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordTB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(73)))), ((int)(((byte)(154)))));
            this.passwordTB.BorderColorIdle = System.Drawing.Color.Silver;
            this.passwordTB.BorderRadius = 8;
            this.passwordTB.BorderThickness = 1;
            this.passwordTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.passwordTB.DefaultText = "";
            this.passwordTB.FillColor = System.Drawing.Color.White;
            this.passwordTB.HideSelection = true;
            this.passwordTB.IconLeft = null;
            this.passwordTB.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.IconPadding = 10;
            this.passwordTB.IconRight = null;
            this.passwordTB.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.Lines = new string[0];
            this.passwordTB.Location = new System.Drawing.Point(96, 79);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTB.MaxLength = 32767;
            this.passwordTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordTB.Modified = false;
            this.passwordTB.Multiline = false;
            this.passwordTB.Name = "passwordTB";
            stateProperties37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            stateProperties37.FillColor = System.Drawing.Color.Empty;
            stateProperties37.ForeColor = System.Drawing.Color.Empty;
            stateProperties37.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTB.OnActiveState = stateProperties37;
            stateProperties38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties38.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordTB.OnDisabledState = stateProperties38;
            stateProperties39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(73)))), ((int)(((byte)(154)))));
            stateProperties39.FillColor = System.Drawing.Color.Empty;
            stateProperties39.ForeColor = System.Drawing.Color.Empty;
            stateProperties39.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTB.OnHoverState = stateProperties39;
            stateProperties40.BorderColor = System.Drawing.Color.Silver;
            stateProperties40.FillColor = System.Drawing.Color.White;
            stateProperties40.ForeColor = System.Drawing.Color.Empty;
            stateProperties40.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTB.OnIdleState = stateProperties40;
            this.passwordTB.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordTB.PlaceholderText = "Enter text";
            this.passwordTB.ReadOnly = false;
            this.passwordTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTB.SelectedText = "";
            this.passwordTB.SelectionLength = 0;
            this.passwordTB.SelectionStart = 0;
            this.passwordTB.ShortcutsEnabled = true;
            this.passwordTB.Size = new System.Drawing.Size(303, 37);
            this.passwordTB.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.passwordTB.TabIndex = 3;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTB.TextMarginBottom = 0;
            this.passwordTB.TextMarginLeft = 3;
            this.passwordTB.TextMarginTop = 0;
            this.passwordTB.TextPlaceholder = "Enter text";
            this.passwordTB.UseSystemPasswordChar = false;
            this.passwordTB.WordWrap = true;
            // 
            // loginBT
            // 
            this.loginBT.AllowAnimations = true;
            this.loginBT.AllowMouseEffects = true;
            this.loginBT.AllowToggling = false;
            this.loginBT.AnimationSpeed = 200;
            this.loginBT.AutoGenerateColors = false;
            this.loginBT.AutoRoundBorders = false;
            this.loginBT.AutoSizeLeftIcon = true;
            this.loginBT.AutoSizeRightIcon = true;
            this.loginBT.BackColor = System.Drawing.Color.Transparent;
            this.loginBT.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.loginBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBT.BackgroundImage")));
            this.loginBT.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBT.ButtonText = "Đăng nhập";
            this.loginBT.ButtonTextMarginLeft = 0;
            this.loginBT.ColorContrastOnClick = 45;
            this.loginBT.ColorContrastOnHover = 45;
            this.loginBT.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.loginBT.CustomizableEdges = borderEdges5;
            this.loginBT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginBT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loginBT.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loginBT.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.loginBT.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.loginBT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginBT.ForeColor = System.Drawing.Color.White;
            this.loginBT.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBT.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.loginBT.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.loginBT.IconMarginLeft = 11;
            this.loginBT.IconPadding = 10;
            this.loginBT.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBT.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.loginBT.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.loginBT.IconSize = 25;
            this.loginBT.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.loginBT.IdleBorderRadius = 8;
            this.loginBT.IdleBorderThickness = 1;
            this.loginBT.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.loginBT.IdleIconLeftImage = null;
            this.loginBT.IdleIconRightImage = null;
            this.loginBT.IndicateFocus = false;
            this.loginBT.Location = new System.Drawing.Point(134, 140);
            this.loginBT.Name = "loginBT";
            this.loginBT.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loginBT.OnDisabledState.BorderRadius = 8;
            this.loginBT.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBT.OnDisabledState.BorderThickness = 1;
            this.loginBT.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loginBT.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.loginBT.OnDisabledState.IconLeftImage = null;
            this.loginBT.OnDisabledState.IconRightImage = null;
            this.loginBT.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.loginBT.onHoverState.BorderRadius = 8;
            this.loginBT.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBT.onHoverState.BorderThickness = 1;
            this.loginBT.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.loginBT.onHoverState.ForeColor = System.Drawing.Color.White;
            this.loginBT.onHoverState.IconLeftImage = null;
            this.loginBT.onHoverState.IconRightImage = null;
            this.loginBT.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.loginBT.OnIdleState.BorderRadius = 8;
            this.loginBT.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBT.OnIdleState.BorderThickness = 1;
            this.loginBT.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.loginBT.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.loginBT.OnIdleState.IconLeftImage = null;
            this.loginBT.OnIdleState.IconRightImage = null;
            this.loginBT.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(73)))), ((int)(((byte)(154)))));
            this.loginBT.OnPressedState.BorderRadius = 8;
            this.loginBT.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBT.OnPressedState.BorderThickness = 1;
            this.loginBT.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(73)))), ((int)(((byte)(154)))));
            this.loginBT.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.loginBT.OnPressedState.IconLeftImage = null;
            this.loginBT.OnPressedState.IconRightImage = null;
            this.loginBT.Size = new System.Drawing.Size(150, 39);
            this.loginBT.TabIndex = 4;
            this.loginBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBT.TextMarginLeft = 0;
            this.loginBT.TextPadding = new System.Windows.Forms.Padding(0);
            this.loginBT.UseDefaultRadiusAndThickness = true;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 209);
            this.Controls.Add(this.loginBT);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.iDTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox iDTB;
        private Bunifu.UI.WinForms.BunifuTextBox passwordTB;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton loginBT;
    }
}