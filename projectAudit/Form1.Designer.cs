namespace projectAudit
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
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.btnRun3 = new System.Windows.Forms.Button();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.Results = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Found = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMP = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AMPSum = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData1
            // 
            this.txtData1.Location = new System.Drawing.Point(16, 38);
            this.txtData1.Margin = new System.Windows.Forms.Padding(4);
            this.txtData1.Multiline = true;
            this.txtData1.Name = "txtData1";
            this.txtData1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData1.Size = new System.Drawing.Size(225, 515);
            this.txtData1.TabIndex = 2;
            // 
            // txtData2
            // 
            this.txtData2.Location = new System.Drawing.Point(249, 39);
            this.txtData2.Margin = new System.Windows.Forms.Padding(4);
            this.txtData2.Multiline = true;
            this.txtData2.Name = "txtData2";
            this.txtData2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData2.Size = new System.Drawing.Size(225, 515);
            this.txtData2.TabIndex = 3;
            //this.txtData2.MouseLeave += new System.EventHandler(this.txtData2_MouseLeave);
            // 
            // btnRun3
            // 
            this.btnRun3.Location = new System.Drawing.Point(907, 564);
            this.btnRun3.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun3.Name = "btnRun3";
            this.btnRun3.Size = new System.Drawing.Size(183, 34);
            this.btnRun3.TabIndex = 4;
            this.btnRun3.Text = "Scan";
            this.btnRun3.UseVisualStyleBackColor = true;
            this.btnRun3.Click += new System.EventHandler(this.btnRun3_Click);
            // 
            // dgResults
            // 
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Results,
            this.Found,
            this.AMP,
            this.AMPSum});
            this.dgResults.Location = new System.Drawing.Point(482, 39);
            this.dgResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgResults.Name = "dgResults";
            this.dgResults.Size = new System.Drawing.Size(608, 516);
            this.dgResults.TabIndex = 7;
            this.dgResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResults_CellContentClick);
            // 
            // Results
            // 
            this.Results.HeaderText = "Data 1 Results";
            this.Results.Name = "Results";
            this.Results.Width = 150;
            // 
            // Found
            // 
            this.Found.HeaderText = "Found";
            this.Found.Name = "Found";
            this.Found.Width = 50;
            // 
            // AMP
            // 
            this.AMP.HeaderText = "AMP";
            this.AMP.Name = "AMP";
            this.AMP.Width = 200;
            // 
            // AMPSum
            // 
            this.AMPSum.HeaderText = "AMP Summary";
            this.AMPSum.Name = "AMPSum";
            this.AMPSum.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data 2";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Enabled = false;
            this.btnExportExcel.Location = new System.Drawing.Point(717, 566);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(183, 33);
            this.btnExportExcel.TabIndex = 9;
            this.btnExportExcel.Text = "Export to Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 608);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgResults);
            this.Controls.Add(this.btnRun3);
            this.Controls.Add(this.txtData2);
            this.Controls.Add(this.txtData1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Audit Inventory Scan";
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.Button btnRun3;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Found;
        private System.Windows.Forms.DataGridViewLinkColumn AMP;
        private System.Windows.Forms.DataGridViewLinkColumn AMPSum;
    }
}

