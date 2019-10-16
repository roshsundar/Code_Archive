namespace remindMe
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.launchAdd_btn = new System.Windows.Forms.Button();
            this.remListbox = new System.Windows.Forms.ListBox();
            this.launchOpen_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.editRem_btn = new System.Windows.Forms.Button();
            this.delRem_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // launchAdd_btn
            // 
            this.launchAdd_btn.Location = new System.Drawing.Point(12, 137);
            this.launchAdd_btn.Name = "launchAdd_btn";
            this.launchAdd_btn.Size = new System.Drawing.Size(141, 23);
            this.launchAdd_btn.TabIndex = 0;
            this.launchAdd_btn.Text = "Add New Reminder";
            this.launchAdd_btn.UseVisualStyleBackColor = true;
            this.launchAdd_btn.Click += new System.EventHandler(this.launchAdd_btn_Click);
            // 
            // remListbox
            // 
            this.remListbox.FormattingEnabled = true;
            this.remListbox.Location = new System.Drawing.Point(12, 36);
            this.remListbox.Name = "remListbox";
            this.remListbox.Size = new System.Drawing.Size(357, 95);
            this.remListbox.TabIndex = 1;
            // 
            // launchOpen_btn
            // 
            this.launchOpen_btn.Location = new System.Drawing.Point(12, 166);
            this.launchOpen_btn.Name = "launchOpen_btn";
            this.launchOpen_btn.Size = new System.Drawing.Size(141, 23);
            this.launchOpen_btn.TabIndex = 2;
            this.launchOpen_btn.Text = "Open Selected Reminder";
            this.launchOpen_btn.UseVisualStyleBackColor = true;
            this.launchOpen_btn.Click += new System.EventHandler(this.launchOpen_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(228, 137);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(141, 23);
            this.refresh_btn.TabIndex = 3;
            this.refresh_btn.Text = "Refresh Reminder List";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Search:";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(90, 14);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(279, 20);
            this.searchBar.TabIndex = 5;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // editRem_btn
            // 
            this.editRem_btn.Location = new System.Drawing.Point(12, 195);
            this.editRem_btn.Name = "editRem_btn";
            this.editRem_btn.Size = new System.Drawing.Size(141, 23);
            this.editRem_btn.TabIndex = 6;
            this.editRem_btn.Text = "Edit Selected Reminder";
            this.editRem_btn.UseVisualStyleBackColor = true;
            this.editRem_btn.Click += new System.EventHandler(this.editRem_btn_Click);
            // 
            // delRem_btn
            // 
            this.delRem_btn.Location = new System.Drawing.Point(12, 224);
            this.delRem_btn.Name = "delRem_btn";
            this.delRem_btn.Size = new System.Drawing.Size(141, 23);
            this.delRem_btn.TabIndex = 7;
            this.delRem_btn.Text = "Delete Selected Reminder";
            this.delRem_btn.UseVisualStyleBackColor = true;
            this.delRem_btn.Click += new System.EventHandler(this.delRem_btn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 275);
            this.Controls.Add(this.delRem_btn);
            this.Controls.Add(this.editRem_btn);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.launchOpen_btn);
            this.Controls.Add(this.remListbox);
            this.Controls.Add(this.launchAdd_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Reminders";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchAdd_btn;
        private System.Windows.Forms.ListBox remListbox;
        private System.Windows.Forms.Button launchOpen_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button editRem_btn;
        private System.Windows.Forms.Button delRem_btn;
    }
}

