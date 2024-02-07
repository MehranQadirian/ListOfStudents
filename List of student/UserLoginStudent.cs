using System;
using System.IO;
using System.Windows.Forms;

namespace List_of_student
{
    static class UserLoginStudent
    {
        private static string UsernameID { get; set; }
        private static string PasswordID { get; set; }
        private static object ImageID { get; set; }

        //Set Values
        public static void SetValue(string Username, string Password)
        {
            UsernameID = Username;
            PasswordID = Password;
        }

        public static void SaveLoginUser()
        {
            if (!Directory.Exists(Application.StartupPath + @"\Data\Users"))
                Directory.CreateDirectory(Application.StartupPath + @"\Data\Users");
            StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Data\Users\Login.txt");
            sw.Write($"{UsernameID},{PasswordID}");
            sw.Close();
        }
    }
}
