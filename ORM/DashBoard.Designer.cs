namespace ORM
{
    partial class DashBoard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerateException = new System.Windows.Forms.Button();
            this.panlContainer = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnGenerateException);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 551);
            this.panel2.TabIndex = 1;
            // 
            // btnGenerateException
            // 
            this.btnGenerateException.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateException.Location = new System.Drawing.Point(0, 0);
            this.btnGenerateException.Name = "btnGenerateException";
            this.btnGenerateException.Size = new System.Drawing.Size(156, 46);
            this.btnGenerateException.TabIndex = 0;
            this.btnGenerateException.Text = "Generate Exception";
            this.btnGenerateException.UseVisualStyleBackColor = true;
            this.btnGenerateException.Click += new System.EventHandler(this.btnGenerateException_Click);
            // 
            // panlContainer
            // 
            this.panlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panlContainer.Location = new System.Drawing.Point(160, 70);
            this.panlContainer.Name = "panlContainer";
            this.panlContainer.Size = new System.Drawing.Size(1007, 551);
            this.panlContainer.TabIndex = 2;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 621);
            this.Controls.Add(this.panlContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.Text = "ORM DashBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashBoard_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenerateException;
        private System.Windows.Forms.Panel panlContainer;
    }
}

