using System;
using System.IO;
using System.Windows.Forms;

namespace List_of_student
{
    public partial class AddStudent : UserControl
    {
        private string Username { get; set; }
        private string Password { get; set; }
        public AddStudent()
        {
            InitializeComponent();
            if (File.Exists(Application.StartupPath + @"\Data\Users\CheckLogin.txt"))
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

                    panel2.Hide();
                }
            }
        }

        private void All_TextChanged(object sender, EventArgs e)
        {
            lblShow.Text =
                $"{txtName.Text}\n\n" +
                $"{txtAge.Text}\n\n" +
                $"{txtGrade.Text}\n\n" +
                $"{txtGender.Text}\n\n" +
                $"{txtLocation.Text}\n\n" +
                $"{txtEntryYear.Text}\n\n" +
                $"{txtUsername.Text}\n\n" +
                $"{txtPassword.Text}";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                int i = 1;
                for(; i< 100000000; i++)
                {
                    if (!Directory.Exists(Application.StartupPath + @"\Students\S" + i))
                    {
                        Directory.CreateDirectory(Application.StartupPath + @"\Students\S" + i);
                        if (File.Exists(Application.StartupPath + @"\Students\index.txt"))
                            File.Delete(Application.StartupPath + @"\Students\index.txt");
                        StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Students\index.txt");
                        sw.Write(i);
                        sw.Close();
                        break;
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(Application.StartupPath +
                            @"\Students\S" + i + "\\Name.txt");
                        string Reader = sr.ReadLine();
                        sr.Close();
                        if (Reader == txtName.Text)
                            break;
                    }
                }
                StreamWriter swName = new StreamWriter(Application.StartupPath
                    + @"\Students\S" + i + "\\Name.txt");
                swName.Write($"{txtName.Text}");
                swName.Close();
                StreamWriter swAge = new StreamWriter(Application.StartupPath
                    + @"\Students\S" + i + "\\Age.txt");
                swAge.Write($"{txtAge.Text}");
                swAge.Close();
                StreamWriter swGrade = new StreamWriter(Application.StartupPath
                    + @"\Students\S" + i + "\\Grade.txt");
                swGrade.Write($"{txtGrade.Text}");
                swGrade.Close();
                StreamWriter swGender = new StreamWriter(Application.StartupPath
                    + @"\Students\S" + i + "\\Gender.txt");
                swGender.Write($"{txtGender.Text}");
                swGender.Close();
                StreamWriter swLocation = new StreamWriter(Application.StartupPath
                    + @"\Students\S" + i + "\\Location.txt");
                swLocation.Write($"{txtLocation.Text}");
                swLocation.Close();
                StreamWriter swEntryYear = new StreamWriter(Application.StartupPath
                    + @"\Students\S" + i + "\\EntryYear.txt");
                swEntryYear.Write($"{txtEntryYear.Text}");
                swEntryYear.Close();
                StreamWriter swUsername = new StreamWriter(Application.StartupPath
                    + @"\Students\S" + i + "\\Username.txt");
                swUsername.Write($"{txtUsername.Text}");
                swUsername.Close();
                StreamWriter swPassword = new StreamWriter(Application.StartupPath
                    + @"\Students\S" + i + "\\Password.txt");
                swPassword.Write($"{txtPassword.Text}");
                swPassword.Close();
                lblStatus.Text = $"A student named {txtName.Text.ToUpper()} was added to the list";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if (x is TextBox)
                    x.Text = "";
            }
            lblStatus.Text = "";
        }
    }
}
