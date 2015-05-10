namespace ZGrafika
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
            this.Open_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Menu_Pnl = new System.Windows.Forms.Panel();
            this.WorkArea = new System.Windows.Forms.PictureBox();
            this.Menu_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkArea)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_Btn
            // 
            this.Open_Btn.Location = new System.Drawing.Point(3, 3);
            this.Open_Btn.Name = "Open_Btn";
            this.Open_Btn.Size = new System.Drawing.Size(75, 23);
            this.Open_Btn.TabIndex = 0;
            this.Open_Btn.Text = "Open";
            this.Open_Btn.UseVisualStyleBackColor = true;
            this.Open_Btn.Click += new System.EventHandler(this.Open_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(84, 3);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(75, 23);
            this.Save_Btn.TabIndex = 1;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Menu_Pnl
            // 
            this.Menu_Pnl.Controls.Add(this.Open_Btn);
            this.Menu_Pnl.Controls.Add(this.Save_Btn);
            this.Menu_Pnl.Location = new System.Drawing.Point(12, 12);
            this.Menu_Pnl.Name = "Menu_Pnl";
            this.Menu_Pnl.Size = new System.Drawing.Size(260, 26);
            this.Menu_Pnl.TabIndex = 2;
            // 
            // WorkArea
            // 
            this.WorkArea.Location = new System.Drawing.Point(15, 45);
            this.WorkArea.Name = "WorkArea";
            this.WorkArea.Size = new System.Drawing.Size(257, 205);
            this.WorkArea.TabIndex = 3;
            this.WorkArea.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.WorkArea);
            this.Controls.Add(this.Menu_Pnl);
            this.Name = "Form1";
            this.Text = "ZieluPaint";
            this.Menu_Pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Panel Menu_Pnl;
        private System.Windows.Forms.PictureBox WorkArea;
    }
}

