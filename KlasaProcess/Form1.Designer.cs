namespace KlasaProcess
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
            this.btnInternetExplorer = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnStartInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInternetExplorer
            // 
            this.btnInternetExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInternetExplorer.Location = new System.Drawing.Point(69, 79);
            this.btnInternetExplorer.Name = "btnInternetExplorer";
            this.btnInternetExplorer.Size = new System.Drawing.Size(184, 54);
            this.btnInternetExplorer.TabIndex = 0;
            this.btnInternetExplorer.Text = "Pokrenite Internet Explorer";
            this.btnInternetExplorer.UseVisualStyleBackColor = true;
            this.btnInternetExplorer.Click += new System.EventHandler(this.btnInternetExplorer_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcel.Location = new System.Drawing.Point(383, 79);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(154, 39);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Pokrenite Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWord.Location = new System.Drawing.Point(69, 169);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(184, 46);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Pokrenite Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnStartInfo
            // 
            this.btnStartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartInfo.Location = new System.Drawing.Point(383, 169);
            this.btnStartInfo.Name = "btnStartInfo";
            this.btnStartInfo.Size = new System.Drawing.Size(154, 46);
            this.btnStartInfo.TabIndex = 3;
            this.btnStartInfo.Text = "StartInfo";
            this.btnStartInfo.UseVisualStyleBackColor = true;
            this.btnStartInfo.Click += new System.EventHandler(this.btnStartInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartInfo);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnInternetExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInternetExplorer;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnStartInfo;
    }
}

