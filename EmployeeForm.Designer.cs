
namespace Airline
{
    partial class EmployeeForm
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
            this.booking1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // booking1
            // 
            this.booking1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.booking1.Animated = true;
            this.booking1.AutoRoundedCorners = true;
            this.booking1.BorderRadius = 17;
            this.booking1.CheckedState.Parent = this.booking1;
            this.booking1.CustomImages.Parent = this.booking1;
            this.booking1.FillColor = System.Drawing.Color.Firebrick;
            this.booking1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.booking1.ForeColor = System.Drawing.Color.White;
            this.booking1.HoverState.Parent = this.booking1;
            this.booking1.Location = new System.Drawing.Point(364, 116);
            this.booking1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.booking1.Name = "booking1";
            this.booking1.ShadowDecoration.Parent = this.booking1;
            this.booking1.Size = new System.Drawing.Size(239, 36);
            this.booking1.TabIndex = 0;
            this.booking1.Text = "Booking For Existing User";
            this.booking1.Click += new System.EventHandler(this.booking1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 17;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Firebrick;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(364, 190);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(239, 36);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Booking For New User";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(956, 410);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.booking1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button booking1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}