namespace ORM.Generate_Exception
{
    partial class ExceptionForm
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
            this.btnBarCodeExcpt = new System.Windows.Forms.Button();
            this.btnShiftExcpt = new System.Windows.Forms.Button();
            this.btnRollNoExcpt = new System.Windows.Forms.Button();
            this.btnPaperCodeExcpt = new System.Windows.Forms.Button();
            this.btnSheetNoExcpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBarCodeExcpt
            // 
            this.btnBarCodeExcpt.Location = new System.Drawing.Point(88, 39);
            this.btnBarCodeExcpt.Name = "btnBarCodeExcpt";
            this.btnBarCodeExcpt.Size = new System.Drawing.Size(189, 47);
            this.btnBarCodeExcpt.TabIndex = 0;
            this.btnBarCodeExcpt.Text = "Generate BarCode Exception";
            this.btnBarCodeExcpt.UseVisualStyleBackColor = true;
            // 
            // btnShiftExcpt
            // 
            this.btnShiftExcpt.Location = new System.Drawing.Point(88, 293);
            this.btnShiftExcpt.Name = "btnShiftExcpt";
            this.btnShiftExcpt.Size = new System.Drawing.Size(189, 45);
            this.btnShiftExcpt.TabIndex = 0;
            this.btnShiftExcpt.Text = "Generate Shift Exception";
            this.btnShiftExcpt.UseVisualStyleBackColor = true;
            this.btnShiftExcpt.Click += new System.EventHandler(this.btnShiftExcpt_Click);
            // 
            // btnRollNoExcpt
            // 
            this.btnRollNoExcpt.Location = new System.Drawing.Point(88, 166);
            this.btnRollNoExcpt.Name = "btnRollNoExcpt";
            this.btnRollNoExcpt.Size = new System.Drawing.Size(189, 43);
            this.btnRollNoExcpt.TabIndex = 0;
            this.btnRollNoExcpt.Text = "Generate Roll No. Exception";
            this.btnRollNoExcpt.UseVisualStyleBackColor = true;
            // 
            // btnPaperCodeExcpt
            // 
            this.btnPaperCodeExcpt.Location = new System.Drawing.Point(88, 228);
            this.btnPaperCodeExcpt.Name = "btnPaperCodeExcpt";
            this.btnPaperCodeExcpt.Size = new System.Drawing.Size(189, 50);
            this.btnPaperCodeExcpt.TabIndex = 0;
            this.btnPaperCodeExcpt.Text = "Generate Paper code Exception";
            this.btnPaperCodeExcpt.UseVisualStyleBackColor = true;
            // 
            // btnSheetNoExcpt
            // 
            this.btnSheetNoExcpt.Location = new System.Drawing.Point(88, 105);
            this.btnSheetNoExcpt.Name = "btnSheetNoExcpt";
            this.btnSheetNoExcpt.Size = new System.Drawing.Size(189, 43);
            this.btnSheetNoExcpt.TabIndex = 0;
            this.btnSheetNoExcpt.Text = "Generate Sheet No Exception";
            this.btnSheetNoExcpt.UseVisualStyleBackColor = true;
            // 
            // ExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 392);
            this.Controls.Add(this.btnSheetNoExcpt);
            this.Controls.Add(this.btnPaperCodeExcpt);
            this.Controls.Add(this.btnRollNoExcpt);
            this.Controls.Add(this.btnShiftExcpt);
            this.Controls.Add(this.btnBarCodeExcpt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExceptionForm";
            this.Text = "ExceptionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBarCodeExcpt;
        private System.Windows.Forms.Button btnShiftExcpt;
        private System.Windows.Forms.Button btnRollNoExcpt;
        private System.Windows.Forms.Button btnPaperCodeExcpt;
        private System.Windows.Forms.Button btnSheetNoExcpt;
    }
}