using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace List_of_student
{
    public partial class Form1 : Form
    {
        private bool CheckWideMenu { get; set; }
        private int WideCounter { get; set; }
        private int WidthHight { get; set; }
        private int WidthLow { get; set; }
        private int WidthOpenTap { get; set; }
        public Form1()
        {
            InitializeComponent();
            WideCounter = 0;
            CheckWideMenu = true;
            WidthHight = pnlMenu.Width;
            WidthLow = pnlMenu.Width - 150;
            groupBox1.Enabled = true;
        }

        private void CheckPnlMenu(bool Checker)
        {
            if (Checker == false && pnlMenu.Width == WidthHight)
                Collapse.Start();
            if (Checker == true && pnlMenu.Width == WidthLow)
                Expand.Start();
        }

        private void ChangeValColEx()
        {
            if  (CheckWideMenu == true)
                CheckWideMenu = false;
            else
                CheckWideMenu = true;
            CheckPnlMenu(CheckWideMenu);
        }

        private void Collapse_Tick(object sender, EventArgs e)
        {
            WideCounter++;
            pnlMenu.Width -= 15;
            foreach (Control x in pnlMenu.Controls)
            {
                if(x is Button && x.Tag == "MenuBtn")
                {
                    x.Text = "";
                }
            }
            if (WideCounter == 10)
            {
                btnAboutUs.ImageAlign = ContentAlignment.MiddleCenter;
                btnAdd.ImageAlign = ContentAlignment.MiddleCenter;
                btnDelete.ImageAlign = ContentAlignment.MiddleCenter;
                btnEdit.ImageAlign = ContentAlignment.MiddleCenter;
                btnMenu.ImageAlign = ContentAlignment.MiddleCenter;
                btnMenu.Image = Properties.Resources.Collaps;
                btnSearch.ImageAlign = ContentAlignment.MiddleCenter;
                btnList.ImageAlign = ContentAlignment.MiddleCenter;
                btnLogin.ImageAlign = ContentAlignment.MiddleCenter;
                WideCounter = 0;
                Collapse.Stop();
            }
        }
        private void Expand_Tick(object sender, EventArgs e)
        {
            WideCounter++;
            pnlMenu.Width += 15;
            btnAboutUs.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnEdit.ImageAlign = ContentAlignment.MiddleRight;
            btnMenu.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnList.ImageAlign = ContentAlignment.MiddleRight;
            btnLogin.ImageAlign = ContentAlignment.MiddleRight;
            if (WideCounter == 10)
            {
                btnAboutUs.Text = "ABOUT US";
                btnAdd.Text = "ADD STUDENT";
                btnDelete.Text = "DEL STUDENT";
                btnEdit.Text = "EDIT STUDENT";
                btnMenu.Text = "MENU";
                btnSearch.Text = "SEARCH STUDENT";
                btnList.Text = "LIST OF STUDENT";
                btnLogin.Text = "LOGIN";
                btnMenu.Image = Properties.Resources.Expand;
                WideCounter = 0;
                Expand.Stop();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            foreach(Control x in pnlShow.Controls)
            {
                if (x is UserControl)
                    x.Hide();
            }
            if (groupBox1.Enabled == true)
                ChangeValColEx();
            groupBox1.Enabled = true;
            
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            ResetOpenTap();
            MovementOpenTapProgress(btnAdd.Location.Y);
            foreach (Control x in pnlShow.Controls)
            {
                if (x is UserControl)
                    x.Hide();
            }
            groupBox1.Enabled = false;
            addStudent1.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ResetOpenTap();
            MovementOpenTapProgress(btnList.Location.Y);
            foreach (Control x in pnlShow.Controls)
            {
                if (x is UserControl)
                    x.Hide();
            }
            groupBox1.Enabled = false;
            listOfTheStudents1.Show();
        }
        private void btnAdd_Enter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void btnAdd_Leave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void btnList_Enter(object sender, EventArgs e)
        {
            btnList.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void btnList_Leave(object sender, EventArgs e)
        {
            btnList.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void btnEdit_Enter(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void btnEdit_Leave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void btnDelete_Enter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void btnDelete_Leave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void btnSearch_Enter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void btnSearch_Leave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void MovementOpenTapProgress( int y)
        {
            OpenTap.Location = new Point(0, y + 80);
            OpenTap.Visible = true;
            OpenTapTimer.Start();
        }
        private void ResetOpenTap()
        {
            WidthOpenTap = 0;
            OpenTap.Width = 0;
            OpenTap.Visible = false;
        }
        private void OpenTapTimer_Tick(object sender, EventArgs e)
        {
            WidthOpenTap++;
            OpenTap.Width += 15;
            if (WidthOpenTap == 12)
            {
                OpenTapTimer.Stop();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ResetOpenTap();
            MovementOpenTapProgress(btnEdit.Location.Y);
            foreach (Control x in pnlShow.Controls)
            {
                if (x is UserControl)
                    x.Hide();
            }
            groupBox1.Enabled = false;
            editStudent1.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ResetOpenTap();
            MovementOpenTapProgress(btnDelete.Location.Y);
            foreach (Control x in pnlShow.Controls)
            {
                if (x is UserControl)
                    x.Hide();
            }
            groupBox1.Enabled = false;
            deleteStudents1.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetOpenTap();
            MovementOpenTapProgress(btnSearch.Location.Y);
            foreach (Control x in pnlShow.Controls)
            {
                if (x is UserControl)
                    x.Hide();
            }
            groupBox1.Enabled = false;
            listOfTheStudents1.Show();
        }
        public void BringTopLogin()
        {
            ResetOpenTap();
            MovementOpenTapProgress(btnLogin.Location.Y);
            foreach (Control x in pnlShow.Controls)
            {
                if (x is UserControl)
                    x.Hide();
            }
            groupBox1.Enabled = false;
            login1.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ResetOpenTap();
            MovementOpenTapProgress(btnLogin.Location.Y);
            foreach (Control x in pnlShow.Controls)
            {
                if (x is UserControl)
                    x.Hide();
            }
            groupBox1.Enabled = false;
            login1.Show();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
            if (File.Exists(Application.StartupPath + $@"\Data\Users\GenerationCode.txt"))
                Application.Restart();
        }
    }
}
