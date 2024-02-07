using System;
using System.IO;
using System.Windows.Forms;

namespace List_of_student
{
    public partial class ListOfTheStudents : UserControl
    {
        private bool KeySearch { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private string Checker { get; set; }
        public ListOfTheStudents()
        {
            InitializeComponent();
            Checker = "False";
            if (File.Exists(Application.StartupPath + @"\Data\Users\CheckLogin.txt"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Data\Users\CheckLogin.txt");
                Checker = sr.ReadLine();
                sr.Close();
                
            }
            if (Checker == "True")
            {
                StreamReader srData = new StreamReader(Application.StartupPath + @"\Data\Users\Login.txt");
                string Data = srData.ReadLine();
                srData.Close();
                Username = Data.Split(',')[0];
                Password = Data.Split(',')[1];

                panel1.Hide();
            }
            KeySearch = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int i = 1 , index = 0;
            StreamReader srindex = new StreamReader(Application.StartupPath + @"\Students\index.txt");
            index = Convert.ToInt32(srindex.ReadLine());
            srindex.Close();
            if (txtSearch.Text != "")
            {
                for (; i <= index && Directory.Exists(Application.StartupPath + "\\Students\\S" + i); i++)
                {
                    StreamReader srName = new StreamReader(Application.StartupPath
                        + "\\Students\\S" + i + "\\Name.txt");
                    string tmp = srName.ReadLine();
                    srName.Close();
                    if (txtSearch.Text == tmp)
                    {
                        string Name = tmp, Age, Grade, Gender, EntryYear, Location;
                        StreamReader srAge = new StreamReader(Application.StartupPath
                        + "\\Students\\S" + i + "\\Age.txt");
                        Age = srAge.ReadLine();
                        srAge.Close();
                        StreamReader srGrade = new StreamReader(Application.StartupPath
                        + "\\Students\\S" + i + "\\Grade.txt");
                        Grade = srGrade.ReadLine();
                        srGrade.Close();
                        StreamReader srGender = new StreamReader(Application.StartupPath
                        + "\\Students\\S" + i + "\\Gender.txt");
                        Gender = srGender.ReadLine();
                        srGender.Close();
                        StreamReader srEntryYear = new StreamReader(Application.StartupPath
                        + "\\Students\\S" + i + "\\EntryYear.txt");
                        EntryYear = srEntryYear.ReadLine();
                        srEntryYear.Close();
                        StreamReader srLocation = new StreamReader(Application.StartupPath
                        + "\\Students\\S" + i + "\\Location.txt");
                        Location = srLocation.ReadLine();
                        srLocation.Close();
                        dataGridView1.Rows.Add($"Student {i}", Name, Age, Grade, Gender, EntryYear, Location);
                    }
                }
            }
            else if (txtSearch.Text == "")
            {
                for (; i <= index && Directory.Exists(Application.StartupPath + "\\Students\\S" + i); i++)
                {
                    string Name , Age, Grade, Gender, EntryYear, Location;
                    StreamReader srName = new StreamReader(Application.StartupPath
                    + "\\Students\\S" + i + "\\Name.txt");
                    Name = srName.ReadLine();
                    srName.Close();
                    StreamReader srAge = new StreamReader(Application.StartupPath
                    + "\\Students\\S" + i + "\\Age.txt");
                    Age = srAge.ReadLine();
                    srAge.Close();
                    StreamReader srGrade = new StreamReader(Application.StartupPath
                    + "\\Students\\S" + i + "\\Grade.txt");
                    Grade = srGrade.ReadLine();
                    srGrade.Close();
                    StreamReader srGender = new StreamReader(Application.StartupPath
                    + "\\Students\\S" + i + "\\Gender.txt");
                    Gender = srGender.ReadLine();
                    srGender.Close();
                    StreamReader srEntryYear = new StreamReader(Application.StartupPath
                    + "\\Students\\S" + i + "\\EntryYear.txt");
                    EntryYear = srEntryYear.ReadLine();
                    srEntryYear.Close();
                    StreamReader srLocation = new StreamReader(Application.StartupPath
                    + "\\Students\\S" + i + "\\Location.txt");
                    Location = srLocation.ReadLine();
                    srLocation.Close();
                    dataGridView1.Rows.Add($"Student {i}", Name, Age, Grade, Gender, EntryYear, Location);

                }
            }
        }

        private void ListOfTheStudents_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.E:
                    button1.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
