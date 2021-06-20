
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
            this.giftService_uc1 = new AradaSystemManager.Gift.FrontEnd.giftService_UC();
            this.SuspendLayout();
            // 
            // giftService_uc1
            // 
            this.giftService_uc1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.giftService_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giftService_uc1.Location = new System.Drawing.Point(0, 0);
            this.giftService_uc1.Name = "giftService_uc1";
            this.giftService_uc1.Size = new System.Drawing.Size(1560, 769);
            this.giftService_uc1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 769);
            this.Controls.Add(this.giftService_uc1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Gift.FrontEnd.giftService_UC giftService_uc1;
    }
}

