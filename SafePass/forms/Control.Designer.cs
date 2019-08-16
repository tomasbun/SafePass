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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.current_user_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.exit_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.search_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.records_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(12, 98);
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
            // current_user_lbl
            // 
            this.current_user_lbl.AutoSize = true;
            this.current_user_lbl.BackColor = System.Drawing.Color.Transparent;
            this.current_user_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_user_lbl.ForeColor = System.Drawing.Color.Black;
            this.current_user_lbl.Location = new System.Drawing.Point(10, 65);
            this.current_user_lbl.Name = "current_user_lbl";
            this.current_user_lbl.Size = new System.Drawing.Size(80, 16);
            this.current_user_lbl.TabIndex = 19;
            this.current_user_lbl.Text = "Logged in as : ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(163, 66);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // exit_btn
            // 
            this.exit_btn.Depth = 0;
            this.exit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_btn.Location = new System.Drawing.Point(330, 332);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 23;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // search_txtbox
            // 
            this.search_txtbox.Depth = 0;
            this.search_txtbox.ForeColor = System.Drawing.Color.DimGray;
            this.search_txtbox.Hint = "";
            this.search_txtbox.Location = new System.Drawing.Point(246, 69);
            this.search_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.PasswordChar = '\0';
            this.search_txtbox.SelectedText = "";
            this.search_txtbox.SelectionLength = 0;
            this.search_txtbox.SelectionStart = 0;
            this.search_txtbox.Size = new System.Drawing.Size(464, 23);
            this.search_txtbox.TabIndex = 27;
            this.search_txtbox.Text = "Search";
            this.search_txtbox.UseSystemPasswordChar = false;
            this.search_txtbox.Click += new System.EventHandler(this.search_txtbox_Click);
            this.search_txtbox.TextChanged += new System.EventHandler(this.search_txtbox_TextChanged);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_btn.FlatAppearance.BorderSize = 0;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(589, 39);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(1);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(38, 23);
            this.Add_btn.TabIndex = 28;
            this.Add_btn.Text = "&ADD";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(619, 39);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(1);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(56, 23);
            this.Delete_btn.TabIndex = 29;
            this.Delete_btn.Text = "&DELETE";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.BackColor = System.Drawing.Color.Transparent;
            this.open_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_btn.FlatAppearance.BorderSize = 0;
            this.open_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_btn.ForeColor = System.Drawing.Color.White;
            this.open_btn.Location = new System.Drawing.Point(670, 39);
            this.open_btn.Margin = new System.Windows.Forms.Padding(1);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(44, 23);
            this.open_btn.TabIndex = 30;
            this.open_btn.Text = "&OPEN";
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // records_lbl
            // 
            this.records_lbl.AutoSize = true;
            this.records_lbl.BackColor = System.Drawing.Color.Transparent;
            this.records_lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records_lbl.ForeColor = System.Drawing.Color.Black;
            this.records_lbl.Location = new System.Drawing.Point(10, 80);
            this.records_lbl.Name = "records_lbl";
            this.records_lbl.Size = new System.Drawing.Size(80, 16);
            this.records_lbl.TabIndex = 31;
            this.records_lbl.Text = "Total records: ";
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.exit_btn;
            this.ClientSize = new System.Drawing.Size(722, 363);
            this.Controls.Add(this.records_lbl);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.search_txtbox);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.current_user_lbl);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label current_user_lbl;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialRaisedButton exit_btn;
        private MaterialSkin.Controls.MaterialSingleLineTextField search_txtbox;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Label records_lbl;
    }
}