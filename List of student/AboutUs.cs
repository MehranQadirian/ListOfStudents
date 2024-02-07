using System;
using System.IO;
using System.Windows.Forms;

namespace List_of_student
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
            if (!File.Exists(Application.StartupPath + $@"\Data\Users\Login.txt"))
            {
                button1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            Close();
        }
    }
}
