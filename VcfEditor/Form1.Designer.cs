namespace VcfEditor
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
            this.txtVcfLoc = new System.Windows.Forms.TextBox();
            this.txtImgLoc = new System.Windows.Forms.TextBox();
            this.btnVcfLoc = new System.Windows.Forms.Button();
            this.btnImgLoc = new System.Windows.Forms.Button();
            this.btnJustDoIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVcfLoc
            // 
            this.txtVcfLoc.Location = new System.Drawing.Point(77, 12);
            this.txtVcfLoc.Name = "txtVcfLoc";
            this.txtVcfLoc.Size = new System.Drawing.Size(376, 20);
            this.txtVcfLoc.TabIndex = 0;
            // 
            // txtImgLoc
            // 
            this.txtImgLoc.Location = new System.Drawing.Point(77, 38);
            this.txtImgLoc.Name = "txtImgLoc";
            this.txtImgLoc.Size = new System.Drawing.Size(376, 20);
            this.txtImgLoc.TabIndex = 1;
            // 
            // btnVcfLoc
            // 
            this.btnVcfLoc.Location = new System.Drawing.Point(459, 12);
            this.btnVcfLoc.Name = "btnVcfLoc";
            this.btnVcfLoc.Size = new System.Drawing.Size(94, 23);
            this.btnVcfLoc.TabIndex = 2;
            this.btnVcfLoc.Text = "Select VCF";
            this.btnVcfLoc.UseVisualStyleBackColor = true;
            this.btnVcfLoc.Click += new System.EventHandler(this.btnVcfLoc_Click);
            // 
            // btnImgLoc
            // 
            this.btnImgLoc.Location = new System.Drawing.Point(459, 36);
            this.btnImgLoc.Name = "btnImgLoc";
            this.btnImgLoc.Size = new System.Drawing.Size(94, 23);
            this.btnImgLoc.TabIndex = 3;
            this.btnImgLoc.Text = "Select image";
            this.btnImgLoc.UseVisualStyleBackColor = true;
            this.btnImgLoc.Click += new System.EventHandler(this.btnImgLoc_Click);
            // 
            // btnJustDoIt
            // 
            this.btnJustDoIt.Location = new System.Drawing.Point(478, 74);
            this.btnJustDoIt.Name = "btnJustDoIt";
            this.btnJustDoIt.Size = new System.Drawing.Size(75, 23);
            this.btnJustDoIt.TabIndex = 4;
            this.btnJustDoIt.Text = "DO IT";
            this.btnJustDoIt.UseVisualStyleBackColor = true;
            this.btnJustDoIt.Click += new System.EventHandler(this.btnJustDoIt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 113);
            this.Controls.Add(this.btnJustDoIt);
            this.Controls.Add(this.btnImgLoc);
            this.Controls.Add(this.btnVcfLoc);
            this.Controls.Add(this.txtImgLoc);
            this.Controls.Add(this.txtVcfLoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVcfLoc;
        private System.Windows.Forms.TextBox txtImgLoc;
        private System.Windows.Forms.Button btnVcfLoc;
        private System.Windows.Forms.Button btnImgLoc;
        private System.Windows.Forms.Button btnJustDoIt;
    }
}

