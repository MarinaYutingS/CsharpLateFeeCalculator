namespace LatefeeCalc_c0842810
{
    partial class frmLateFeeCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLateFeeCalculator));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.txtLateDays = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.lblLateFee = new System.Windows.Forms.Label();
            this.lblLateDays = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLateFeeNoticeReadOnly = new System.Windows.Forms.Label();
            this.txtMovieNumber = new System.Windows.Forms.TextBox();
            this.lblMovieNumber = new System.Windows.Forms.Label();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTotalNum = new System.Windows.Forms.TextBox();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Location = new System.Drawing.Point(879, 429);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 60);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(103, 429);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 60);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtLateFee
            // 
            this.txtLateFee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLateFee.Location = new System.Drawing.Point(421, 323);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.ReadOnly = true;
            this.txtLateFee.Size = new System.Drawing.Size(266, 37);
            this.txtLateFee.TabIndex = 4;
            this.txtLateFee.TabStop = false;
            // 
            // txtLateDays
            // 
            this.txtLateDays.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLateDays.Location = new System.Drawing.Point(103, 323);
            this.txtLateDays.Name = "txtLateDays";
            this.txtLateDays.ReadOnly = true;
            this.txtLateDays.Size = new System.Drawing.Size(266, 37);
            this.txtLateDays.TabIndex = 3;
            this.txtLateDays.TabStop = false;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCurrent.Location = new System.Drawing.Point(421, 200);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.ReadOnly = true;
            this.txtCurrent.Size = new System.Drawing.Size(266, 37);
            this.txtCurrent.TabIndex = 1;
            this.txtCurrent.TabStop = false;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDueDate.Location = new System.Drawing.Point(103, 200);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(266, 37);
            this.txtDueDate.TabIndex = 0;
            this.txtDueDate.Text = "Valid Format: M/D/Y";
            // 
            // lblLateFee
            // 
            this.lblLateFee.AutoSize = true;
            this.lblLateFee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateFee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLateFee.Location = new System.Drawing.Point(416, 277);
            this.lblLateFee.Name = "lblLateFee";
            this.lblLateFee.Size = new System.Drawing.Size(95, 29);
            this.lblLateFee.TabIndex = 26;
            this.lblLateFee.Text = "Late Fee";
            // 
            // lblLateDays
            // 
            this.lblLateDays.AutoSize = true;
            this.lblLateDays.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateDays.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLateDays.Location = new System.Drawing.Point(98, 277);
            this.lblLateDays.Name = "lblLateDays";
            this.lblLateDays.Size = new System.Drawing.Size(108, 29);
            this.lblLateDays.TabIndex = 25;
            this.lblLateDays.Text = "Late Days";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentDate.Location = new System.Drawing.Point(416, 154);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(142, 29);
            this.lblCurrentDate.TabIndex = 24;
            this.lblCurrentDate.Text = "Current Date";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDueDate.Location = new System.Drawing.Point(98, 154);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(105, 29);
            this.lblDueDate.TabIndex = 23;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(95, 60);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 44);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "New Releases";
            // 
            // lblLateFeeNoticeReadOnly
            // 
            this.lblLateFeeNoticeReadOnly.AutoSize = true;
            this.lblLateFeeNoticeReadOnly.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLateFeeNoticeReadOnly.Location = new System.Drawing.Point(553, 302);
            this.lblLateFeeNoticeReadOnly.Name = "lblLateFeeNoticeReadOnly";
            this.lblLateFeeNoticeReadOnly.Size = new System.Drawing.Size(116, 18);
            this.lblLateFeeNoticeReadOnly.TabIndex = 33;
            this.lblLateFeeNoticeReadOnly.Text = "At ??? / day";
            // 
            // txtMovieNumber
            // 
            this.txtMovieNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMovieNumber.Location = new System.Drawing.Point(745, 200);
            this.txtMovieNumber.Name = "txtMovieNumber";
            this.txtMovieNumber.ReadOnly = true;
            this.txtMovieNumber.Size = new System.Drawing.Size(158, 37);
            this.txtMovieNumber.TabIndex = 2;
            this.txtMovieNumber.Text = "0";
            // 
            // lblMovieNumber
            // 
            this.lblMovieNumber.AutoSize = true;
            this.lblMovieNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMovieNumber.Location = new System.Drawing.Point(740, 154);
            this.lblMovieNumber.Name = "lblMovieNumber";
            this.lblMovieNumber.Size = new System.Drawing.Size(200, 29);
            this.lblMovieNumber.TabIndex = 35;
            this.lblMovieNumber.Text = "Number of Movies";
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCustomerType.Location = new System.Drawing.Point(745, 323);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(266, 37);
            this.txtCustomerType.TabIndex = 5;
            this.txtCustomerType.Text = "Valid Type: N / J / L";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCustomerType.Location = new System.Drawing.Point(740, 277);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(163, 29);
            this.lblCustomerType.TabIndex = 37;
            this.lblCustomerType.Text = "Customer Type";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(490, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 60);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTotalNum
            // 
            this.txtTotalNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTotalNum.Location = new System.Drawing.Point(301, 382);
            this.txtTotalNum.Name = "txtTotalNum";
            this.txtTotalNum.ReadOnly = true;
            this.txtTotalNum.Size = new System.Drawing.Size(68, 37);
            this.txtTotalNum.TabIndex = 9;
            this.txtTotalNum.TabStop = false;
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalNum.Location = new System.Drawing.Point(98, 382);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(140, 29);
            this.lblTotalNum.TabIndex = 40;
            this.lblTotalNum.Text = "Total Movies";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(879, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 107);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "&Select Movies to Return";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmLateFeeCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::LatefeeCalc_c0842810.Properties.Resources.calcBack;
            this.CancelButton = this.btnReturn;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1104, 549);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotalNum);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCustomerType);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.txtMovieNumber);
            this.Controls.Add(this.lblMovieNumber);
            this.Controls.Add(this.lblLateFeeNoticeReadOnly);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLateFee);
            this.Controls.Add(this.txtLateDays);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.lblLateFee);
            this.Controls.Add(this.lblLateDays);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLateFeeCalculator";
            this.Text = "UNITILIZED";
            this.Shown += new System.EventHandler(this.frmNewReleases_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtLateFee;
        private System.Windows.Forms.TextBox txtLateDays;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label lblLateFee;
        private System.Windows.Forms.Label lblLateDays;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLateFeeNoticeReadOnly;
        private System.Windows.Forms.TextBox txtMovieNumber;
        private System.Windows.Forms.Label lblMovieNumber;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTotalNum;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Button btnAdd;
    }
}