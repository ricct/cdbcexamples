namespace CodeSamples
{
    partial class FrmSamples
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDataAdapterMultiFill = new System.Windows.Forms.Button();
            this.btnDataAdapterUpdate = new System.Windows.Forms.Button();
            this.btnDataAdapterFillSchema = new System.Windows.Forms.Button();
            this.btnDataAdapterFill = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserPsk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApplicationPsk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApplicationID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCommandCollectionExecuteMultiQuery = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCommandExecuteDbDataReader = new System.Windows.Forms.Button();
            this.btnCommandExecuteScalar = new System.Windows.Forms.Button();
            this.btnCommandExecuteNonQuery = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblLink = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDataAdapterMultiFill);
            this.groupBox1.Controls.Add(this.btnDataAdapterUpdate);
            this.groupBox1.Controls.Add(this.btnDataAdapterFillSchema);
            this.groupBox1.Controls.Add(this.btnDataAdapterFill);
            this.groupBox1.Location = new System.Drawing.Point(15, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CdbcDataAdapter";
            // 
            // btnDataAdapterMultiFill
            // 
            this.btnDataAdapterMultiFill.BackColor = System.Drawing.Color.MistyRose;
            this.btnDataAdapterMultiFill.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDataAdapterMultiFill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDataAdapterMultiFill.Location = new System.Drawing.Point(17, 232);
            this.btnDataAdapterMultiFill.Name = "btnDataAdapterMultiFill";
            this.btnDataAdapterMultiFill.Size = new System.Drawing.Size(200, 36);
            this.btnDataAdapterMultiFill.TabIndex = 3;
            this.btnDataAdapterMultiFill.Text = "DataAdapter.MultiFill";
            this.btnDataAdapterMultiFill.UseVisualStyleBackColor = false;
            this.btnDataAdapterMultiFill.Click += new System.EventHandler(this.RunSample);
            // 
            // btnDataAdapterUpdate
            // 
            this.btnDataAdapterUpdate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDataAdapterUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDataAdapterUpdate.Location = new System.Drawing.Point(17, 141);
            this.btnDataAdapterUpdate.Name = "btnDataAdapterUpdate";
            this.btnDataAdapterUpdate.Size = new System.Drawing.Size(200, 36);
            this.btnDataAdapterUpdate.TabIndex = 2;
            this.btnDataAdapterUpdate.Text = "DataAdapter.Update";
            this.btnDataAdapterUpdate.UseVisualStyleBackColor = true;
            this.btnDataAdapterUpdate.Click += new System.EventHandler(this.RunSample);
            // 
            // btnDataAdapterFillSchema
            // 
            this.btnDataAdapterFillSchema.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDataAdapterFillSchema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDataAdapterFillSchema.Location = new System.Drawing.Point(17, 84);
            this.btnDataAdapterFillSchema.Name = "btnDataAdapterFillSchema";
            this.btnDataAdapterFillSchema.Size = new System.Drawing.Size(200, 36);
            this.btnDataAdapterFillSchema.TabIndex = 1;
            this.btnDataAdapterFillSchema.Text = "DataAdapter.FillSchema";
            this.btnDataAdapterFillSchema.UseVisualStyleBackColor = true;
            this.btnDataAdapterFillSchema.Click += new System.EventHandler(this.RunSample);
            // 
            // btnDataAdapterFill
            // 
            this.btnDataAdapterFill.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDataAdapterFill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDataAdapterFill.Location = new System.Drawing.Point(17, 27);
            this.btnDataAdapterFill.Name = "btnDataAdapterFill";
            this.btnDataAdapterFill.Size = new System.Drawing.Size(200, 36);
            this.btnDataAdapterFill.TabIndex = 0;
            this.btnDataAdapterFill.Text = "DataAdapter.Fill";
            this.btnDataAdapterFill.UseVisualStyleBackColor = true;
            this.btnDataAdapterFill.Click += new System.EventHandler(this.RunSample);
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(461, 561);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.groupBox4);
            this.pnlLeft.Controls.Add(this.groupBox3);
            this.pnlLeft.Controls.Add(this.groupBox2);
            this.pnlLeft.Controls.Add(this.groupBox1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(547, 561);
            this.pnlLeft.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblLink);
            this.groupBox4.Controls.Add(this.txtConnectionString);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtUserPsk);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtUserID);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtApplicationPsk);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtApplicationID);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(19, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(512, 178);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Authentication";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(106, 144);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(135, 19);
            this.txtConnectionString.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "connectionString";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserPsk
            // 
            this.txtUserPsk.Location = new System.Drawing.Point(348, 110);
            this.txtUserPsk.Name = "txtUserPsk";
            this.txtUserPsk.Size = new System.Drawing.Size(153, 19);
            this.txtUserPsk.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(249, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "User PSK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(106, 110);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(135, 19);
            this.txtUserID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "User ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApplicationPsk
            // 
            this.txtApplicationPsk.Location = new System.Drawing.Point(349, 75);
            this.txtApplicationPsk.Name = "txtApplicationPsk";
            this.txtApplicationPsk.Size = new System.Drawing.Size(153, 19);
            this.txtApplicationPsk.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(249, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Application PSK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApplicationID
            // 
            this.txtApplicationID.Location = new System.Drawing.Point(106, 75);
            this.txtApplicationID.Name = "txtApplicationID";
            this.txtApplicationID.Size = new System.Drawing.Size(135, 19);
            this.txtApplicationID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Application ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCommandCollectionExecuteMultiQuery);
            this.groupBox3.Location = new System.Drawing.Point(287, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 89);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CdbcCommandCollection";
            // 
            // btnCommandCollectionExecuteMultiQuery
            // 
            this.btnCommandCollectionExecuteMultiQuery.BackColor = System.Drawing.Color.MistyRose;
            this.btnCommandCollectionExecuteMultiQuery.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCommandCollectionExecuteMultiQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCommandCollectionExecuteMultiQuery.Location = new System.Drawing.Point(16, 24);
            this.btnCommandCollectionExecuteMultiQuery.Name = "btnCommandCollectionExecuteMultiQuery";
            this.btnCommandCollectionExecuteMultiQuery.Size = new System.Drawing.Size(223, 50);
            this.btnCommandCollectionExecuteMultiQuery.TabIndex = 3;
            this.btnCommandCollectionExecuteMultiQuery.Text = "CommandCollection.\r\nExecuteMultiQuery";
            this.btnCommandCollectionExecuteMultiQuery.UseVisualStyleBackColor = false;
            this.btnCommandCollectionExecuteMultiQuery.Click += new System.EventHandler(this.RunSample);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCommandExecuteDbDataReader);
            this.groupBox2.Controls.Add(this.btnCommandExecuteScalar);
            this.groupBox2.Controls.Add(this.btnCommandExecuteNonQuery);
            this.groupBox2.Location = new System.Drawing.Point(287, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CdbcCommand";
            // 
            // btnCommandExecuteDbDataReader
            // 
            this.btnCommandExecuteDbDataReader.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCommandExecuteDbDataReader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCommandExecuteDbDataReader.Location = new System.Drawing.Point(16, 134);
            this.btnCommandExecuteDbDataReader.Name = "btnCommandExecuteDbDataReader";
            this.btnCommandExecuteDbDataReader.Size = new System.Drawing.Size(223, 51);
            this.btnCommandExecuteDbDataReader.TabIndex = 2;
            this.btnCommandExecuteDbDataReader.Text = "Command.\r\nExecuteDbDataReader";
            this.btnCommandExecuteDbDataReader.UseVisualStyleBackColor = true;
            this.btnCommandExecuteDbDataReader.Click += new System.EventHandler(this.RunSample);
            // 
            // btnCommandExecuteScalar
            // 
            this.btnCommandExecuteScalar.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCommandExecuteScalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCommandExecuteScalar.Location = new System.Drawing.Point(10, 84);
            this.btnCommandExecuteScalar.Name = "btnCommandExecuteScalar";
            this.btnCommandExecuteScalar.Size = new System.Drawing.Size(229, 36);
            this.btnCommandExecuteScalar.TabIndex = 1;
            this.btnCommandExecuteScalar.Text = "Command.ExecuteScalar";
            this.btnCommandExecuteScalar.UseVisualStyleBackColor = true;
            this.btnCommandExecuteScalar.Click += new System.EventHandler(this.RunSample);
            // 
            // btnCommandExecuteNonQuery
            // 
            this.btnCommandExecuteNonQuery.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCommandExecuteNonQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCommandExecuteNonQuery.Location = new System.Drawing.Point(6, 27);
            this.btnCommandExecuteNonQuery.Name = "btnCommandExecuteNonQuery";
            this.btnCommandExecuteNonQuery.Size = new System.Drawing.Size(234, 36);
            this.btnCommandExecuteNonQuery.TabIndex = 0;
            this.btnCommandExecuteNonQuery.Text = "Command.ExecuteNonQuery";
            this.btnCommandExecuteNonQuery.UseVisualStyleBackColor = true;
            this.btnCommandExecuteNonQuery.Click += new System.EventHandler(this.RunSample);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.txtOutput);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(547, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(461, 561);
            this.pnlRight.TabIndex = 4;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLink.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLink.Location = new System.Drawing.Point(103, 40);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(310, 16);
            this.lblLink.TabIndex = 13;
            this.lblLink.Text = "https://github.com/ricct/cdbcexamples";
            this.lblLink.Click += new System.EventHandler(this.LblLink_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Please get authentication information from :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "FrmSamples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Samples";
            this.groupBox1.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDataAdapterFillSchema;
        private System.Windows.Forms.Button btnDataAdapterFill;
        private System.Windows.Forms.Button btnDataAdapterUpdate;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnDataAdapterMultiFill;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCommandCollectionExecuteMultiQuery;
        private System.Windows.Forms.Button btnCommandExecuteDbDataReader;
        private System.Windows.Forms.Button btnCommandExecuteScalar;
        private System.Windows.Forms.Button btnCommandExecuteNonQuery;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtUserPsk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApplicationPsk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApplicationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLink;
    }
}