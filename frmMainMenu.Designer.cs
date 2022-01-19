namespace Assignment01_c0842810
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnNewRelease = new System.Windows.Forms.Button();
            this.btnLibraryMovie = new System.Windows.Forms.Button();
            this.btnKidsMovie = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMainMenu.Location = new System.Drawing.Point(169, 100);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(407, 44);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Ryan`s Late Fee Calculator";
            this.lblMainMenu.Click += new System.EventHandler(this.lblMainMenu_Click);
            // 
            // btnNewRelease
            // 
            this.btnNewRelease.Location = new System.Drawing.Point(97, 237);
            this.btnNewRelease.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewRelease.Name = "btnNewRelease";
            this.btnNewRelease.Size = new System.Drawing.Size(204, 66);
            this.btnNewRelease.TabIndex = 1;
            this.btnNewRelease.Text = "&New Release";
            this.btnNewRelease.UseVisualStyleBackColor = true;
            this.btnNewRelease.Click += new System.EventHandler(this.btnNewRelease_Click);
            // 
            // btnLibraryMovie
            // 
            this.btnLibraryMovie.Location = new System.Drawing.Point(420, 237);
            this.btnLibraryMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLibraryMovie.Name = "btnLibraryMovie";
            this.btnLibraryMovie.Size = new System.Drawing.Size(204, 66);
            this.btnLibraryMovie.TabIndex = 2;
            this.btnLibraryMovie.Text = "&Library Movie";
            this.btnLibraryMovie.UseVisualStyleBackColor = true;
            // 
            // btnKidsMovie
            // 
            this.btnKidsMovie.Location = new System.Drawing.Point(97, 379);
            this.btnKidsMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKidsMovie.Name = "btnKidsMovie";
            this.btnKidsMovie.Size = new System.Drawing.Size(204, 66);
            this.btnKidsMovie.TabIndex = 3;
            this.btnKidsMovie.Text = "&Kids Movie";
            this.btnKidsMovie.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(420, 379);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(204, 66);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            this.AcceptButton = this.btnNewRelease;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Assignment01_c0842810.Properties.Resources.back2;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(718, 549);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKidsMovie);
            this.Controls.Add(this.btnLibraryMovie);
            this.Controls.Add(this.btnNewRelease);
            this.Controls.Add(this.lblMainMenu);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnNewRelease;
        private System.Windows.Forms.Button btnLibraryMovie;
        private System.Windows.Forms.Button btnKidsMovie;
        private System.Windows.Forms.Button btnExit;
    }
}

