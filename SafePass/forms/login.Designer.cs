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
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.safepass_lbl = new System.Windows.Forms.Label();
            this.register_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_txtbox
            // 
            this.username_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txtbox.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.username_txtbox.Location = new System.Drawing.Point(40, 5);
            this.username_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_txtbox.Multiline = true;
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(221, 35);
            this.username_txtbox.TabIndex = 1;
            this.username_txtbox.Text = "Username";
            this.toolTip1.SetToolTip(this.username_txtbox, "Click register if You dont have username yet");
            this.username_txtbox.Click += new System.EventHandler(this.username_txtbox_Click);
            // 
            // password_txtbox
            // 
            this.password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txtbox.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.password_txtbox.Location = new System.Drawing.Point(40, 47);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_txtbox.Multiline = true;
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(221, 36);
            this.password_txtbox.TabIndex = 2;
            this.password_txtbox.Text = "Password";
            this.toolTip1.SetToolTip(this.password_txtbox, "Password must contain a number, special character and at leas one capital");
            this.password_txtbox.Click += new System.EventHandler(this.password_txtbox_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Teal;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(33, 214);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(262, 42);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.password_txtbox);
            this.panel1.Controls.Add(this.username_txtbox);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(33, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 84);
            this.panel1.TabIndex = 6;
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(8, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 1);
            this.panel2.TabIndex = 7;
            // 
            // safepass_lbl
            // 
            this.safepass_lbl.AutoSize = true;
            this.safepass_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safepass_lbl.ForeColor = System.Drawing.Color.Teal;
            this.safepass_lbl.Location = new System.Drawing.Point(81, 12);
            this.safepass_lbl.Name = "safepass_lbl";
            this.safepass_lbl.Size = new System.Drawing.Size(170, 58);
            this.safepass_lbl.TabIndex = 7;
            this.safepass_lbl.Text = "SafePass";
            // 
            // register_lbl
            // 
            this.register_lbl.AutoSize = true;
            this.register_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.register_lbl.Location = new System.Drawing.Point(131, 264);
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(63, 23);
            this.register_lbl.TabIndex = 4;
            this.register_lbl.Text = "Register";
            this.toolTip1.SetToolTip(this.register_lbl, "Create new profile");
            this.register_lbl.Click += new System.EventHandler(this.register_lbl_Click);
            this.register_lbl.MouseLeave += new System.EventHandler(this.register_lbl_MouseLeave);
            this.register_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.register_lbl_MouseMove);
            // 
            // login
            // 
            this.AcceptButton = this.login_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.register_lbl);
            this.Controls.Add(this.safepass_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login_btn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "login";
            this.Text = "SafePass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label safepass_lbl;
        private System.Windows.Forms.Label register_lbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

