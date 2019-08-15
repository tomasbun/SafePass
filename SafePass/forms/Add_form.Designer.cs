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
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.confirm_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(36, 77);
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
            this.name_txtbox.TabIndex = 0;
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
            this.password_txtbox.TabIndex = 2;
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
            this.username_txtbox.TabIndex = 1;
            this.username_txtbox.Text = "Username";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Depth = 0;
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(36, 265);
            this.cancel_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Primary = true;
            this.cancel_btn.Size = new System.Drawing.Size(262, 23);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.TabStop = false;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Depth = 0;
            this.confirm_btn.Location = new System.Drawing.Point(36, 216);
            this.confirm_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Primary = true;
            this.confirm_btn.Size = new System.Drawing.Size(262, 42);
            this.confirm_btn.TabIndex = 3;
            this.confirm_btn.TabStop = false;
            this.confirm_btn.Text = "Add";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // Add_form
            // 
            this.AcceptButton = this.confirm_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Add_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox username_txtbox;
        private MaterialSkin.Controls.MaterialRaisedButton cancel_btn;
        private MaterialSkin.Controls.MaterialRaisedButton confirm_btn;
    }
}