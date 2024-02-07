using System;
using System.IO;
using System.Windows.Forms;

namespace List_of_student
{
    public partial class EditStudent : UserControl
    {
        private string FolderStudent { get; set; }
        private bool FindingStudent { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        public EditStudent()
        {
            InitializeComponent();
            if(File.Exists(Application.StartupPath + @"\Data\Users\CheckLogin.txt"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Data\Users\CheckLogin.txt");
                string Checker = sr.ReadLine();
                sr.Close();
                if (Checker == "True")
                {
                    StreamReader srData = new StreamReader(Application.StartupPath + @"\Data\Users\Login.txt");
                    string Data = srData.ReadLine();
                    srData.Close();
                    Username = Data.Split(',')[0];
                    Password = Data.Split(',')[1];

                    panel1.Hide();
                }
            }
            FolderStudent = "";
            FindingStudent = false;
        }

        private void btnShowLogin_Click(object sender, EventArgs e)
        {
            lblShowLogin.Hide();
            btnShowLogin.Hide();

            lblCurrentUsername.Enabled = true;
            lblCurrentUsername.Visible = true;

            txtCurrentUsername.Enabled = true;
            txtCurrentUsername.Visible = true;

            lblCurrentPassword.Enabled = true;
            lblCurrentPassword.Visible = true;

            txtCurrentPassword.Enabled = true;
            txtCurrentPassword.Visible = true;

            btnLogin.Enabled = true;
            btnLogin.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + @"\Students\index.txt");
            string index = sr.ReadLine();
            sr.Close();
            if(txtCurrentUsername.Text == "")
            {
                MessageBox.Show("The username or password entered " +
                    "is incorrect or there is no student with this username and password.",
                    "Username and Password",MessageBoxButtons.OK,MessageBoxIcon.Error);
                lblShowLogin.Show();
                btnShowLogin.Show();

                lblCurrentUsername.Enabled = false;
                lblCurrentUsername.Visible = false;

                txtCurrentUsername.Enabled = false;
                txtCurrentUsername.Visible = false;

                lblCurrentPassword.Enabled = false;
                lblCurrentPassword.Visible = false;

                txtCurrentPassword.Enabled = false;
                txtCurrentPassword.Visible = false;

                btnLogin.Enabled = false;
                btnLogin.Visible = false;
            }
            else
            {
                int i = 1;
                for (; i < Convert.ToInt32(index); i++)
                {
                    if (Directory.Exists(Application.StartupPath + @"\Students\S" + i))
                    {
                        
                        string CurrentUsername, CurrentPassword, ReadUsername, ReadPassword;
                        CurrentUsername = txtCurrentUsername.Text;
                        CurrentPassword = txtCurrentPassword.Text;
                        StreamReader srUsername = new StreamReader(Application.StartupPath + @"\Students\S" + i + @"\Username.txt");
                        ReadUsername = srUsername.ReadLine();
                        srUsername.Close();
                        StreamReader srPassword = new StreamReader(Application.StartupPath + @"\Students\S" + i + @"\Password.txt");
                        ReadPassword = srPassword.ReadLine();
                        srPassword.Close();
                        if (CurrentUsername != "")
                        {
                            if (CurrentPassword != "")
                            {
                                if (CurrentUsername == ReadUsername && CurrentPassword == ReadPassword)
                                {
                                    lblCurrentPassword.Visible = false;
                                    lblCurrentPassword.Enabled = false;

                                    lblCurrentUsername.Enabled = false;
                                    lblCurrentUsername.Visible = false;

                                    txtCurrentUsername.Visible = false;
                                    txtCurrentUsername.Enabled = false;

                                    txtCurrentPassword.Visible = false;
                                    txtCurrentPassword.Enabled = false;

                                    btnLogin.Visible = false;
                                    btnLogin.Enabled = false;


                                    lblUsername.Visible = true;
                                    lblUsername.Enabled = true;

                                    lblPassword.Visible = true;
                                    lblPassword.Enabled = true;

                                    txtUsername.Visible = true;
                                    txtUsername.Enabled = true;

                                    txtPassword.Visible = true;
                                    txtPassword.Enabled = true;
                                    FolderStudent = $"S{i}";
                                    FindingStudent = true;
                                    StreamReader srName = new StreamReader(Application.StartupPath + @"\Students\" + FolderStudent + @"\Name.txt");
                                    txtName.Text = srName.ReadLine();
                                    srName.Close();
                                    StreamReader srAge = new StreamReader(Application.StartupPath + @"\Students\" + FolderStudent + @"\Age.txt");
                                    txtAge.Text = srAge.ReadLine();
                                    srAge.Close();
                                    StreamReader srGrade = new StreamReader(Application.StartupPath + @"\Students\" + FolderStudent + @"\Grade.txt");
                                    txtGrade.Text = srGrade.ReadLine();
                                    srGrade.Close();
                                    StreamReader srGender = new StreamReader(Application.StartupPath + @"\Students\" + FolderStudent + @"\Gender.txt");
                                    txtGender.Text = srGender.ReadLine();
                                    srGender.Close();
                                    StreamReader srEntry = new StreamReader(Application.StartupPath + @"\Students\" + FolderStudent + @"\EntryYear.txt");
                                    txtEntryYear.Text = srEntry.ReadLine();
                                    srEntry.Close();
                                    StreamReader srLocation = new StreamReader(Application.StartupPath + @"\Students\" + FolderStudent + @"\Location.txt");
                                    txtLocation.Text = srLocation.ReadLine();
                                    srLocation.Close();
                                    StreamReader srUsernameLogin = new StreamReader(Application.StartupPath + @"\Students\" + FolderStudent + @"\Username.txt");
                                    txtUsername.Text = srUsernameLogin.ReadLine();
                                    srUsernameLogin.Close();
                                    StreamReader srPasswordLogin = new StreamReader(Application.StartupPath + @"\Students\" + FolderStudent + @"\Password.txt");
                                    txtPassword.Text = srPasswordLogin.ReadLine();
                                    srPasswordLogin.Close();
                                }
                            }
                        }
                    }
                }
                if (txtUsername.Enabled == false || txtPassword.Enabled == false)
                {
                    MessageBox.Show("The username or password entered is incorrect ", "Username & Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblShowLogin.Show();
                    btnShowLogin.Show();

                    txtCurrentUsername.Text = "";
                    txtCurrentPassword.Text = "";

                    lblCurrentUsername.Enabled = false;
                    lblCurrentUsername.Visible = false;

                    txtCurrentUsername.Enabled = false;
                    txtCurrentUsername.Visible = false;

                    lblCurrentPassword.Enabled = false;
                    lblCurrentPassword.Visible = false;

                    txtCurrentPassword.Enabled = false;
                    txtCurrentPassword.Visible = false;

                    btnLogin.Enabled = false;
                    btnLogin.Visible = false;


                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tmp = "";
            int i = 1;
            int index;
            StreamReader srIndex = new StreamReader(Application.StartupPath + @"\Students\index.txt");
            index = Convert.ToInt32(srIndex.ReadLine());
            srIndex.Close();
            for (; i <= index; i++)
            {
                if(Directory.Exists(Application.StartupPath + @"\Students\S" + i))
                {
                    StreamReader srSearch = new StreamReader(Application.StartupPath + @"\Students\S" + i + @"\Name.txt");
                    tmp = srSearch.ReadLine();
                    srSearch.Close();
                    if(tmp == txtSearch.Text)
                    {
                        StreamReader srName = new StreamReader(Application.StartupPath + @"\Students\S" + i + @"\Name.txt");
                        txtName.Text = srName.ReadLine();
                        srName.Close();
                        StreamReader srAge = new StreamReader(Application.StartupPath + @"\Students\S" + i + @"\Age.txt");
                        txtAge.Text = srAge.ReadLine();
                        srAge.Close();
                        StreamReader srGrade = new StreamReader(Application.StartupPath + @"\Students\S" + i + @"\Grade.txt");
                        txtGrade.Text = srGrade.ReadLine();
                        srGrade.Close();
                        StreamReader srGender = new StreamReader(Application.StartupPath + @"\Students\S" + i + @"\Gender.txt");
                        txtGender.Text = srGender.ReadLine();
                        srGender.Close();
                        StreamReader srEntry = new StreamReader(Application.StartupPath + @"\Students\S" + i + @"\EntryYear.txt");
                        txtEntryYear.Text = srEntry.ReadLine();
                        srEntry.Close();
                        StreamReader srLocation = new StreamReader(Application.StartupPath + @"\Students\S" + i + @"\Location.txt");
                        txtLocation.Text = srLocation.ReadLine();
                        srLocation.Close();
                        FolderStudent = $"S{i}";
                        FindingStudent = true;
                        break;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(FindingStudent == true)
            {
                if (txtName.Text != "" && txtAge.Text != "" && txtGrade.Text != "" && txtGender.Text != ""
                && txtEntryYear.Text != "" && txtLocation.Text != "")
                {
                    StreamWriter swName = new StreamWriter(Application.StartupPath + @"\Students\" + FolderStudent + @"\Name.txt");
                    swName.Write(txtName.Text);
                    swName.Close();
                    StreamWriter swAge = new StreamWriter(Application.StartupPath + @"\Students\" + FolderStudent + @"\Age.txt");
                    swAge.Write(txtAge.Text);
                    swAge.Close();
                    StreamWriter swGrade = new StreamWriter(Application.StartupPath + @"\Students\" + FolderStudent + @"\Grade.txt");
                    swGrade.Write(txtGrade.Text);
                    swGrade.Close();
                    StreamWriter swGender = new StreamWriter(Application.StartupPath + @"\Students\" + FolderStudent + @"\Gender.txt");
                    swGender.Write(txtGender.Text);
                    swGender.Close();
                    StreamWriter swEntryYear = new StreamWriter(Application.StartupPath + @"\Students\" + FolderStudent + @"\EntryYear.txt");
                    swEntryYear.Write(txtEntryYear.Text);
                    swEntryYear.Close();
                    StreamWriter swLocation = new StreamWriter(Application.StartupPath + @"\Students\" + FolderStudent + @"\Location.txt");
                    swLocation.Write(txtLocation.Text);
                    swLocation.Close();
                }
                if (txtUsername.Enabled == true && txtUsername.Text != "")
                {
                    StreamWriter swUsername = new StreamWriter(Application.StartupPath + @"\Students\" + FolderStudent + @"\Username.txt");
                    swUsername.Write(txtUsername.Text);
                    swUsername.Close();
                }
                if (txtPassword.Enabled == true && txtPassword.Text != "")
                {
                    StreamWriter swPassword = new StreamWriter(Application.StartupPath + @"\Students\" + FolderStudent + @"\Password.txt");
                    swPassword.Write(txtPassword.Text);
                    swPassword.Close();
                }
                foreach (Control x in Controls)
                {
                    if(x is TextBox && x.Name != "txtSearch")
                    {
                        x.Text = "";
                    }
                }
                lblCurrentPassword.Visible = true;
                lblCurrentPassword.Enabled = true;

                lblCurrentUsername.Enabled = true;
                lblCurrentUsername.Visible = true;

                txtCurrentUsername.Visible = true;
                txtCurrentUsername.Enabled = true;

                txtCurrentPassword.Visible = true;
                txtCurrentPassword.Enabled = true;

                btnLogin.Visible = true;
                btnLogin.Enabled = true;


                lblUsername.Visible = false;
                lblUsername.Enabled = false;

                lblPassword.Visible = false;
                lblPassword.Enabled = false;

                txtUsername.Visible = false;
                txtUsername.Enabled = false;

                txtPassword.Visible = false;
                txtPassword.Enabled = false;
            }
            else
            {
                MessageBox.Show("No student information has been entered yet or you have not searched for a student yet");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = ""; txtAge.Text = ""; txtGrade.Text = ""; txtGender.Text = "";
            txtEntryYear.Text = ""; txtLocation.Text = "";
            if (txtUsername.Enabled == true)
                txtUsername.Text = "";
            if (txtPassword.Enabled == true)
                txtPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.BringTopLogin();
        }
        private void txtGrade_TextChanged(object sender, EventArgs e)
        {
            int outnn = 0;
            if (int.TryParse(txtGrade.Text , out outnn))
            {
                if (Convert.ToInt32(txtGrade.Text) > 20)
                    txtGrade.Text = 20.ToString();
                if (Convert.ToInt32(txtGrade.Text) < 0)
                    txtGrade.Text = 0.ToString();
            }
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            if (txtGrade.Text == "")
                txtGrade.Text = "0";
        }
    }
}
