namespace simplePaint
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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.penSize_Entry = new System.Windows.Forms.TextBox();
            this.color_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(12, 12);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(723, 273);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pen Size:";
            // 
            // penSize_Entry
            // 
            this.penSize_Entry.Location = new System.Drawing.Point(67, 295);
            this.penSize_Entry.Name = "penSize_Entry";
            this.penSize_Entry.Size = new System.Drawing.Size(28, 20);
            this.penSize_Entry.TabIndex = 1;
            // 
            // color_btn
            // 
            this.color_btn.Location = new System.Drawing.Point(101, 293);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(83, 23);
            this.color_btn.TabIndex = 2;
            this.color_btn.Text = "Change Color";
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(190, 293);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(83, 23);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "Clear Canvas";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 340);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.color_btn);
            this.Controls.Add(this.penSize_Entry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawingPanel);
            this.Name = "mainForm";
            this.Text = "Simple Paint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox penSize_Entry;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}

