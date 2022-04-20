
namespace Airline
{
    partial class JoinNowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinNowForm));
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.phonenumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.ssn = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.go = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.Animated = true;
            this.username.AutoRoundedCorners = true;
            this.username.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BorderColor = System.Drawing.Color.Black;
            this.username.BorderRadius = 21;
            this.username.BorderThickness = 2;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "Username";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.username.FocusedState.Parent = this.username;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.HoverState.BorderColor = System.Drawing.Color.White;
            this.username.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.username.HoverState.Parent = this.username;
            this.username.Location = new System.Drawing.Point(217, 110);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "";
            this.username.SelectedText = "";
            this.username.SelectionStart = 8;
            this.username.ShadowDecoration.BorderRadius = 10;
            this.username.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(496, 44);
            this.username.TabIndex = 2;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Animated = true;
            this.password.AutoRoundedCorners = true;
            this.password.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BorderColor = System.Drawing.Color.Black;
            this.password.BorderRadius = 21;
            this.password.BorderThickness = 2;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "Password";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.password.FocusedState.Parent = this.password;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.HoverState.BorderColor = System.Drawing.Color.White;
            this.password.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.password.HoverState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(217, 174);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.SelectionStart = 8;
            this.password.ShadowDecoration.BorderRadius = 10;
            this.password.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(496, 44);
            this.password.TabIndex = 3;
            // 
            // firstname
            // 
            this.firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstname.Animated = true;
            this.firstname.AutoRoundedCorners = true;
            this.firstname.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.firstname.BackColor = System.Drawing.Color.Transparent;
            this.firstname.BorderColor = System.Drawing.Color.Black;
            this.firstname.BorderRadius = 21;
            this.firstname.BorderThickness = 2;
            this.firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname.DefaultText = "First name";
            this.firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstname.DisabledState.Parent = this.firstname;
            this.firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstname.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.firstname.FocusedState.Parent = this.firstname;
            this.firstname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstname.ForeColor = System.Drawing.Color.Gray;
            this.firstname.HoverState.BorderColor = System.Drawing.Color.White;
            this.firstname.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.firstname.HoverState.Parent = this.firstname;
            this.firstname.Location = new System.Drawing.Point(217, 236);
            this.firstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstname.Name = "firstname";
            this.firstname.PasswordChar = '\0';
            this.firstname.PlaceholderText = "";
            this.firstname.SelectedText = "";
            this.firstname.SelectionStart = 10;
            this.firstname.ShadowDecoration.BorderRadius = 10;
            this.firstname.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.firstname.ShadowDecoration.Parent = this.firstname;
            this.firstname.Size = new System.Drawing.Size(212, 44);
            this.firstname.TabIndex = 4;
            // 
            // lastname
            // 
            this.lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastname.Animated = true;
            this.lastname.AutoRoundedCorners = true;
            this.lastname.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lastname.BackColor = System.Drawing.Color.Transparent;
            this.lastname.BorderColor = System.Drawing.Color.Black;
            this.lastname.BorderRadius = 21;
            this.lastname.BorderThickness = 2;
            this.lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname.DefaultText = "Last name";
            this.lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastname.DisabledState.Parent = this.lastname;
            this.lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastname.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.lastname.FocusedState.Parent = this.lastname;
            this.lastname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastname.ForeColor = System.Drawing.Color.Gray;
            this.lastname.HoverState.BorderColor = System.Drawing.Color.White;
            this.lastname.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lastname.HoverState.Parent = this.lastname;
            this.lastname.Location = new System.Drawing.Point(494, 236);
            this.lastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastname.Name = "lastname";
            this.lastname.PasswordChar = '\0';
            this.lastname.PlaceholderText = "";
            this.lastname.SelectedText = "";
            this.lastname.SelectionStart = 9;
            this.lastname.ShadowDecoration.BorderRadius = 10;
            this.lastname.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.lastname.ShadowDecoration.Parent = this.lastname;
            this.lastname.Size = new System.Drawing.Size(219, 44);
            this.lastname.TabIndex = 5;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.Animated = true;
            this.email.AutoRoundedCorners = true;
            this.email.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.BorderColor = System.Drawing.Color.Black;
            this.email.BorderRadius = 21;
            this.email.BorderThickness = 2;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "Email";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.Parent = this.email;
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.email.FocusedState.Parent = this.email;
            this.email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email.ForeColor = System.Drawing.Color.Gray;
            this.email.HoverState.BorderColor = System.Drawing.Color.White;
            this.email.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.email.HoverState.Parent = this.email;
            this.email.Location = new System.Drawing.Point(217, 392);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "";
            this.email.SelectedText = "";
            this.email.SelectionStart = 5;
            this.email.ShadowDecoration.BorderRadius = 10;
            this.email.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.email.ShadowDecoration.Parent = this.email;
            this.email.Size = new System.Drawing.Size(496, 44);
            this.email.TabIndex = 6;
            // 
            // phonenumber
            // 
            this.phonenumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phonenumber.Animated = true;
            this.phonenumber.AutoRoundedCorners = true;
            this.phonenumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phonenumber.BackColor = System.Drawing.Color.Transparent;
            this.phonenumber.BorderColor = System.Drawing.Color.Black;
            this.phonenumber.BorderRadius = 21;
            this.phonenumber.BorderThickness = 2;
            this.phonenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonenumber.DefaultText = "phone number";
            this.phonenumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phonenumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phonenumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonenumber.DisabledState.Parent = this.phonenumber;
            this.phonenumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonenumber.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.phonenumber.FocusedState.Parent = this.phonenumber;
            this.phonenumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phonenumber.ForeColor = System.Drawing.Color.Gray;
            this.phonenumber.HoverState.BorderColor = System.Drawing.Color.White;
            this.phonenumber.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.phonenumber.HoverState.Parent = this.phonenumber;
            this.phonenumber.Location = new System.Drawing.Point(217, 455);
            this.phonenumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.PasswordChar = '\0';
            this.phonenumber.PlaceholderText = "";
            this.phonenumber.SelectedText = "";
            this.phonenumber.SelectionStart = 12;
            this.phonenumber.ShadowDecoration.BorderRadius = 10;
            this.phonenumber.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.phonenumber.ShadowDecoration.Parent = this.phonenumber;
            this.phonenumber.Size = new System.Drawing.Size(496, 44);
            this.phonenumber.TabIndex = 7;
            // 
            // ssn
            // 
            this.ssn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ssn.Animated = true;
            this.ssn.AutoRoundedCorners = true;
            this.ssn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ssn.BackColor = System.Drawing.Color.Transparent;
            this.ssn.BorderColor = System.Drawing.Color.Black;
            this.ssn.BorderRadius = 21;
            this.ssn.BorderThickness = 2;
            this.ssn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ssn.DefaultText = "Social security number";
            this.ssn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ssn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ssn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ssn.DisabledState.Parent = this.ssn;
            this.ssn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ssn.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.ssn.FocusedState.Parent = this.ssn;
            this.ssn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ssn.ForeColor = System.Drawing.Color.Gray;
            this.ssn.HoverState.BorderColor = System.Drawing.Color.White;
            this.ssn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ssn.HoverState.Parent = this.ssn;
            this.ssn.Location = new System.Drawing.Point(217, 330);
            this.ssn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ssn.Name = "ssn";
            this.ssn.PasswordChar = '\0';
            this.ssn.PlaceholderText = "";
            this.ssn.SelectedText = "";
            this.ssn.SelectionStart = 22;
            this.ssn.ShadowDecoration.BorderRadius = 10;
            this.ssn.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.ssn.ShadowDecoration.Parent = this.ssn;
            this.ssn.Size = new System.Drawing.Size(496, 44);
            this.ssn.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your name must be entered in English as it appears on your passport.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(45, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(821, 90);
            this.label3.TabIndex = 10;
            this.label3.Text = "Register\r\n               \r\n                                                      " +
    "          \r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // go
            // 
            this.go.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.go.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.go.CheckedState.Parent = this.go;
            this.go.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.go.HoverState.Parent = this.go;
            this.go.Image = ((System.Drawing.Image)(resources.GetObject("go.Image")));
            this.go.ImageRotate = 0F;
            this.go.Location = new System.Drawing.Point(802, 482);
            this.go.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go.Name = "go";
            this.go.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.go.PressedState.Parent = this.go;
            this.go.Size = new System.Drawing.Size(64, 54);
            this.go.TabIndex = 11;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // JoinNowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 549);
            this.Controls.Add(this.go);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JoinNowForm";
            this.Text = "Join Now";
            this.Load += new System.EventHandler(this.JoinNowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox firstname;
        private Guna.UI2.WinForms.Guna2TextBox lastname;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2TextBox phonenumber;
        private Guna.UI2.WinForms.Guna2TextBox ssn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton go;
    }
}