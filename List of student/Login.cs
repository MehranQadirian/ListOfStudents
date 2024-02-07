using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace List_of_student
{
    public partial class Login : UserControl
    {
        private string UsernameID { get; set; }
        private string PasswordID { get; set; }
        private string Checker { get; set; }
        private string RegCode { get; set; }
        public Login()
        {
            InitializeComponent();
            Checker = "False";
            if(File.Exists(Application.StartupPath + @"\Data\Users\CheckLogin.txt"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Data\Users\CheckLogin.txt");
                Checker = sr.ReadLine();
                sr.Close();
            }
            if(Checker == "True")
            {
                StreamReader srData = new StreamReader(Application.StartupPath + @"\Data\Users\Login.txt");
                string Data = srData.ReadLine();
                srData.Close();
                Username.Text = Data.Split(',')[0];
                UsernameID = Data.Split(',')[0];
                PasswordID = Data.Split(',')[1];
                LoginFunction(1);
            }
            else if (Checker == "False")
            {
                if (File.Exists(Application.StartupPath + @"\Data\Users\Login.txt"))
                    btnSignUp.Hide();
                else
                    btnLogin.Hide();
                if(btnSignUp.Visible == true)
                {
                    if (File.Exists(Application.StartupPath + $@"\Data\Users\GenerationCode.txt"))
                    {
                        StreamReader reader = new StreamReader(Application.StartupPath + $@"\Data\Users\GenerationCode.txt");
                        RegCode = reader.ReadLine();
                        reader.Close();
                        string UsernameIDReg = RegCode.Split('@')[0];
                        string PasswordIDReg = RegCode.Split('@')[1];
                        for(int i = 1;i< UsernameIDReg.Length; i++ , i++ , i++)
                        {
                            switch (UsernameIDReg[i])
                            {
                                case 'A':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'B':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'C':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'D':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'E':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'F':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'G':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'H':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'I':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'J':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'K':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'L':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'M':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'N':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'O':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'P':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'Q':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'R':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'S':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'T':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'U':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'V':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'W':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'X':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'Y':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case 'Z':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case '0':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case '1':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case '2':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case '3':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case '4':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case '5':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case '6':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case '7':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case '8':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                                case '9':
                                    UsernameID += UsernameIDReg[i];
                                    break;
                            }
                        }
                        for (int i = 1; i < PasswordIDReg.Length; i++, i++, i++)
                        {
                            switch (PasswordIDReg[i])
                            {
                                case 'A':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'B':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'C':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'D':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'E':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'F':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'G':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'H':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'I':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'J':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'K':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'L':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'M':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'N':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'O':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'P':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'Q':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'R':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'S':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'T':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'U':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'V':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'W':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'X':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'Y':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case 'Z':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case '0':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case '1':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case '2':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case '3':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case '4':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case '5':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case '6':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case '7':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case '8':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                                case '9':
                                    PasswordID += PasswordIDReg[i];
                                    break;
                            }
                        }
                        StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Data\Users\Login.txt");
                        sw.Write($"{UsernameID},{PasswordID}");
                        sw.Close();
                        StreamWriter sw1 = new StreamWriter(Application.StartupPath + @"\Data\Users\CheckLogin.txt");
                        sw1.Write($"True");
                        sw1.Close();
                        File.Delete(Application.StartupPath + $@"\Data\Users\GenerationCode.txt");
                    }
                    label2.Show();
                    label7.Hide();
                    label8.Hide();
                    txtPassword.Hide();
                    txtUsername.Hide();
                }
                if(btnLogin.Visible == true)
                {
                    label2.Hide();
                    label7.Show();
                    label8.Show();
                    txtPassword.Show();
                    txtUsername.Show();
                }
            }
            if (File.Exists(Application.StartupPath + @"\Data\Users\ProfileImage.png"))
            {
                Bitmap img = new Bitmap(Application.StartupPath + @"\Data\Users\ProfileImage.png");
                Image newimg = Image.FromHbitmap(img.GetHbitmap());
                UserProfile.Image = newimg;
                img.Dispose();
            }
            else
                UserProfile.Image = Properties.Resources.User;
        }
        private void LoginFunction(int Entry)
        {
            if(File.Exists(Application.StartupPath + @"\Data\Users\Login.txt"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Data\Users\Login.txt");
                string Data = sr.ReadLine();
                sr.Close();
                UsernameID = Data.Split(',')[0];
                PasswordID = Data.Split(',')[1];
                if(Entry == 0)
                {
                    if (UsernameID == txtUsername.Text && PasswordID == txtPassword.Text)
                    {
                        btnSignUp.Hide();
                        btnLogin.Hide();

                        txtPassword.Hide();
                        txtUsername.Hide();
                        label7.Hide();
                        label8.Hide();
                        label1.Hide();

                        UserProfile.Show();

                        btnChangePass.Show();
                        btnDelAccount.Show();

                        button1.Show();
                        button2.Show();
                        button3.Show();

                        Username.Show();
                        Username.Text = UsernameID;

                        StreamWriter swCheckLogin = new StreamWriter(Application.StartupPath + @"\Data\Users\CheckLogin.txt");
                        swCheckLogin.Write("True");
                        swCheckLogin.Close();
                        Application.Restart();
                    }
                }
                if(Entry == 1)
                {
                    btnSignUp.Hide();
                    btnLogin.Hide();

                    txtPassword.Hide();
                    txtUsername.Hide();
                    label7.Hide();
                    label8.Hide();
                    label1.Show();

                    UserProfile.Show();

                    btnChangePass.Show();
                    btnDelAccount.Show();

                    button1.Show();
                    button2.Show();
                    button3.Show();

                    Username.Show();
                    Username.Text = UsernameID;

                    StreamWriter swCheckLogin = new StreamWriter(Application.StartupPath + @"\Data\Users\CheckLogin.txt");
                    swCheckLogin.Write("True");
                    swCheckLogin.Close();
                }
                if (Entry == 2)
                {
                    btnSignUp.Hide();
                    btnLogin.Hide();

                    txtPassword.Hide();
                    txtUsername.Hide();
                    label7.Hide();
                    label8.Hide();
                    label1.Hide();

                    UserProfile.Show();

                    btnChangePass.Show();
                    btnDelAccount.Show();

                    button1.Show();
                    button2.Show();
                    button3.Show();

                    Username.Show();
                    Username.Text = UsernameID;

                    StreamWriter swCheckLogin = new StreamWriter(Application.StartupPath + @"\Data\Users\CheckLogin.txt");
                    swCheckLogin.Write("True");
                    swCheckLogin.Close();
                    Application.Restart();
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var image = sender as PictureBox;
            UserProfile.Image = image.Image;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserProfile.Visible == true)
            {
                if (File.Exists(Application.StartupPath + @"\Data\Users\ProfileImage.png"))
                    File.Delete(Application.StartupPath + @"\Data\Users\ProfileImage.png");
                UserProfile.Image.Save(Application.StartupPath + @"\Data\Users\ProfileImage.png");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.png)|*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                UserProfile.Image = new Bitmap(open.FileName);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginFunction(0);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserSignUp signUp = new UserSignUp();
            signUp.ShowDialog();
            LoginFunction(2);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Data\Users\CheckLogin.txt");
            sw.Write("False");
            sw.Close();
            Application.Restart();
        }

        private void btnCurrentPass_Click(object sender, EventArgs e)
        {
            if(btnSetPassword.Visible == false)
            {
                lblCurrentPass.Show();
                lblNewPass.Show();

                txtCurrentPass.Show();
                txtNewPassword.Show();

                btnSetPassword.Show();
            }
            else
            {
                lblCurrentPass.Hide();
                lblNewPass.Hide();

                txtCurrentPass.Hide();
                txtNewPassword.Hide();

                btnSetPassword.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Visible == false)
            {
                tableLayoutPanel1.Show();
                label1.Text = "Pictures List ▲";
            }
            else
            {
                tableLayoutPanel1.Hide();
                label1.Text = "Pictures List ▼";
            }
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            if(txtCurrentPass.Text == PasswordID)
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Data\Users\Login.txt");
                sw.Write($"{UsernameID},{txtNewPassword.Text}");
                sw.Close();
                txtCurrentPass.Hide();
                txtNewPassword.Hide();

                lblCurrentPass.Hide();
                lblNewPass.Hide();

                btnSetPassword.Hide();
            }
        }

        private void DelAccount_Click(object sender, EventArgs e)
        {
            if(File.Exists(Application.StartupPath + $@"\Data\Users\ProfileImage.png"))
                File.Delete(Application.StartupPath + $@"\Data\Users\ProfileImage.png");
            if (File.Exists(Application.StartupPath + $@"\Data\Users\Login.txt"))
                File.Delete(Application.StartupPath + $@"\Data\Users\Login.txt");
            if (File.Exists(Application.StartupPath + $@"\Data\Users\CheckLogin.txt"))
                File.Delete(Application.StartupPath + $@"\Data\Users\CheckLogin.txt");
            Application.Restart();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
