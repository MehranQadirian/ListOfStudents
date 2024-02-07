namespace List_of_student
{
    partial class EditStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtEntryYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowLogin = new System.Windows.Forms.Button();
            this.lblShowLogin = new System.Windows.Forms.Label();
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Foldit", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(271, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please Enter The Student\'s Name In The Box Below";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Foldit", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSearch.Location = new System.Drawing.Point(751, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 43);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtSearch.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.Orange;
            this.txtSearch.Location = new System.Drawing.Point(271, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(474, 43);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtName.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.LightGray;
            this.txtName.Location = new System.Drawing.Point(175, 155);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(362, 43);
            this.txtName.TabIndex = 8;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtAge.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtAge.ForeColor = System.Drawing.Color.LightGray;
            this.txtAge.Location = new System.Drawing.Point(787, 155);
            this.txtAge.MaxLength = 3;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(362, 43);
            this.txtAge.TabIndex = 9;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtGrade.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtGrade.ForeColor = System.Drawing.Color.LightGray;
            this.txtGrade.Location = new System.Drawing.Point(175, 228);
            this.txtGrade.MaxLength = 2;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(362, 43);
            this.txtGrade.TabIndex = 10;
            this.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtGender.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtGender.ForeColor = System.Drawing.Color.LightGray;
            this.txtGender.Location = new System.Drawing.Point(787, 228);
            this.txtGender.MaxLength = 6;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(362, 43);
            this.txtGender.TabIndex = 11;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtLocation.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtLocation.ForeColor = System.Drawing.Color.LightGray;
            this.txtLocation.Location = new System.Drawing.Point(175, 300);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(362, 43);
            this.txtLocation.TabIndex = 12;
            this.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEntryYear
            // 
            this.txtEntryYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtEntryYear.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtEntryYear.ForeColor = System.Drawing.Color.LightGray;
            this.txtEntryYear.Location = new System.Drawing.Point(787, 300);
            this.txtEntryYear.MaxLength = 4;
            this.txtEntryYear.Name = "txtEntryYear";
            this.txtEntryYear.Size = new System.Drawing.Size(362, 43);
            this.txtEntryYear.TabIndex = 13;
            this.txtEntryYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(658, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Entry Year :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(46, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Location :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(658, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(46, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Grade :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(658, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Age :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(46, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Name :";
            // 
            // btnShowLogin
            // 
            this.btnShowLogin.BackColor = System.Drawing.Color.Orange;
            this.btnShowLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLogin.Font = new System.Drawing.Font("Foldit", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnShowLogin.Location = new System.Drawing.Point(700, 586);
            this.btnShowLogin.Name = "btnShowLogin";
            this.btnShowLogin.Size = new System.Drawing.Size(169, 43);
            this.btnShowLogin.TabIndex = 6;
            this.btnShowLogin.Text = "Login";
            this.btnShowLogin.UseVisualStyleBackColor = false;
            this.btnShowLogin.Click += new System.EventHandler(this.btnShowLogin_Click);
            // 
            // lblShowLogin
            // 
            this.lblShowLogin.Font = new System.Drawing.Font("Foldit", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblShowLogin.ForeColor = System.Drawing.Color.Orange;
            this.lblShowLogin.Location = new System.Drawing.Point(45, 571);
            this.lblShowLogin.Name = "lblShowLogin";
            this.lblShowLogin.Size = new System.Drawing.Size(649, 93);
            this.lblShowLogin.TabIndex = 7;
            this.lblShowLogin.Text = "If you want to change your username or password, you must log in using the opposi" +
    "te button";
            this.lblShowLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.AutoSize = true;
            this.lblCurrentUsername.Enabled = false;
            this.lblCurrentUsername.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentUsername.ForeColor = System.Drawing.Color.Silver;
            this.lblCurrentUsername.Location = new System.Drawing.Point(46, 674);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(111, 29);
            this.lblCurrentUsername.TabIndex = 19;
            this.lblCurrentUsername.Text = "Username :";
            this.lblCurrentUsername.Visible = false;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Enabled = false;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblCurrentPassword.Location = new System.Drawing.Point(595, 674);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(181, 29);
            this.lblCurrentPassword.TabIndex = 18;
            this.lblCurrentPassword.Text = "Current Password :";
            this.lblCurrentPassword.Visible = false;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCurrentPassword.Enabled = false;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtCurrentPassword.Location = new System.Drawing.Point(787, 668);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(362, 43);
            this.txtCurrentPassword.TabIndex = 9;
            this.txtCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentPassword.Visible = false;
            // 
            // txtCurrentUsername
            // 
            this.txtCurrentUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCurrentUsername.Enabled = false;
            this.txtCurrentUsername.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtCurrentUsername.ForeColor = System.Drawing.Color.LightGray;
            this.txtCurrentUsername.Location = new System.Drawing.Point(175, 668);
            this.txtCurrentUsername.Name = "txtCurrentUsername";
            this.txtCurrentUsername.Size = new System.Drawing.Size(362, 43);
            this.txtCurrentUsername.TabIndex = 8;
            this.txtCurrentUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentUsername.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Orange;
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Foldit", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.Location = new System.Drawing.Point(980, 717);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(169, 43);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Enabled = false;
            this.lblUsername.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.Silver;
            this.lblUsername.Location = new System.Drawing.Point(46, 380);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 29);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username :";
            this.lblUsername.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Enabled = false;
            this.lblPassword.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblPassword.Location = new System.Drawing.Point(658, 380);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 29);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password :";
            this.lblPassword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtPassword.Location = new System.Drawing.Point(787, 374);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(362, 43);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Foldit Medium", 18F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.Color.LightGray;
            this.txtUsername.Location = new System.Drawing.Point(175, 374);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(362, 43);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Foldit", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEdit.Location = new System.Drawing.Point(980, 437);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 43);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(35)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Foldit Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(787, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 43);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Foldit", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(251, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(703, 100);
            this.label8.TabIndex = 5;
            this.label8.Text = "You must register then login\r\nThen this page will be displayed for you";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(387, 752);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 800);
            this.panel1.TabIndex = 21;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtCurrentUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtEntryYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblCurrentUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblShowLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnShowLogin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "EditStudent";
            this.Size = new System.Drawing.Size(1220, 800);
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtEntryYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShowLogin;
        private System.Windows.Forms.Label lblShowLogin;
        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}
