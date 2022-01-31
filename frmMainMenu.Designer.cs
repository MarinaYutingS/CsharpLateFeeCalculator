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
            this.btnOpenNewReleases = new System.Windows.Forms.Button();
            this.btnOpenLibraryMovies = new System.Windows.Forms.Button();
            this.btnOpenKidsMovies = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMainMenu.Location = new System.Drawing.Point(217, 98);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(407, 44);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Ryan`s Late Fee Calculator";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOpenNewReleases
            // 
            this.btnOpenNewReleases.Location = new System.Drawing.Point(97, 237);
            this.btnOpenNewReleases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenNewReleases.Name = "btnOpenNewReleases";
            this.btnOpenNewReleases.Size = new System.Drawing.Size(204, 66);
            this.btnOpenNewReleases.TabIndex = 1;
            this.btnOpenNewReleases.Text = "&New Releases";
            this.btnOpenNewReleases.UseVisualStyleBackColor = true;
            this.btnOpenNewReleases.Click += new System.EventHandler(this.btnOpenNewReleases_Click);
            // 
            // btnOpenLibraryMovies
            // 
            this.btnOpenLibraryMovies.Location = new System.Drawing.Point(420, 237);
            this.btnOpenLibraryMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenLibraryMovies.Name = "btnOpenLibraryMovies";
            this.btnOpenLibraryMovies.Size = new System.Drawing.Size(204, 66);
            this.btnOpenLibraryMovies.TabIndex = 2;
            this.btnOpenLibraryMovies.Text = "&Library Movies";
            this.btnOpenLibraryMovies.UseVisualStyleBackColor = true;
            this.btnOpenLibraryMovies.Click += new System.EventHandler(this.btnOpenLibraryMovie_Click);
            // 
            // btnOpenKidsMovies
            // 
            this.btnOpenKidsMovies.Location = new System.Drawing.Point(97, 379);
            this.btnOpenKidsMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenKidsMovies.Name = "btnOpenKidsMovies";
            this.btnOpenKidsMovies.Size = new System.Drawing.Size(204, 66);
            this.btnOpenKidsMovies.TabIndex = 3;
            this.btnOpenKidsMovies.Text = "&Kids Movies";
            this.btnOpenKidsMovies.UseVisualStyleBackColor = true;
            this.btnOpenKidsMovies.Click += new System.EventHandler(this.btnOpenKidsMovies_Click);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainMenu
            // 
            this.AcceptButton = this.btnOpenNewReleases;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Assignment01_c0842810.Properties.Resources.back2;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(718, 549);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenKidsMovies);
            this.Controls.Add(this.btnOpenLibraryMovies);
            this.Controls.Add(this.btnOpenNewReleases);
            this.Controls.Add(this.lblMainMenu);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnOpenNewReleases;
        private System.Windows.Forms.Button btnOpenLibraryMovies;
        private System.Windows.Forms.Button btnOpenKidsMovies;
        private System.Windows.Forms.Button btnExit;
    }
}

