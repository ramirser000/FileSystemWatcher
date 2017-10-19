namespace MyFileSystemWatcher
{
    partial class Form2
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
            this.lblExtQuery = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExtQuery
            // 
            this.lblExtQuery.AutoSize = true;
            this.lblExtQuery.Location = new System.Drawing.Point(31, 26);
            this.lblExtQuery.Name = "lblExtQuery";
            this.lblExtQuery.Size = new System.Drawing.Size(197, 13);
            this.lblExtQuery.TabIndex = 0;
            this.lblExtQuery.Text = "Extension Query (Empty = ALL file types)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(340, 21);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Query";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridResults
            // 
            this.dataGridResults.AllowUserToAddRows = false;
            this.dataGridResults.AllowUserToDeleteRows = false;
            this.dataGridResults.AllowUserToOrderColumns = true;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Location = new System.Drawing.Point(34, 50);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.ReadOnly = true;
            this.dataGridResults.Size = new System.Drawing.Size(644, 391);
            this.dataGridResults.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(582, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear database";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 494);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblExtQuery);
            this.Name = "Form2";
            this.Text = "Database Query";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExtQuery;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.Button btnClear;
    }
}