namespace CodeSamples
{
    partial class FrmMain
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
            this.gbExamples = new System.Windows.Forms.GroupBox();
            this.btnOracleSample = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbExamples.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbExamples
            // 
            this.gbExamples.Controls.Add(this.btnOracleSample);
            this.gbExamples.Location = new System.Drawing.Point(108, 43);
            this.gbExamples.Name = "gbExamples";
            this.gbExamples.Size = new System.Drawing.Size(358, 142);
            this.gbExamples.TabIndex = 0;
            this.gbExamples.TabStop = false;
            this.gbExamples.Text = "Examples";
            // 
            // btnOracleSample
            // 
            this.btnOracleSample.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOracleSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOracleSample.Location = new System.Drawing.Point(57, 49);
            this.btnOracleSample.Name = "btnOracleSample";
            this.btnOracleSample.Size = new System.Drawing.Size(229, 53);
            this.btnOracleSample.TabIndex = 0;
            this.btnOracleSample.Text = "Oracle Samples";
            this.btnOracleSample.UseVisualStyleBackColor = true;
            this.btnOracleSample.Click += new System.EventHandler(this.BtnOracleSample_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(390, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 325);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbExamples);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDBC Client Code Samples";
            this.gbExamples.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbExamples;
        private System.Windows.Forms.Button btnOracleSample;
        private System.Windows.Forms.Button btnExit;
    }
}