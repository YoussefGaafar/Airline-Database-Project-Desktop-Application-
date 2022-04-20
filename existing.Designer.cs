
namespace Airline
{
    partial class existing
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
            this.reservationNO = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.booking1 = new Guna.UI2.WinForms.Guna2Button();
            this.Reserve = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reservationNO
            // 
            this.reservationNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reservationNO.DefaultText = "";
            this.reservationNO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reservationNO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reservationNO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reservationNO.DisabledState.Parent = this.reservationNO;
            this.reservationNO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reservationNO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reservationNO.FocusedState.Parent = this.reservationNO;
            this.reservationNO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reservationNO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reservationNO.HoverState.Parent = this.reservationNO;
            this.reservationNO.Location = new System.Drawing.Point(258, 60);
            this.reservationNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationNO.Name = "reservationNO";
            this.reservationNO.PasswordChar = '\0';
            this.reservationNO.PlaceholderText = "";
            this.reservationNO.SelectedText = "";
            this.reservationNO.ShadowDecoration.Parent = this.reservationNO;
            this.reservationNO.Size = new System.Drawing.Size(302, 25);
            this.reservationNO.TabIndex = 0;
            this.reservationNO.TextChanged += new System.EventHandler(this.reservationNO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "please enter reservation number";
            // 
            // booking1
            // 
            this.booking1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.booking1.Animated = true;
            this.booking1.AutoRoundedCorners = true;
            this.booking1.BorderRadius = 13;
            this.booking1.CheckedState.Parent = this.booking1;
            this.booking1.CustomImages.Parent = this.booking1;
            this.booking1.FillColor = System.Drawing.Color.Firebrick;
            this.booking1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.booking1.ForeColor = System.Drawing.Color.White;
            this.booking1.HoverState.Parent = this.booking1;
            this.booking1.Location = new System.Drawing.Point(584, 60);
            this.booking1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.booking1.Name = "booking1";
            this.booking1.ShadowDecoration.Parent = this.booking1;
            this.booking1.Size = new System.Drawing.Size(125, 29);
            this.booking1.TabIndex = 2;
            this.booking1.Text = "ENTER";
            this.booking1.Click += new System.EventHandler(this.booking1_Click);
            // 
            // Reserve
            // 
            this.Reserve.Location = new System.Drawing.Point(488, 189);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(221, 23);
            this.Reserve.TabIndex = 3;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client Username";
            // 
            // existing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Reserve);
            this.Controls.Add(this.booking1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservationNO);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "existing";
            this.Text = "existing";
            this.Load += new System.EventHandler(this.existing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox reservationNO;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button booking1;
        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}