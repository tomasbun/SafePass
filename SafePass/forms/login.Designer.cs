namespace SafePass
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.button1 = new System.Windows.Forms.Button();
            this.safepass_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.repeat_password_txtbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // safepass_lbl
            // 
            this.safepass_lbl.AutoSize = true;
            this.safepass_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safepass_lbl.ForeColor = System.Drawing.Color.White;
            this.safepass_lbl.Location = new System.Drawing.Point(4, 6);
            this.safepass_lbl.Name = "safepass_lbl";
            this.safepass_lbl.Size = new System.Drawing.Size(129, 45);
            this.safepass_lbl.TabIndex = 7;
            this.safepass_lbl.Text = "SafePass";
            // 
            // password_txtbox
            // 
            this.password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txtbox.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.password_txtbox.Location = new System.Drawing.Point(40, 48);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_txtbox.Multiline = true;
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(213, 30);
            this.password_txtbox.TabIndex = 1;
            this.password_txtbox.Text = "Password";
            this.toolTip1.SetToolTip(this.password_txtbox, "Must contain at least 6 characters and a number");
            this.password_txtbox.Enter += new System.EventHandler(this.password_txtbox_Enter);
            // 
            // username_txtbox
            // 
            this.username_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txtbox.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.username_txtbox.Location = new System.Drawing.Point(40, 7);
            this.username_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_txtbox.Multiline = true;
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(213, 30);
            this.username_txtbox.TabIndex = 0;
            this.username_txtbox.Text = "Username";
            this.toolTip1.SetToolTip(this.username_txtbox, "Must be at least 8 characters long");
            this.username_txtbox.Enter += new System.EventHandler(this.username_txtbox_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.repeat_password_txtbox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.password_txtbox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.username_txtbox);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(36, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 84);
            this.panel1.TabIndex = 12;
            // 
            // repeat_password_txtbox
            // 
            this.repeat_password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeat_password_txtbox.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeat_password_txtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.repeat_password_txtbox.Location = new System.Drawing.Point(40, 89);
            this.repeat_password_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repeat_password_txtbox.Multiline = true;
            this.repeat_password_txtbox.Name = "repeat_password_txtbox";
            this.repeat_password_txtbox.Size = new System.Drawing.Size(213, 30);
            this.repeat_password_txtbox.TabIndex = 2;
            this.repeat_password_txtbox.TabStop = false;
            this.repeat_password_txtbox.Text = "Repeat password";
            this.repeat_password_txtbox.Enter += new System.EventHandler(this.repeat_password_txtbox_Enter);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(8, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 1);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Password");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Username");
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(8, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 1);
            this.panel2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(36, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.safepass_lbl);
            this.panel4.Location = new System.Drawing.Point(1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 60);
            this.panel4.TabIndex = 13;
            // 
            // login
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafePass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label safepass_lbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox repeat_password_txtbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
    }
}

