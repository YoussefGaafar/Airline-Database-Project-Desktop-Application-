
namespace Airline
{
    partial class forgetpassword
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
            this.userforget = new Guna.UI2.WinForms.Guna2TextBox();
            this.send = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userforget
            // 
            this.userforget.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userforget.Animated = true;
            this.userforget.AutoRoundedCorners = true;
            this.userforget.BorderRadius = 16;
            this.userforget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userforget.DefaultText = "";
            this.userforget.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userforget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userforget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userforget.DisabledState.Parent = this.userforget;
            this.userforget.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userforget.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userforget.FocusedState.Parent = this.userforget;
            this.userforget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userforget.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userforget.HoverState.Parent = this.userforget;
            this.userforget.Location = new System.Drawing.Point(217, 151);
            this.userforget.Name = "userforget";
            this.userforget.PasswordChar = '\0';
            this.userforget.PlaceholderText = "";
            this.userforget.SelectedText = "";
            this.userforget.ShadowDecoration.Parent = this.userforget;
            this.userforget.Size = new System.Drawing.Size(382, 34);
            this.userforget.TabIndex = 0;
            this.userforget.TextChanged += new System.EventHandler(this.userforget_TextChanged);
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send.Animated = true;
            this.send.AutoRoundedCorners = true;
            this.send.BorderRadius = 25;
            this.send.CheckedState.Parent = this.send;
            this.send.CustomImages.Parent = this.send;
            this.send.FillColor = System.Drawing.Color.Red;
            this.send.FillColor2 = System.Drawing.Color.Black;
            this.send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.HoverState.Parent = this.send;
            this.send.IndicateFocus = true;
            this.send.Location = new System.Drawing.Point(575, 296);
            this.send.Name = "send";
            this.send.ShadowDecoration.Parent = this.send;
            this.send.Size = new System.Drawing.Size(213, 53);
            this.send.TabIndex = 1;
            this.send.Text = "Send password";
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please write your email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // forgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.userforget);
            this.Name = "forgetpassword";
            this.Text = "forget password";
            this.Load += new System.EventHandler(this.forgetpassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox userforget;
        private Guna.UI2.WinForms.Guna2GradientButton send;
        private System.Windows.Forms.Label label1;
    }
}