namespace remindMe
{
    partial class editForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectEntry = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.saveRem_btn = new System.Windows.Forms.Button();
            this.remEntry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter Reminder Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter Reminder Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter Reminder Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter Reminder Subject:";
            // 
            // subjectEntry
            // 
            this.subjectEntry.Location = new System.Drawing.Point(134, 6);
            this.subjectEntry.Name = "subjectEntry";
            this.subjectEntry.Size = new System.Drawing.Size(141, 20);
            this.subjectEntry.TabIndex = 15;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(127, 203);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 14;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(127, 228);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(200, 20);
            this.timePicker.TabIndex = 13;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(15, 276);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(106, 23);
            this.cancel_btn.TabIndex = 12;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // saveRem_btn
            // 
            this.saveRem_btn.Location = new System.Drawing.Point(15, 247);
            this.saveRem_btn.Name = "saveRem_btn";
            this.saveRem_btn.Size = new System.Drawing.Size(106, 23);
            this.saveRem_btn.TabIndex = 11;
            this.saveRem_btn.Text = "Save Reminder";
            this.saveRem_btn.UseVisualStyleBackColor = true;
            this.saveRem_btn.Click += new System.EventHandler(this.saveRem_btn_Click);
            // 
            // remEntry
            // 
            this.remEntry.AcceptsTab = true;
            this.remEntry.Location = new System.Drawing.Point(15, 58);
            this.remEntry.Multiline = true;
            this.remEntry.Name = "remEntry";
            this.remEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.remEntry.Size = new System.Drawing.Size(312, 139);
            this.remEntry.TabIndex = 10;
            this.remEntry.WordWrap = false;
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 322);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectEntry);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.saveRem_btn);
            this.Controls.Add(this.remEntry);
            this.Name = "editForm";
            this.ShowIcon = false;
            this.Text = "Edit Reminder";
            this.Load += new System.EventHandler(this.editForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectEntry;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button saveRem_btn;
        private System.Windows.Forms.TextBox remEntry;
    }
}