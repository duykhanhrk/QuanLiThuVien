namespace QuanLyThuVien.Forms.LiquidatingSlipDetailForms
{
    partial class DetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTB = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bookDD = new Bunifu.UI.WinForms.BunifuDropdown();
            this.nameLB = new System.Windows.Forms.Label();
            this.closeBT = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBT = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.priceTB);
            this.panel2.Controls.Add(this.bookDD);
            this.panel2.Controls.Add(this.nameLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 370);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 82;
            this.label1.Text = "Giá";
            // 
            // priceTB
            // 
            this.priceTB.AcceptsReturn = false;
            this.priceTB.AcceptsTab = false;
            this.priceTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTB.AnimationSpeed = 200;
            this.priceTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.priceTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.priceTB.BackColor = System.Drawing.Color.Transparent;
            this.priceTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("priceTB.BackgroundImage")));
            this.priceTB.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.priceTB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.priceTB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.priceTB.BorderColorIdle = System.Drawing.Color.Silver;
            this.priceTB.BorderRadius = 8;
            this.priceTB.BorderThickness = 1;
            this.priceTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.priceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTB.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.priceTB.DefaultText = "";
            this.priceTB.FillColor = System.Drawing.Color.White;
            this.priceTB.HideSelection = true;
            this.priceTB.IconLeft = null;
            this.priceTB.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTB.IconPadding = 10;
            this.priceTB.IconRight = null;
            this.priceTB.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTB.Lines = new string[0];
            this.priceTB.Location = new System.Drawing.Point(103, 50);
            this.priceTB.MaxLength = 32767;
            this.priceTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.priceTB.Modified = false;
            this.priceTB.Multiline = false;
            this.priceTB.Name = "priceTB";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.priceTB.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.priceTB.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.priceTB.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.priceTB.OnIdleState = stateProperties4;
            this.priceTB.Padding = new System.Windows.Forms.Padding(3);
            this.priceTB.PasswordChar = '\0';
            this.priceTB.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.priceTB.PlaceholderText = "Enter text";
            this.priceTB.ReadOnly = false;
            this.priceTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceTB.SelectedText = "";
            this.priceTB.SelectionLength = 0;
            this.priceTB.SelectionStart = 0;
            this.priceTB.ShortcutsEnabled = true;
            this.priceTB.Size = new System.Drawing.Size(260, 37);
            this.priceTB.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.priceTB.TabIndex = 81;
            this.priceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.priceTB.TextMarginBottom = 0;
            this.priceTB.TextMarginLeft = 3;
            this.priceTB.TextMarginTop = 0;
            this.priceTB.TextPlaceholder = "Enter text";
            this.priceTB.UseSystemPasswordChar = false;
            this.priceTB.WordWrap = true;
            // 
            // bookDD
            // 
            this.bookDD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDD.BackColor = System.Drawing.Color.Transparent;
            this.bookDD.BackgroundColor = System.Drawing.Color.White;
            this.bookDD.BorderColor = System.Drawing.Color.Silver;
            this.bookDD.BorderRadius = 8;
            this.bookDD.Color = System.Drawing.Color.Silver;
            this.bookDD.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bookDD.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bookDD.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bookDD.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bookDD.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookDD.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bookDD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bookDD.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bookDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookDD.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bookDD.FillDropDown = true;
            this.bookDD.FillIndicator = false;
            this.bookDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookDD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookDD.ForeColor = System.Drawing.Color.Black;
            this.bookDD.FormattingEnabled = true;
            this.bookDD.Icon = null;
            this.bookDD.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bookDD.IndicatorColor = System.Drawing.Color.Gray;
            this.bookDD.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bookDD.ItemBackColor = System.Drawing.Color.White;
            this.bookDD.ItemBorderColor = System.Drawing.Color.White;
            this.bookDD.ItemForeColor = System.Drawing.Color.Black;
            this.bookDD.ItemHeight = 26;
            this.bookDD.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bookDD.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bookDD.ItemTopMargin = 3;
            this.bookDD.Location = new System.Drawing.Point(103, 12);
            this.bookDD.Name = "bookDD";
            this.bookDD.Size = new System.Drawing.Size(260, 32);
            this.bookDD.TabIndex = 71;
            this.bookDD.Text = null;
            this.bookDD.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bookDD.TextLeftMargin = 5;
            // 
            // nameLB
            // 
            this.nameLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLB.Location = new System.Drawing.Point(33, 29);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(54, 15);
            this.nameLB.TabIndex = 60;
            this.nameLB.Text = "Mã sách";
            // 
            // closeBT
            // 
            this.closeBT.AllowAnimations = true;
            this.closeBT.AllowMouseEffects = true;
            this.closeBT.AllowToggling = false;
            this.closeBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBT.AnimationSpeed = 200;
            this.closeBT.AutoGenerateColors = false;
            this.closeBT.AutoRoundBorders = false;
            this.closeBT.AutoSizeLeftIcon = true;
            this.closeBT.AutoSizeRightIcon = true;
            this.closeBT.BackColor = System.Drawing.Color.Transparent;
            this.closeBT.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.closeBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBT.BackgroundImage")));
            this.closeBT.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closeBT.ButtonText = "Thoát";
            this.closeBT.ButtonTextMarginLeft = 0;
            this.closeBT.ColorContrastOnClick = 45;
            this.closeBT.ColorContrastOnHover = 45;
            this.closeBT.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.closeBT.CustomizableEdges = borderEdges1;
            this.closeBT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeBT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.closeBT.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.closeBT.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.closeBT.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.closeBT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeBT.ForeColor = System.Drawing.Color.White;
            this.closeBT.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBT.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.closeBT.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.closeBT.IconMarginLeft = 11;
            this.closeBT.IconPadding = 10;
            this.closeBT.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBT.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.closeBT.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.closeBT.IconSize = 25;
            this.closeBT.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.closeBT.IdleBorderRadius = 8;
            this.closeBT.IdleBorderThickness = 1;
            this.closeBT.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.closeBT.IdleIconLeftImage = null;
            this.closeBT.IdleIconRightImage = null;
            this.closeBT.IndicateFocus = false;
            this.closeBT.Location = new System.Drawing.Point(57, 29);
            this.closeBT.Name = "closeBT";
            this.closeBT.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.closeBT.OnDisabledState.BorderRadius = 8;
            this.closeBT.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closeBT.OnDisabledState.BorderThickness = 1;
            this.closeBT.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.closeBT.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.closeBT.OnDisabledState.IconLeftImage = null;
            this.closeBT.OnDisabledState.IconRightImage = null;
            this.closeBT.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.closeBT.onHoverState.BorderRadius = 8;
            this.closeBT.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closeBT.onHoverState.BorderThickness = 1;
            this.closeBT.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.closeBT.onHoverState.ForeColor = System.Drawing.Color.White;
            this.closeBT.onHoverState.IconLeftImage = null;
            this.closeBT.onHoverState.IconRightImage = null;
            this.closeBT.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.closeBT.OnIdleState.BorderRadius = 8;
            this.closeBT.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closeBT.OnIdleState.BorderThickness = 1;
            this.closeBT.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.closeBT.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.closeBT.OnIdleState.IconLeftImage = null;
            this.closeBT.OnIdleState.IconRightImage = null;
            this.closeBT.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(73)))), ((int)(((byte)(154)))));
            this.closeBT.OnPressedState.BorderRadius = 8;
            this.closeBT.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.closeBT.OnPressedState.BorderThickness = 1;
            this.closeBT.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(73)))), ((int)(((byte)(154)))));
            this.closeBT.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.closeBT.OnPressedState.IconLeftImage = null;
            this.closeBT.OnPressedState.IconRightImage = null;
            this.closeBT.Size = new System.Drawing.Size(150, 39);
            this.closeBT.TabIndex = 32;
            this.closeBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.closeBT.TextMarginLeft = 0;
            this.closeBT.TextPadding = new System.Windows.Forms.Padding(0);
            this.closeBT.UseDefaultRadiusAndThickness = true;
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.saveBT);
            this.panel1.Controls.Add(this.closeBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 80);
            this.panel1.TabIndex = 13;
            // 
            // saveBT
            // 
            this.saveBT.AllowAnimations = true;
            this.saveBT.AllowMouseEffects = true;
            this.saveBT.AllowToggling = false;
            this.saveBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBT.AnimationSpeed = 200;
            this.saveBT.AutoGenerateColors = false;
            this.saveBT.AutoRoundBorders = false;
            this.saveBT.AutoSizeLeftIcon = true;
            this.saveBT.AutoSizeRightIcon = true;
            this.saveBT.BackColor = System.Drawing.Color.Transparent;
            this.saveBT.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.saveBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBT.BackgroundImage")));
            this.saveBT.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBT.ButtonText = "Lưu";
            this.saveBT.ButtonTextMarginLeft = 0;
            this.saveBT.ColorContrastOnClick = 45;
            this.saveBT.ColorContrastOnHover = 45;
            this.saveBT.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.saveBT.CustomizableEdges = borderEdges2;
            this.saveBT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveBT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveBT.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveBT.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveBT.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.saveBT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBT.ForeColor = System.Drawing.Color.White;
            this.saveBT.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBT.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.saveBT.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.saveBT.IconMarginLeft = 11;
            this.saveBT.IconPadding = 10;
            this.saveBT.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBT.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.saveBT.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.saveBT.IconSize = 25;
            this.saveBT.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.saveBT.IdleBorderRadius = 8;
            this.saveBT.IdleBorderThickness = 1;
            this.saveBT.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.saveBT.IdleIconLeftImage = null;
            this.saveBT.IdleIconRightImage = null;
            this.saveBT.IndicateFocus = false;
            this.saveBT.Location = new System.Drawing.Point(213, 29);
            this.saveBT.Name = "saveBT";
            this.saveBT.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveBT.OnDisabledState.BorderRadius = 8;
            this.saveBT.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBT.OnDisabledState.BorderThickness = 1;
            this.saveBT.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveBT.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveBT.OnDisabledState.IconLeftImage = null;
            this.saveBT.OnDisabledState.IconRightImage = null;
            this.saveBT.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.saveBT.onHoverState.BorderRadius = 8;
            this.saveBT.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBT.onHoverState.BorderThickness = 1;
            this.saveBT.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.saveBT.onHoverState.ForeColor = System.Drawing.Color.White;
            this.saveBT.onHoverState.IconLeftImage = null;
            this.saveBT.onHoverState.IconRightImage = null;
            this.saveBT.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.saveBT.OnIdleState.BorderRadius = 8;
            this.saveBT.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBT.OnIdleState.BorderThickness = 1;
            this.saveBT.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(144)))));
            this.saveBT.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.saveBT.OnIdleState.IconLeftImage = null;
            this.saveBT.OnIdleState.IconRightImage = null;
            this.saveBT.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(73)))), ((int)(((byte)(154)))));
            this.saveBT.OnPressedState.BorderRadius = 8;
            this.saveBT.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBT.OnPressedState.BorderThickness = 1;
            this.saveBT.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(73)))), ((int)(((byte)(154)))));
            this.saveBT.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.saveBT.OnPressedState.IconLeftImage = null;
            this.saveBT.OnPressedState.IconRightImage = null;
            this.saveBT.Size = new System.Drawing.Size(150, 39);
            this.saveBT.TabIndex = 33;
            this.saveBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveBT.TextMarginLeft = 0;
            this.saveBT.TextPadding = new System.Windows.Forms.Padding(0);
            this.saveBT.UseDefaultRadiusAndThickness = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết";
            this.Shown += new System.EventHandler(this.DetailForm_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDropdown bookDD;
        private System.Windows.Forms.Label nameLB;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton closeBT;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton saveBT;
        private Bunifu.UI.WinForms.BunifuTextBox priceTB;
        private System.Windows.Forms.Label label1;
    }
}