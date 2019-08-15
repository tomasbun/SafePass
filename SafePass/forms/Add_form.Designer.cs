namespace SafePass
{
    partial class Add_form
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.safepass_lbl = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Transparent;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.DimGray;
            this.cancel_btn.Location = new System.Drawing.Point(36, 257);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(262, 42);
            this.cancel_btn.TabIndex = 14;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.name_txtbox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.password_txtbox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.username_txtbox);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(36, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 124);
            this.panel1.TabIndex = 16;
            // 
            // name_txtbox
            // 
            this.name_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_txtbox.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.name_txtbox.Location = new System.Drawing.Point(5, 6);
            this.name_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_txtbox.Multiline = true;
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(245, 30);
            this.name_txtbox.TabIndex = 2;
            this.name_txtbox.TabStop = false;
            this.name_txtbox.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(8, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 1);
            this.panel3.TabIndex = 12;
            // 
            // password_txtbox
            // 
            this.password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txtbox.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.password_txtbox.Location = new System.Drawing.Point(5, 88);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_txtbox.Multiline = true;
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(248, 30);
            this.password_txtbox.TabIndex = 1;
            this.password_txtbox.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(8, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 1);
            this.panel2.TabIndex = 7;
            // 
            // username_txtbox
            // 
            this.username_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txtbox.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.username_txtbox.Location = new System.Drawing.Point(5, 48);
            this.username_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_txtbox.Multiline = true;
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(248, 30);
            this.username_txtbox.TabIndex = 0;
            this.username_txtbox.Text = "Username";
            // 
            // safepass_lbl
            // 
            this.safepass_lbl.AutoSize = true;
            this.safepass_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safepass_lbl.ForeColor = System.Drawing.Color.Teal;
            this.safepass_lbl.Location = new System.Drawing.Point(84, 12);
            this.safepass_lbl.Name = "safepass_lbl";
            this.safepass_lbl.Size = new System.Drawing.Size(170, 58);
            this.safepass_lbl.TabIndex = 15;
            this.safepass_lbl.Text = "SafePass";
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.Teal;
            this.confirm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.ForeColor = System.Drawing.Color.White;
            this.confirm_btn.Location = new System.Drawing.Point(36, 214);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(262, 42);
            this.confirm_btn.TabIndex = 13;
            this.confirm_btn.Text = "Add";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // Add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.safepass_lbl);
            this.Controls.Add(this.confirm_btn);
            this.Name = "Add_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.Label safepass_lbl;
        private System.Windows.Forms.Button confirm_btn;
    }
}