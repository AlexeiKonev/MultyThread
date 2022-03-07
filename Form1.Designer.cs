
namespace ThreadApp
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
            this.threadButton1 = new System.Windows.Forms.Button();
            this.threadButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // threadButton1
            // 
            this.threadButton1.Location = new System.Drawing.Point(96, 30);
            this.threadButton1.Name = "threadButton1";
            this.threadButton1.Size = new System.Drawing.Size(152, 34);
            this.threadButton1.TabIndex = 0;
            this.threadButton1.Text = "thread1";
            this.threadButton1.UseVisualStyleBackColor = true;
            this.threadButton1.Click += new System.EventHandler(this.threadButton1_Click);
            // 
            // threadButton2
            // 
            this.threadButton2.Location = new System.Drawing.Point(96, 83);
            this.threadButton2.Name = "threadButton2";
            this.threadButton2.Size = new System.Drawing.Size(146, 24);
            this.threadButton2.TabIndex = 1;
            this.threadButton2.Text = "thread2";
            this.threadButton2.UseVisualStyleBackColor = true;
            this.threadButton2.Click += new System.EventHandler(this.threadButton2_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "btnThread1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.threadButton2);
            this.Controls.Add(this.threadButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button threadButton1;
        private System.Windows.Forms.Button threadButton2;
    }
}

