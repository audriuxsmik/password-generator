namespace Password_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackbar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.generatebutton = new Guna.UI2.WinForms.Guna2Button();
            this.pswsize = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numberscheckbox = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.copy = new Guna.UI2.WinForms.Guna2Button();
            this.copylabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nums = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.specialcheckbox = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.chara = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.capitalcheckbox = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // trackbar
            // 
            this.trackbar.BackColor = System.Drawing.Color.Transparent;
            this.trackbar.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.trackbar.LargeChange = 1;
            this.trackbar.Location = new System.Drawing.Point(87, 134);
            this.trackbar.Maximum = 50;
            this.trackbar.Minimum = 5;
            this.trackbar.Name = "trackbar";
            this.trackbar.Size = new System.Drawing.Size(383, 64);
            this.trackbar.TabIndex = 1;
            this.trackbar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.trackbar.Value = 10;
            this.trackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackbar_Scroll);
            // 
            // pass
            // 
            this.pass.Animated = true;
            this.pass.BorderRadius = 10;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.DefaultText = "";
            this.pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.Location = new System.Drawing.Point(87, 32);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '\0';
            this.pass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.pass.PlaceholderText = "";
            this.pass.ReadOnly = true;
            this.pass.SelectedText = "";
            this.pass.Size = new System.Drawing.Size(582, 58);
            this.pass.TabIndex = 3;
            // 
            // generatebutton
            // 
            this.generatebutton.Animated = true;
            this.generatebutton.BackColor = System.Drawing.Color.Transparent;
            this.generatebutton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.generatebutton.BorderRadius = 9;
            this.generatebutton.BorderThickness = 1;
            this.generatebutton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.generatebutton.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.generatebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generatebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generatebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generatebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generatebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.generatebutton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebutton.ForeColor = System.Drawing.Color.White;
            this.generatebutton.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.generatebutton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.generatebutton.Location = new System.Drawing.Point(516, 288);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(227, 45);
            this.generatebutton.TabIndex = 6;
            this.generatebutton.Text = "Generate Password";
            this.generatebutton.Tile = true;
            this.generatebutton.UseTransparentBackground = true;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // pswsize
            // 
            this.pswsize.BackColor = System.Drawing.Color.Transparent;
            this.pswsize.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswsize.ForeColor = System.Drawing.Color.White;
            this.pswsize.Location = new System.Drawing.Point(87, 123);
            this.pswsize.Name = "pswsize";
            this.pswsize.Size = new System.Drawing.Size(135, 25);
            this.pswsize.TabIndex = 7;
            this.pswsize.Text = "Password Length:";
            // 
            // numberscheckbox
            // 
            this.numberscheckbox.Animated = true;
            this.numberscheckbox.AutoRoundedCorners = true;
            this.numberscheckbox.Checked = true;
            this.numberscheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.numberscheckbox.CheckedState.BorderRadius = 11;
            this.numberscheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.numberscheckbox.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.numberscheckbox.CheckedState.InnerBorderRadius = 7;
            this.numberscheckbox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.numberscheckbox.Location = new System.Drawing.Point(87, 204);
            this.numberscheckbox.Name = "numberscheckbox";
            this.numberscheckbox.Size = new System.Drawing.Size(54, 25);
            this.numberscheckbox.TabIndex = 8;
            this.numberscheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numberscheckbox.UncheckedState.BorderRadius = 11;
            this.numberscheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numberscheckbox.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.numberscheckbox.UncheckedState.InnerBorderRadius = 7;
            this.numberscheckbox.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // copy
            // 
            this.copy.Animated = true;
            this.copy.BackColor = System.Drawing.Color.Transparent;
            this.copy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.copy.BorderRadius = 9;
            this.copy.BorderThickness = 1;
            this.copy.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.copy.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.copy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.copy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.copy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.copy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.copy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.ForeColor = System.Drawing.Color.White;
            this.copy.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.copy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.copy.Location = new System.Drawing.Point(595, 97);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(74, 31);
            this.copy.TabIndex = 10;
            this.copy.Text = "Copy";
            this.copy.Tile = true;
            this.copy.UseTransparentBackground = true;
            this.copy.Visible = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // copylabel
            // 
            this.copylabel.BackColor = System.Drawing.Color.Transparent;
            this.copylabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copylabel.ForeColor = System.Drawing.Color.Lime;
            this.copylabel.Location = new System.Drawing.Point(323, 97);
            this.copylabel.Name = "copylabel";
            this.copylabel.Size = new System.Drawing.Size(266, 20);
            this.copylabel.TabIndex = 11;
            this.copylabel.Text = "The password has been successfully copied!";
            this.copylabel.Visible = false;
            this.copylabel.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // nums
            // 
            this.nums.BackColor = System.Drawing.Color.Transparent;
            this.nums.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nums.ForeColor = System.Drawing.Color.White;
            this.nums.Location = new System.Drawing.Point(147, 204);
            this.nums.Name = "nums";
            this.nums.Size = new System.Drawing.Size(70, 25);
            this.nums.TabIndex = 12;
            this.nums.Text = "Numbers";
            // 
            // specialcheckbox
            // 
            this.specialcheckbox.Animated = true;
            this.specialcheckbox.AutoRoundedCorners = true;
            this.specialcheckbox.Checked = true;
            this.specialcheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.specialcheckbox.CheckedState.BorderRadius = 11;
            this.specialcheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.specialcheckbox.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.specialcheckbox.CheckedState.InnerBorderRadius = 7;
            this.specialcheckbox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.specialcheckbox.Location = new System.Drawing.Point(87, 235);
            this.specialcheckbox.Name = "specialcheckbox";
            this.specialcheckbox.Size = new System.Drawing.Size(54, 25);
            this.specialcheckbox.TabIndex = 13;
            this.specialcheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.specialcheckbox.UncheckedState.BorderRadius = 11;
            this.specialcheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.specialcheckbox.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.specialcheckbox.UncheckedState.InnerBorderRadius = 7;
            this.specialcheckbox.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // chara
            // 
            this.chara.BackColor = System.Drawing.Color.Transparent;
            this.chara.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chara.ForeColor = System.Drawing.Color.White;
            this.chara.Location = new System.Drawing.Point(147, 235);
            this.chara.Name = "chara";
            this.chara.Size = new System.Drawing.Size(143, 25);
            this.chara.TabIndex = 14;
            this.chara.Text = "Special Characters";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(147, 266);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(113, 25);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Capital Letters";
            // 
            // capitalcheckbox
            // 
            this.capitalcheckbox.Animated = true;
            this.capitalcheckbox.AutoRoundedCorners = true;
            this.capitalcheckbox.Checked = true;
            this.capitalcheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.capitalcheckbox.CheckedState.BorderRadius = 11;
            this.capitalcheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.capitalcheckbox.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.capitalcheckbox.CheckedState.InnerBorderRadius = 7;
            this.capitalcheckbox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.capitalcheckbox.Location = new System.Drawing.Point(87, 266);
            this.capitalcheckbox.Name = "capitalcheckbox";
            this.capitalcheckbox.Size = new System.Drawing.Size(54, 25);
            this.capitalcheckbox.TabIndex = 15;
            this.capitalcheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.capitalcheckbox.UncheckedState.BorderRadius = 11;
            this.capitalcheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.capitalcheckbox.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.capitalcheckbox.UncheckedState.InnerBorderRadius = 7;
            this.capitalcheckbox.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(2, 335);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(222, 16);
            this.guna2HtmlLabel2.TabIndex = 11;
            this.guna2HtmlLabel2.Text = "github.com/audriuxsmik/password-generator";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(741, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(29, 24);
            this.guna2HtmlLabel3.TabIndex = 17;
            this.guna2HtmlLabel3.Text = "v1.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(771, 354);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.capitalcheckbox);
            this.Controls.Add(this.chara);
            this.Controls.Add(this.specialcheckbox);
            this.Controls.Add(this.nums);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.copylabel);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.numberscheckbox);
            this.Controls.Add(this.pswsize);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.trackbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Generator v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TrackBar trackbar;
        private Guna.UI2.WinForms.Guna2TextBox pass;
        private Guna.UI2.WinForms.Guna2Button generatebutton;
        private Guna.UI2.WinForms.Guna2HtmlLabel pswsize;
        private Guna.UI2.WinForms.Guna2ToggleSwitch numberscheckbox;
        private Guna.UI2.WinForms.Guna2Button copy;
        private Guna.UI2.WinForms.Guna2HtmlLabel copylabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel nums;
        private Guna.UI2.WinForms.Guna2ToggleSwitch specialcheckbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel chara;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch capitalcheckbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}

