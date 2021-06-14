
namespace ChapooUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbl_Error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_WachtVer = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoginAsAdmin = new System.Windows.Forms.Button();
            this.btnLoginAsKeuken = new System.Windows.Forms.Button();
            this.btnLoginAsBarman = new System.Windows.Forms.Button();
            this.btnLoginAsBediening = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(238, 586);
            this.lbl_Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 65);
            this.lbl_Error.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.panel1.Location = new System.Drawing.Point(622, 115);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 415);
            this.panel1.TabIndex = 12;
            // 
            // lbl_WachtVer
            // 
            this.lbl_WachtVer.AutoSize = true;
            this.lbl_WachtVer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WachtVer.ForeColor = System.Drawing.Color.White;
            this.lbl_WachtVer.Location = new System.Drawing.Point(664, 506);
            this.lbl_WachtVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_WachtVer.Name = "lbl_WachtVer";
            this.lbl_WachtVer.Size = new System.Drawing.Size(269, 32);
            this.lbl_WachtVer.TabIndex = 11;
            this.lbl_WachtVer.Text = "Wachtwoord Vergeten?";
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_User.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.txt_User.Location = new System.Drawing.Point(664, 114);
            this.txt_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(374, 71);
            this.txt_User.TabIndex = 10;
            this.txt_User.Text = "Username";
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pass.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.txt_Pass.Location = new System.Drawing.Point(664, 243);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(374, 71);
            this.txt_Pass.TabIndex = 9;
            this.txt_Pass.Text = "Password";
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(664, 358);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(375, 77);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(93, 183);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoginAsAdmin
            // 
            this.btnLoginAsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnLoginAsAdmin.FlatAppearance.BorderSize = 0;
            this.btnLoginAsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLoginAsAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLoginAsAdmin.Location = new System.Drawing.Point(42, 611);
            this.btnLoginAsAdmin.Name = "btnLoginAsAdmin";
            this.btnLoginAsAdmin.Size = new System.Drawing.Size(285, 54);
            this.btnLoginAsAdmin.TabIndex = 14;
            this.btnLoginAsAdmin.Text = "Login als eigenaar";
            this.btnLoginAsAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAsAdmin.Click += new System.EventHandler(this.btnLoginAsAdmin_Click);
            // 
            // btnLoginAsKeuken
            // 
            this.btnLoginAsKeuken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnLoginAsKeuken.FlatAppearance.BorderSize = 0;
            this.btnLoginAsKeuken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAsKeuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLoginAsKeuken.ForeColor = System.Drawing.Color.White;
            this.btnLoginAsKeuken.Location = new System.Drawing.Point(362, 555);
            this.btnLoginAsKeuken.Name = "btnLoginAsKeuken";
            this.btnLoginAsKeuken.Size = new System.Drawing.Size(285, 54);
            this.btnLoginAsKeuken.TabIndex = 15;
            this.btnLoginAsKeuken.Text = "Login als Keuken";
            this.btnLoginAsKeuken.UseVisualStyleBackColor = false;
            this.btnLoginAsKeuken.Click += new System.EventHandler(this.btnLoginAsKeuken_Click);
            // 
            // btnLoginAsBarman
            // 
            this.btnLoginAsBarman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnLoginAsBarman.FlatAppearance.BorderSize = 0;
            this.btnLoginAsBarman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAsBarman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLoginAsBarman.ForeColor = System.Drawing.Color.White;
            this.btnLoginAsBarman.Location = new System.Drawing.Point(362, 631);
            this.btnLoginAsBarman.Name = "btnLoginAsBarman";
            this.btnLoginAsBarman.Size = new System.Drawing.Size(285, 54);
            this.btnLoginAsBarman.TabIndex = 16;
            this.btnLoginAsBarman.Text = "Login als Barman";
            this.btnLoginAsBarman.UseVisualStyleBackColor = false;
            this.btnLoginAsBarman.Click += new System.EventHandler(this.btnLoginAsBarman_Click);
            // 
            // btnLoginAsBediening
            // 
            this.btnLoginAsBediening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnLoginAsBediening.FlatAppearance.BorderSize = 0;
            this.btnLoginAsBediening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAsBediening.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLoginAsBediening.ForeColor = System.Drawing.Color.White;
            this.btnLoginAsBediening.Location = new System.Drawing.Point(42, 529);
            this.btnLoginAsBediening.Name = "btnLoginAsBediening";
            this.btnLoginAsBediening.Size = new System.Drawing.Size(285, 54);
            this.btnLoginAsBediening.TabIndex = 17;
            this.btnLoginAsBediening.Text = "Login als bedining";
            this.btnLoginAsBediening.UseVisualStyleBackColor = false;
            this.btnLoginAsBediening.Click += new System.EventHandler(this.btnLoginAsBediening_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1134, 702);
            this.Controls.Add(this.btnLoginAsBediening);
            this.Controls.Add(this.btnLoginAsBarman);
            this.Controls.Add(this.btnLoginAsKeuken);
            this.Controls.Add(this.btnLoginAsAdmin);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_WachtVer);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_WachtVer;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoginAsAdmin;
        private System.Windows.Forms.Button btnLoginAsKeuken;
        private System.Windows.Forms.Button btnLoginAsBarman;
        private System.Windows.Forms.Button btnLoginAsBediening;
    }
}