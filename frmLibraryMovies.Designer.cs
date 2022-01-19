namespace Assignment01_c0842810
{
    partial class frmLibraryMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibraryMovies));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLateFee = new System.Windows.Forms.Label();
            this.lblLateDays = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblLibraryMovies = new System.Windows.Forms.Label();
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
            this.btnReturn.TabIndex = 21;
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
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(421, 323);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 37);
            this.textBox4.TabIndex = 19;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(103, 323);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 37);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(421, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 37);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 37);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblLateFee
            // 
            this.lblLateFee.AutoSize = true;
            this.lblLateFee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateFee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLateFee.Location = new System.Drawing.Point(416, 277);
            this.lblLateFee.Name = "lblLateFee";
            this.lblLateFee.Size = new System.Drawing.Size(95, 29);
            this.lblLateFee.TabIndex = 15;
            this.lblLateFee.Text = "Late Fee";
            this.lblLateFee.Click += new System.EventHandler(this.lblLateFee_Click);
            // 
            // lblLateDays
            // 
            this.lblLateDays.AutoSize = true;
            this.lblLateDays.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateDays.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLateDays.Location = new System.Drawing.Point(98, 277);
            this.lblLateDays.Name = "lblLateDays";
            this.lblLateDays.Size = new System.Drawing.Size(108, 29);
            this.lblLateDays.TabIndex = 14;
            this.lblLateDays.Text = "Late Days";
            this.lblLateDays.Click += new System.EventHandler(this.lblLateDays_Click);
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentDate.Location = new System.Drawing.Point(416, 154);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(142, 29);
            this.lblCurrentDate.TabIndex = 13;
            this.lblCurrentDate.Text = "Current Date";
            this.lblCurrentDate.Click += new System.EventHandler(this.lblCurrentDate_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDueDate.Location = new System.Drawing.Point(98, 154);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(105, 29);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "Due Date";
            this.lblDueDate.Click += new System.EventHandler(this.lblDueDate_Click);
            // 
            // lblLibraryMovies
            // 
            this.lblLibraryMovies.AutoSize = true;
            this.lblLibraryMovies.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryMovies.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLibraryMovies.Location = new System.Drawing.Point(252, 59);
            this.lblLibraryMovies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibraryMovies.Name = "lblLibraryMovies";
            this.lblLibraryMovies.Size = new System.Drawing.Size(238, 44);
            this.lblLibraryMovies.TabIndex = 11;
            this.lblLibraryMovies.Text = "Library Movies";
            this.lblLibraryMovies.Click += new System.EventHandler(this.lblMainMenu_Click);
            // 
            // frmLibraryMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Assignment01_c0842810.Properties.Resources.back3;
            this.ClientSize = new System.Drawing.Size(718, 549);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLateFee);
            this.Controls.Add(this.lblLateDays);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblLibraryMovies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLibraryMovies";
            this.Text = "Library Movies";
            this.Load += new System.EventHandler(this.frmLibraryMovies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLateFee;
        private System.Windows.Forms.Label lblLateDays;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblLibraryMovies;
    }
}