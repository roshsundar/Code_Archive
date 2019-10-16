namespace ticTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTurnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oWinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xWinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topLeft = new System.Windows.Forms.Button();
            this.centerLeft = new System.Windows.Forms.Button();
            this.bottomLeft = new System.Windows.Forms.Button();
            this.topCenter = new System.Windows.Forms.Button();
            this.topRight = new System.Windows.Forms.Button();
            this.center = new System.Windows.Forms.Button();
            this.centerRight = new System.Windows.Forms.Button();
            this.bottomCenter = new System.Windows.Forms.Button();
            this.bottomRight = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(231, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.currentTurnToolStripMenuItem,
            this.oWinsToolStripMenuItem,
            this.xWinsToolStripMenuItem,
            this.drawsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // currentTurnToolStripMenuItem
            // 
            this.currentTurnToolStripMenuItem.Name = "currentTurnToolStripMenuItem";
            this.currentTurnToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.currentTurnToolStripMenuItem.Text = "Current Turn";
            this.currentTurnToolStripMenuItem.Click += new System.EventHandler(this.currentTurnToolStripMenuItem_Click);
            // 
            // oWinsToolStripMenuItem
            // 
            this.oWinsToolStripMenuItem.Name = "oWinsToolStripMenuItem";
            this.oWinsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.oWinsToolStripMenuItem.Text = "O wins";
            this.oWinsToolStripMenuItem.Click += new System.EventHandler(this.oWinsToolStripMenuItem_Click);
            // 
            // xWinsToolStripMenuItem
            // 
            this.xWinsToolStripMenuItem.Name = "xWinsToolStripMenuItem";
            this.xWinsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.xWinsToolStripMenuItem.Text = "X wins";
            this.xWinsToolStripMenuItem.Click += new System.EventHandler(this.xWinsToolStripMenuItem_Click);
            // 
            // drawsToolStripMenuItem
            // 
            this.drawsToolStripMenuItem.Name = "drawsToolStripMenuItem";
            this.drawsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.drawsToolStripMenuItem.Text = "Draws";
            this.drawsToolStripMenuItem.Click += new System.EventHandler(this.drawsToolStripMenuItem_Click);
            // 
            // topLeft
            // 
            this.topLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeft.Location = new System.Drawing.Point(12, 44);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(64, 64);
            this.topLeft.TabIndex = 1;
            this.topLeft.UseVisualStyleBackColor = true;
            this.topLeft.Click += new System.EventHandler(this.button_click);
            // 
            // centerLeft
            // 
            this.centerLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerLeft.Location = new System.Drawing.Point(12, 114);
            this.centerLeft.Name = "centerLeft";
            this.centerLeft.Size = new System.Drawing.Size(64, 64);
            this.centerLeft.TabIndex = 2;
            this.centerLeft.UseVisualStyleBackColor = true;
            this.centerLeft.Click += new System.EventHandler(this.button_click);
            // 
            // bottomLeft
            // 
            this.bottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLeft.Location = new System.Drawing.Point(12, 184);
            this.bottomLeft.Name = "bottomLeft";
            this.bottomLeft.Size = new System.Drawing.Size(64, 64);
            this.bottomLeft.TabIndex = 3;
            this.bottomLeft.UseVisualStyleBackColor = true;
            this.bottomLeft.Click += new System.EventHandler(this.button_click);
            // 
            // topCenter
            // 
            this.topCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topCenter.Location = new System.Drawing.Point(82, 44);
            this.topCenter.Name = "topCenter";
            this.topCenter.Size = new System.Drawing.Size(64, 64);
            this.topCenter.TabIndex = 4;
            this.topCenter.UseVisualStyleBackColor = true;
            this.topCenter.Click += new System.EventHandler(this.button_click);
            // 
            // topRight
            // 
            this.topRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRight.Location = new System.Drawing.Point(152, 44);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(64, 64);
            this.topRight.TabIndex = 5;
            this.topRight.UseVisualStyleBackColor = true;
            this.topRight.Click += new System.EventHandler(this.button_click);
            // 
            // center
            // 
            this.center.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center.Location = new System.Drawing.Point(82, 114);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(64, 64);
            this.center.TabIndex = 6;
            this.center.UseVisualStyleBackColor = true;
            this.center.Click += new System.EventHandler(this.button_click);
            // 
            // centerRight
            // 
            this.centerRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerRight.Location = new System.Drawing.Point(152, 114);
            this.centerRight.Name = "centerRight";
            this.centerRight.Size = new System.Drawing.Size(64, 64);
            this.centerRight.TabIndex = 7;
            this.centerRight.UseVisualStyleBackColor = true;
            this.centerRight.Click += new System.EventHandler(this.button_click);
            // 
            // bottomCenter
            // 
            this.bottomCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomCenter.Location = new System.Drawing.Point(82, 184);
            this.bottomCenter.Name = "bottomCenter";
            this.bottomCenter.Size = new System.Drawing.Size(64, 64);
            this.bottomCenter.TabIndex = 8;
            this.bottomCenter.UseVisualStyleBackColor = true;
            this.bottomCenter.Click += new System.EventHandler(this.button_click);
            // 
            // bottomRight
            // 
            this.bottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomRight.Location = new System.Drawing.Point(152, 184);
            this.bottomRight.Name = "bottomRight";
            this.bottomRight.Size = new System.Drawing.Size(64, 64);
            this.bottomRight.TabIndex = 9;
            this.bottomRight.UseVisualStyleBackColor = true;
            this.bottomRight.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 261);
            this.Controls.Add(this.bottomRight);
            this.Controls.Add(this.bottomCenter);
            this.Controls.Add(this.centerRight);
            this.Controls.Add(this.center);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.topCenter);
            this.Controls.Add(this.bottomLeft);
            this.Controls.Add(this.centerLeft);
            this.Controls.Add(this.topLeft);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button topLeft;
        private System.Windows.Forms.Button centerLeft;
        private System.Windows.Forms.Button bottomLeft;
        private System.Windows.Forms.Button topCenter;
        private System.Windows.Forms.Button topRight;
        private System.Windows.Forms.Button center;
        private System.Windows.Forms.Button centerRight;
        private System.Windows.Forms.Button bottomCenter;
        private System.Windows.Forms.Button bottomRight;
        private System.Windows.Forms.ToolStripMenuItem currentTurnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oWinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xWinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawsToolStripMenuItem;
    }
}

