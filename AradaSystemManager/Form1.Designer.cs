
namespace AradaSystemManager
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
            this.login_uc1 = new AradaSystemManager.Prime_UCs.Login_UC();
            this.SuspendLayout();
            // 
            // login_uc1
            // 
            this.login_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_uc1.Location = new System.Drawing.Point(0, 0);
            this.login_uc1.Margin = new System.Windows.Forms.Padding(0);
            this.login_uc1.Name = "login_uc1";
            this.login_uc1.Size = new System.Drawing.Size(1560, 1025);
            this.login_uc1.TabIndex = 0;
            this.login_uc1.Load += new System.EventHandler(this.login_uc1_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 1025);
            this.Controls.Add(this.login_uc1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Prime_UCs.Login_UC login_uc1;
    }
}

