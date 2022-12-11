namespace Inventory_Management
{
    partial class FrmInventoryM
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventoryM));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserNameTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.showpasschk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtpassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.UserNameTxt);
            this.groupBox1.Controls.Add(this.showpasschk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(106, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 338);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.AcceptsReturn = false;
            this.UserNameTxt.AcceptsTab = false;
            this.UserNameTxt.AnimationSpeed = 200;
            this.UserNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserNameTxt.BackColor = System.Drawing.Color.Transparent;
            this.UserNameTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserNameTxt.BackgroundImage")));
            this.UserNameTxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.UserNameTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserNameTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UserNameTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.UserNameTxt.BorderRadius = 1;
            this.UserNameTxt.BorderThickness = 1;
            this.UserNameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.UserNameTxt.DefaultText = "UserName";
            this.UserNameTxt.FillColor = System.Drawing.Color.White;
            this.UserNameTxt.HideSelection = true;
            this.UserNameTxt.IconLeft = null;
            this.UserNameTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxt.IconPadding = 10;
            this.UserNameTxt.IconRight = null;
            this.UserNameTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxt.Lines = new string[] {
        "UserName"};
            this.UserNameTxt.Location = new System.Drawing.Point(66, 84);
            this.UserNameTxt.MaxLength = 32767;
            this.UserNameTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserNameTxt.Modified = false;
            this.UserNameTxt.Multiline = false;
            this.UserNameTxt.Name = "UserNameTxt";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserNameTxt.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UserNameTxt.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserNameTxt.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserNameTxt.OnIdleState = stateProperties24;
            this.UserNameTxt.Padding = new System.Windows.Forms.Padding(3);
            this.UserNameTxt.PasswordChar = '\0';
            this.UserNameTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserNameTxt.PlaceholderText = "Enter text";
            this.UserNameTxt.ReadOnly = false;
            this.UserNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameTxt.SelectedText = "";
            this.UserNameTxt.SelectionLength = 0;
            this.UserNameTxt.SelectionStart = 0;
            this.UserNameTxt.ShortcutsEnabled = true;
            this.UserNameTxt.Size = new System.Drawing.Size(167, 37);
            this.UserNameTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.UserNameTxt.TabIndex = 10;
            this.UserNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserNameTxt.TextMarginBottom = 0;
            this.UserNameTxt.TextMarginLeft = 3;
            this.UserNameTxt.TextMarginTop = 0;
            this.UserNameTxt.TextPlaceholder = "Enter text";
            this.UserNameTxt.UseSystemPasswordChar = false;
            this.UserNameTxt.WordWrap = true;
            // 
            // showpasschk
            // 
            this.showpasschk.AutoSize = true;
            this.showpasschk.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpasschk.Location = new System.Drawing.Point(138, 258);
            this.showpasschk.Name = "showpasschk";
            this.showpasschk.Size = new System.Drawing.Size(121, 20);
            this.showpasschk.TabIndex = 8;
            this.showpasschk.Text = "Show Password";
            this.showpasschk.UseVisualStyleBackColor = true;
            this.showpasschk.CheckedChanged += new System.EventHandler(this.showpasschk_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clear";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.AcceptsReturn = false;
            this.txtpassword.AcceptsTab = false;
            this.txtpassword.AnimationSpeed = 200;
            this.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpassword.BackgroundImage")));
            this.txtpassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtpassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtpassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtpassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtpassword.BorderRadius = 1;
            this.txtpassword.BorderThickness = 1;
            this.txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtpassword.DefaultText = "Password";
            this.txtpassword.FillColor = System.Drawing.Color.White;
            this.txtpassword.HideSelection = true;
            this.txtpassword.IconLeft = null;
            this.txtpassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.IconPadding = 10;
            this.txtpassword.IconRight = null;
            this.txtpassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Lines = new string[] {
        "Password"};
            this.txtpassword.Location = new System.Drawing.Point(66, 153);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtpassword.Modified = false;
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtpassword.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtpassword.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtpassword.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtpassword.OnIdleState = stateProperties20;
            this.txtpassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtpassword.PlaceholderText = "Enter text";
            this.txtpassword.ReadOnly = false;
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 8;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(167, 37);
            this.txtpassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtpassword.TabIndex = 11;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.TextMarginBottom = 0;
            this.txtpassword.TextMarginLeft = 3;
            this.txtpassword.TextMarginTop = 0;
            this.txtpassword.TextPlaceholder = "Enter text";
            this.txtpassword.UseSystemPasswordChar = false;
            this.txtpassword.WordWrap = true;
            // 
            // FrmInventoryM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 494);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventoryM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInventoryM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox showpasschk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuTextBox UserNameTxt;
        private System.Windows.Forms.Button button2;
        private Bunifu.UI.WinForms.BunifuTextBox txtpassword;
    }
}