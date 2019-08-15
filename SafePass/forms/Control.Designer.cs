namespace SafePass
{
    partial class Control
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
            this.safepass_lbl = new System.Windows.Forms.Label();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Add_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.current_user_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.open_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // safepass_lbl
            // 
            this.safepass_lbl.AutoSize = true;
            this.safepass_lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safepass_lbl.ForeColor = System.Drawing.Color.Teal;
            this.safepass_lbl.Location = new System.Drawing.Point(312, 20);
            this.safepass_lbl.Name = "safepass_lbl";
            this.safepass_lbl.Size = new System.Drawing.Size(170, 58);
            this.safepass_lbl.TabIndex = 8;
            this.safepass_lbl.Text = "SafePass";
            // 
            // search_txtbox
            // 
            this.search_txtbox.Location = new System.Drawing.Point(52, 111);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(513, 20);
            this.search_txtbox.TabIndex = 10;
            this.search_txtbox.TextChanged += new System.EventHandler(this.search_txtbox_TextChanged);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.username,
            this.password});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(52, 148);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(699, 230);
            this.listView1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.listView1, "Right click to edit");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 233;
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 233;
            // 
            // password
            // 
            this.password.Text = "Password";
            this.password.Width = 233;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.Teal;
            this.Add_btn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(52, 385);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(99, 39);
            this.Add_btn.TabIndex = 16;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Teal;
            this.Delete_btn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(157, 385);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(99, 39);
            this.Delete_btn.TabIndex = 17;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Teal;
            this.exit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_btn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(651, 384);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(99, 39);
            this.exit_btn.TabIndex = 18;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // current_user_lbl
            // 
            this.current_user_lbl.AutoSize = true;
            this.current_user_lbl.Location = new System.Drawing.Point(52, 20);
            this.current_user_lbl.Name = "current_user_lbl";
            this.current_user_lbl.Size = new System.Drawing.Size(71, 13);
            this.current_user_lbl.TabIndex = 19;
            this.current_user_lbl.Text = "Logged in as ";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Teal;
            this.search_btn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(571, 107);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(179, 27);
            this.search_btn.TabIndex = 20;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // open_btn
            // 
            this.open_btn.BackColor = System.Drawing.Color.Teal;
            this.open_btn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_btn.ForeColor = System.Drawing.Color.White;
            this.open_btn.Location = new System.Drawing.Point(262, 384);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(99, 39);
            this.open_btn.TabIndex = 21;
            this.open_btn.Text = "Open file";
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.exit_btn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.current_user_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.search_txtbox);
            this.Controls.Add(this.safepass_lbl);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label safepass_lbl;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label current_user_lbl;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button open_btn;
    }
}