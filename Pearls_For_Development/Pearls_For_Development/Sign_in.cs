using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; // for hashing and security algorithm.

namespace Pearls_For_Development
{
    public partial class Form1 : Form
    {
        Controller Con_obj;
        private bool _loggedin = false;
        public int User_Type;

        public enum Users
        {
            None = -1,
            Manager = 1,   // this is the admin.  
            SystemHandler = 2, // -- >>> ??
            DataEntry = 3, // Data Entry Employee (DEE).
        };
        // this part of code makes me able to move the window of login screen --> not DOCKED.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        ///  <summary>
        ///  Used to generate hashed strings (EX: Passwords) with a specific algorithm.
        /// </summary>
        private string CheckPassword_Hash(string password)
        {

            const string salt = "r4Nd0m_5A1t";  //They are concatenated to the password to protects against rainbow table attacks.
            HashAlgorithm algorithm = new SHA256Managed();
            string passwordandsalt = password + salt;
            string hashed = Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordandsalt)));
            return hashed;
            // return hashed == "w+0fHMgNFl7jSDJ7WpvRfIQLzfflSi9pPNdiQg+v4/E=";    //The Hash should be stored in the DB
            //Hashes needs a lot of time to be reversed (Brute Force, Dictionary Attacks, Rainbow Tables, etc.)
            //So even if they are stolen from the database, 
            //you should have enough time to notify users to change it
            //before the attacker can use them.
        }
        public Form1()
        {
            InitializeComponent(); // intializing our objects and varaibles.
            Con_obj = new Controller();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            CheckPassword_Hash("yahia");

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string pass = bunifuMetroTextbox2.Text;
            string name = bunifuMetroTextbox1.Text;

            bool result = bunifuMetroTextbox1.Text.All(char.IsLetterOrDigit);// textbox1 ... PASSWORD
            bool result2 = bunifuMetroTextbox2.Text.All(char.IsLetterOrDigit);
            if (!result)
            {
                //     // MessageBox.Show(" Please Enter a Valid Password ! ",
                //"Exit", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                //  }
                //  else if (!result2)
                //  {
                //      MessageBox.Show(" Please Enter a Valid Username ! ",
                //"Exit", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                //  }
                //  else
                //  {
                //  }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }
    }
}
