using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace List_of_student
{
    public partial class Registration : Form
    {
        // Define the characters and length for the username
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private const int Length = 10;
        private string Username { get; set; }
        private string Password { get; set; }
        private string GenerateCodeRegistration { get; set; }
        // Create a random object
        private static Random random = new Random();
        public Registration()
        {
            InitializeComponent();
            GenerateCodeRegistration = "";
        }
        public static string Generate()
        {
            // Create a string builder to store the username
            StringBuilder builder = new StringBuilder();

            // Loop for the length of the username
            for (int i = 0; i < Length; i++)
            {
                // Append a random character from the chars string
                builder.Append(Chars[random.Next(Chars.Length)]);
            }

            // Return the username as a string
            return builder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != "" &&txtUsername.Text != "")
            {
                Username = txtUsername.Text;
                Password = txtPassword.Text;
                for (int i = 0; i < Username.Length; i++)
                    switch (Username[i])
                    {
                        case 'A':
                        case 'a':
                            GenerateCodeRegistration += "gAD";
                            break;
                        case 'B':
                        case 'b':
                            GenerateCodeRegistration += "fBE";
                            break;
                        case 'C':
                        case 'c':
                            GenerateCodeRegistration += "vCT";
                            break;
                        case 'D':
                        case 'd':
                            GenerateCodeRegistration += "kDL";
                            break;
                        case 'E':
                        case 'e':
                            GenerateCodeRegistration += "rEA";
                            break;
                        case 'F':
                        case 'f':
                            GenerateCodeRegistration += "hFZ";
                            break;
                        case 'G':
                        case 'g':
                            GenerateCodeRegistration += "lGY";
                            break;
                        case 'H':
                        case 'h':
                            GenerateCodeRegistration += "pHI";
                            break;
                        case 'I':
                        case 'i':
                            GenerateCodeRegistration += "uID";
                            break;
                        case 'J':
                        case 'j':
                            GenerateCodeRegistration += "wJS";
                            break;
                        case 'K':
                        case 'k':
                            GenerateCodeRegistration += "yKQ";
                            break;
                        case 'L':
                        case 'l':
                            GenerateCodeRegistration += "fLM";
                            break;
                        case 'M':
                        case 'm':
                            GenerateCodeRegistration += "zMD";
                            break;
                        case 'N':
                        case 'n':
                            GenerateCodeRegistration += "sNM";
                            break;
                        case 'O':
                        case 'o':
                            GenerateCodeRegistration += "wOR";
                            break;
                        case 'P':
                        case 'p':
                            GenerateCodeRegistration += "uPD";
                            break;
                        case 'Q':
                        case 'q':
                            GenerateCodeRegistration += "xQF";
                            break;
                        case 'R':
                        case 'r':
                            GenerateCodeRegistration += "vRG";
                            break;
                        case 'S':
                        case 's':
                            GenerateCodeRegistration += "gSF";
                            break;
                        case 'T':
                        case 't':
                            GenerateCodeRegistration += "iTO";
                            break;
                        case 'U':
                        case 'u':
                            GenerateCodeRegistration += "bUG";
                            break;
                        case 'V':
                        case 'v':
                            GenerateCodeRegistration += "vVD";
                            break;
                        case 'W':
                        case 'w':
                            GenerateCodeRegistration += "zWX";
                            break;
                        case 'X':
                        case 'x':
                            GenerateCodeRegistration += "vXD";
                            break;
                        case 'Y':
                        case 'y':
                            GenerateCodeRegistration += "kYH";
                            break;
                        case 'Z':
                        case 'z':
                            GenerateCodeRegistration += "oZM";
                            break;
                        case '0':
                            GenerateCodeRegistration += "101";
                            break;
                        case '1':
                            GenerateCodeRegistration += "111";
                            break;
                        case '2':
                            GenerateCodeRegistration += "121";
                            break;
                        case '3':
                            GenerateCodeRegistration += "131";
                            break;
                        case '4':
                            GenerateCodeRegistration += "141";
                            break;
                        case '5':
                            GenerateCodeRegistration += "151";
                            break;
                        case '6':
                            GenerateCodeRegistration += "161";
                            break;
                        case '7':
                            GenerateCodeRegistration += "171";
                            break;
                        case '8':
                            GenerateCodeRegistration += "181";
                            break;
                        case '9':
                            GenerateCodeRegistration += "191";
                            break;
                    }
                GenerateCodeRegistration += "@";
                for (int i = 0; i < Password.Length; i++)
                    switch (Password[i])
                    {
                        case 'A':
                        case 'a':
                            GenerateCodeRegistration += "gAD";
                            break;
                        case 'B':
                        case 'b':
                            GenerateCodeRegistration += "fBE";
                            break;
                        case 'C':
                        case 'c':
                            GenerateCodeRegistration += "vCT";
                            break;
                        case 'D':
                        case 'd':
                            GenerateCodeRegistration += "kDL";
                            break;
                        case 'E':
                        case 'e':
                            GenerateCodeRegistration += "rEA";
                            break;
                        case 'F':
                        case 'f':
                            GenerateCodeRegistration += "hFZ";
                            break;
                        case 'G':
                        case 'g':
                            GenerateCodeRegistration += "lGY";
                            break;
                        case 'H':
                        case 'h':
                            GenerateCodeRegistration += "pHI";
                            break;
                        case 'I':
                        case 'i':
                            GenerateCodeRegistration += "uID";
                            break;
                        case 'J':
                        case 'j':
                            GenerateCodeRegistration += "wJS";
                            break;
                        case 'K':
                        case 'k':
                            GenerateCodeRegistration += "yKQ";
                            break;
                        case 'L':
                        case 'l':
                            GenerateCodeRegistration += "fLM";
                            break;
                        case 'M':
                        case 'm':
                            GenerateCodeRegistration += "zMD";
                            break;
                        case 'N':
                        case 'n':
                            GenerateCodeRegistration += "sNM";
                            break;
                        case 'O':
                        case 'o':
                            GenerateCodeRegistration += "wOR";
                            break;
                        case 'P':
                        case 'p':
                            GenerateCodeRegistration += "uPD";
                            break;
                        case 'Q':
                        case 'q':
                            GenerateCodeRegistration += "xQF";
                            break;
                        case 'R':
                        case 'r':
                            GenerateCodeRegistration += "vRG";
                            break;
                        case 'S':
                        case 's':
                            GenerateCodeRegistration += "gSF";
                            break;
                        case 'T':
                        case 't':
                            GenerateCodeRegistration += "iTO";
                            break;
                        case 'U':
                        case 'u':
                            GenerateCodeRegistration += "bUG";
                            break;
                        case 'V':
                        case 'v':
                            GenerateCodeRegistration += "vVD";
                            break;
                        case 'W':
                        case 'w':
                            GenerateCodeRegistration += "zWX";
                            break;
                        case 'X':
                        case 'x':
                            GenerateCodeRegistration += "vXD";
                            break;
                        case 'Y':
                        case 'y':
                            GenerateCodeRegistration += "kYH";
                            break;
                        case 'Z':
                        case 'z':
                            GenerateCodeRegistration += "oZM";
                            break;
                        case '0':
                            GenerateCodeRegistration += "101";
                            break;
                        case '1':
                            GenerateCodeRegistration += "111";
                            break;
                        case '2':
                            GenerateCodeRegistration += "121";
                            break;
                        case '3':
                            GenerateCodeRegistration += "131";
                            break;
                        case '4':
                            GenerateCodeRegistration += "141";
                            break;
                        case '5':
                            GenerateCodeRegistration += "151";
                            break;
                        case '6':
                            GenerateCodeRegistration += "161";
                            break;
                        case '7':
                            GenerateCodeRegistration += "171";
                            break;
                        case '8':
                            GenerateCodeRegistration += "181";
                            break;
                        case '9':
                            GenerateCodeRegistration += "191";
                            break;
                    }
                StreamWriter sw = new StreamWriter(Application.StartupPath + $@"\Data\Users\GenerationCode.txt");
                sw.Write(GenerateCodeRegistration);
                sw.Close();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                GenerateCodeRegistration = textBox1.Text;
                StreamWriter sw = new StreamWriter(Application.StartupPath + $@"\Data\Users\GenerationCode.txt");
                sw.Write(GenerateCodeRegistration);
                sw.Close();
                Close();
            }
        }
    }
}
