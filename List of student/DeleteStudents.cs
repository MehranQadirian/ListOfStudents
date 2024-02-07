using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace List_of_student
{
    public partial class DeleteStudents : UserControl
    {
        private int index;
        private string Username { get; set; }
        private string Password { get; set; }
        private string Checker { get; set; }
        public DeleteStudents()
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
            index = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void Update()
        {
            dataGridView1.Rows.Clear();
            int i = 1;
            StreamReader srindex = new StreamReader(Application.StartupPath + @"\Students\index.txt");
            index = Convert.ToInt32(srindex.ReadLine());
            srindex.Close();
            for (; i <= index; i++)
            {
                string Name, Age, Grade, Gender, EntryYear, Location;
                if (Directory.Exists(Application.StartupPath + "\\Students\\S" + i))
                    if (File.Exists(Application.StartupPath + $@"\Students\S{i}\Name.txt"))
                    {
                        StreamReader srName = new StreamReader(Application.StartupPath
                        + "\\Students\\S" + i + "\\Name.txt");
                        Name = srName.ReadLine();
                        srName.Close();
                        StreamReader srAge = new StreamReader(Application.StartupPath
                        + "\\Students\\S" + i + "\\Age.txt");
                        Age = srAge.ReadLine();
                        srAge.Close();
                        StreamReader srGender = new StreamReader(Application.StartupPath
                        + "\\Students\\S" + i + "\\Gender.txt");
                        Gender = srGender.ReadLine();
                        srGender.Close();
                        StreamReader srEntryYear = new StreamReader(Application.StartupPath
                        + "\\Students\\S" + i + "\\EntryYear.txt");
                        EntryYear = srEntryYear.ReadLine();
                        srEntryYear.Close();
                        dataGridView1.Rows.Add($"Student {i}", Name, Age, Gender, EntryYear);
                    }
                    else
                    {
                        dataGridView1.Rows.Add($"Student {i}", "", "", "", "");
                    }
                else
                {
                    dataGridView1.Rows.Add($"Student {i}", "Deleted", "Deleted", "Deleted", "Deleted");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDel.Text != "")
            {
                string StudentFolder = $"S{txtDel.Text}";
                if (File.Exists(Application.StartupPath + $@"\Students\{StudentFolder}\Name.txt"))
                    File.Delete(Application.StartupPath + $@"\Students\{StudentFolder}\Name.txt");

                if (File.Exists(Application.StartupPath + $@"\Students\{StudentFolder}\Age.txt"))
                    File.Delete(Application.StartupPath + $@"\Students\{StudentFolder}\Age.txt");

                if (File.Exists(Application.StartupPath + $@"\Students\{StudentFolder}\Grade.txt"))
                    File.Delete(Application.StartupPath + $@"\Students\{StudentFolder}\Grade.txt");

                if (File.Exists(Application.StartupPath + $@"\Students\{StudentFolder}\Gender.txt"))
                    File.Delete(Application.StartupPath + $@"\Students\{StudentFolder}\Gender.txt");

                if (File.Exists(Application.StartupPath + $@"\Students\{StudentFolder}\EntryYear.txt"))
                    File.Delete(Application.StartupPath + $@"\Students\{StudentFolder}\EntryYear.txt");

                if (File.Exists(Application.StartupPath + $@"\Students\{StudentFolder}\Location.txt"))
                    File.Delete(Application.StartupPath + $@"\Students\{StudentFolder}\Location.txt");

                if (File.Exists(Application.StartupPath + $@"\Students\{StudentFolder}\Username.txt"))
                    File.Delete(Application.StartupPath + $@"\Students\{StudentFolder}\Username.txt");

                if (File.Exists(Application.StartupPath + $@"\Students\{StudentFolder}\Password.txt"))
                    File.Delete(Application.StartupPath + $@"\Students\{StudentFolder}\Password.txt");

                Directory.Delete(Application.StartupPath + $@"\Students\{StudentFolder}");
                for (int i = Convert.ToInt32(txtDel.Text); i <= index && Directory.Exists(Application.StartupPath + $@"\Students\S{i + 1}"); i++)
                {
                    // آدرس پوشه ای که می خواهیم حذف کنیم
                    string folderToDelete = Application.StartupPath + $@"\Students\S{i}";

                    // آدرس پوشه ای که می خواهیم تغییر نام دهیم
                    string folderToRename = Application.StartupPath + $@"\Students\S{i + 1}";
                    // حذف پوشه اول
                    // تغییر نام پوشه دوم به نام پوشه اول
                    Directory.Move(folderToRename, folderToDelete);
                }
                
                index--;
                StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Students\index.txt");
                sw.Write(index);
                sw.Close();
                Update();
            }
        }
        public void RenameDirectory(string originalName, string newName)
        {
            Directory.Move(originalName, newName);
        }
    }
}
