namespace Assignment01_c0842810
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
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Image = global::Assignment01_c0842810.Properties.Resources.back1;
            this.btnReturn.Location = new System.Drawing.Point(457, 429);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 60);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Image = global::Assignment01_c0842810.Properties.Resources.back1;
            this.btnCalculate.Location = new System.Drawing.Point(137, 429);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 60);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtLateFee
            // 
            this.txtLateFee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLateFee.Location = new System.Drawing.Point(421, 323);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.Size = new System.Drawing.Size(266, 37);
            this.txtLateFee.TabIndex = 3;
            // 
            // txtLateDays
            // 
            this.txtLateDays.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLateDays.Location = new System.Drawing.Point(103, 323);
            this.txtLateDays.Name = "txtLateDays";
            this.txtLateDays.Size = new System.Drawing.Size(266, 37);
            this.txtLateDays.TabIndex = 2;
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
            this.lblTitle.Location = new System.Drawing.Point(300, 51);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 44);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "New Releases";
            // 
            // lblLateFeeNoticeReadOnly
            // 
            this.lblLateFeeNoticeReadOnly.AutoSize = true;
            this.lblLateFeeNoticeReadOnly.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLateFeeNoticeReadOnly.Location = new System.Drawing.Point(553, 302);
            this.lblLateFeeNoticeReadOnly.Name = "lblLateFeeNoticeReadOnly";
            this.lblLateFeeNoticeReadOnly.Size = new System.Drawing.Size(116, 18);
            this.lblLateFeeNoticeReadOnly.TabIndex = 33;
            this.lblLateFeeNoticeReadOnly.Text = "At ??? / day";
            // 
            // frmLateFeeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Assignment01_c0842810.Properties.Resources.back3;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(803, 549);
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
    }
}