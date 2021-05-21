
namespace AradaSystemManager.Prime_UCs
{
    partial class Login_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftContainer = new System.Windows.Forms.TableLayoutPanel();
            this.aradashiLogo_pic = new System.Windows.Forms.PictureBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.footer_lbl = new System.Windows.Forms.Label();
            this.aradaLogo_pic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rightContainer = new System.Windows.Forms.TableLayoutPanel();
            this.login_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.signin_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.passReset_lbl = new System.Windows.Forms.Label();
            this.ucContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.leftContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aradashiLogo_pic)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aradaLogo_pic)).BeginInit();
            this.panel2.SuspendLayout();
            this.rightContainer.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucContainer
            // 
            this.ucContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucContainer.ColumnCount = 2;
            this.ucContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ucContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ucContainer.Controls.Add(this.panel1, 0, 0);
            this.ucContainer.Controls.Add(this.panel2, 1, 0);
            this.ucContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucContainer.Location = new System.Drawing.Point(0, 0);
            this.ucContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ucContainer.Name = "ucContainer";
            this.ucContainer.RowCount = 1;
            this.ucContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ucContainer.Size = new System.Drawing.Size(1366, 768);
            this.ucContainer.TabIndex = 0;
            this.ucContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.leftContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 768);
            this.panel1.TabIndex = 0;
            // 
            // leftContainer
            // 
            this.leftContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftContainer.ColumnCount = 3;
            this.leftContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.98245F));
            this.leftContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51375F));
            this.leftContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5038F));
            this.leftContainer.Controls.Add(this.aradashiLogo_pic, 1, 1);
            this.leftContainer.Controls.Add(this.title_lbl, 1, 2);
            this.leftContainer.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.leftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftContainer.Location = new System.Drawing.Point(0, 0);
            this.leftContainer.Name = "leftContainer";
            this.leftContainer.RowCount = 4;
            this.leftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.leftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.leftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.leftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.leftContainer.Size = new System.Drawing.Size(683, 768);
            this.leftContainer.TabIndex = 0;
            this.leftContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // aradashiLogo_pic
            // 
            this.aradashiLogo_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aradashiLogo_pic.Image = global::AradaSystemManager.Properties.Resources.aradashi_Transparent;
            this.aradashiLogo_pic.Location = new System.Drawing.Point(136, 115);
            this.aradashiLogo_pic.Margin = new System.Windows.Forms.Padding(0);
            this.aradashiLogo_pic.Name = "aradashiLogo_pic";
            this.aradashiLogo_pic.Size = new System.Drawing.Size(399, 460);
            this.aradashiLogo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aradashiLogo_pic.TabIndex = 0;
            this.aradashiLogo_pic.TabStop = false;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title_lbl.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.title_lbl.Location = new System.Drawing.Point(139, 575);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(393, 76);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Manager Software";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.footer_lbl, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.aradaLogo_pic, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(136, 651);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(399, 117);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // footer_lbl
            // 
            this.footer_lbl.AutoSize = true;
            this.footer_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footer_lbl.Location = new System.Drawing.Point(0, 53);
            this.footer_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.footer_lbl.Name = "footer_lbl";
            this.footer_lbl.Size = new System.Drawing.Size(199, 53);
            this.footer_lbl.TabIndex = 0;
            this.footer_lbl.Text = "Product of";
            this.footer_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // aradaLogo_pic
            // 
            this.aradaLogo_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aradaLogo_pic.Image = global::AradaSystemManager.Properties.Resources.photo_2021_04_18_16_50_37;
            this.aradaLogo_pic.Location = new System.Drawing.Point(199, 53);
            this.aradaLogo_pic.Margin = new System.Windows.Forms.Padding(0);
            this.aradaLogo_pic.Name = "aradaLogo_pic";
            this.aradaLogo_pic.Size = new System.Drawing.Size(39, 53);
            this.aradaLogo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aradaLogo_pic.TabIndex = 1;
            this.aradaLogo_pic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.rightContainer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(683, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 768);
            this.panel2.TabIndex = 1;
            // 
            // rightContainer
            // 
            this.rightContainer.ColumnCount = 3;
            this.rightContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.rightContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.rightContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.rightContainer.Controls.Add(this.login_lbl, 1, 1);
            this.rightContainer.Controls.Add(this.username_lbl, 1, 3);
            this.rightContainer.Controls.Add(this.pass_lbl, 1, 5);
            this.rightContainer.Controls.Add(this.username_txt, 1, 4);
            this.rightContainer.Controls.Add(this.password_txt, 1, 6);
            this.rightContainer.Controls.Add(this.signin_btn, 1, 7);
            this.rightContainer.Controls.Add(this.tableLayoutPanel5, 1, 8);
            this.rightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightContainer.Location = new System.Drawing.Point(0, 0);
            this.rightContainer.Margin = new System.Windows.Forms.Padding(0);
            this.rightContainer.Name = "rightContainer";
            this.rightContainer.RowCount = 10;
            this.rightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.rightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.rightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.rightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.rightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.rightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.rightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.rightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.rightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightContainer.Size = new System.Drawing.Size(683, 768);
            this.rightContainer.TabIndex = 0;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_lbl.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_lbl.ForeColor = System.Drawing.Color.White;
            this.login_lbl.Location = new System.Drawing.Point(242, 256);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(198, 53);
            this.login_lbl.TabIndex = 0;
            this.login_lbl.Text = "Login";
            this.login_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username_lbl.ForeColor = System.Drawing.Color.White;
            this.username_lbl.Location = new System.Drawing.Point(239, 332);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(204, 25);
            this.username_lbl.TabIndex = 1;
            this.username_lbl.Text = "Username";
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pass_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pass_lbl.ForeColor = System.Drawing.Color.White;
            this.pass_lbl.Location = new System.Drawing.Point(239, 392);
            this.pass_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(204, 25);
            this.pass_lbl.TabIndex = 2;
            this.pass_lbl.Text = "Password";
            // 
            // username_txt
            // 
            this.username_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_txt.Location = new System.Drawing.Point(239, 357);
            this.username_txt.Margin = new System.Windows.Forms.Padding(0);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(204, 33);
            this.username_txt.TabIndex = 4;
            // 
            // password_txt
            // 
            this.password_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_txt.Location = new System.Drawing.Point(239, 417);
            this.password_txt.Margin = new System.Windows.Forms.Padding(0);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(204, 33);
            this.password_txt.TabIndex = 5;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // signin_btn
            // 
            this.signin_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.signin_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signin_btn.Location = new System.Drawing.Point(368, 455);
            this.signin_btn.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(75, 29);
            this.signin_btn.TabIndex = 6;
            this.signin_btn.Text = "SignIn";
            this.signin_btn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.passReset_lbl, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(239, 487);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 25);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Forgot";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passReset_lbl
            // 
            this.passReset_lbl.AutoSize = true;
            this.passReset_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passReset_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.passReset_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.passReset_lbl.Location = new System.Drawing.Point(100, 0);
            this.passReset_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.passReset_lbl.Name = "passReset_lbl";
            this.passReset_lbl.Size = new System.Drawing.Size(100, 25);
            this.passReset_lbl.TabIndex = 1;
            this.passReset_lbl.Text = "Password?";
            this.passReset_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login_UC";
            this.Size = new System.Drawing.Size(1366, 768);
            this.ucContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.leftContainer.ResumeLayout(false);
            this.leftContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aradashiLogo_pic)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aradaLogo_pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.rightContainer.ResumeLayout(false);
            this.rightContainer.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ucContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel leftContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox aradashiLogo_pic;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label footer_lbl;
        private System.Windows.Forms.PictureBox aradaLogo_pic;
        private System.Windows.Forms.TableLayoutPanel rightContainer;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label passReset_lbl;
    }
}
