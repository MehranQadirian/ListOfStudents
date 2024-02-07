using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_of_student
{
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserLoginStudent.SetValue(txtUsername.Text, txtPassword.Text);
            UserLoginStudent.SaveLoginUser();
            this.Close();
        }
    }
}
