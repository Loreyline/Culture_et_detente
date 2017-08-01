using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace examen_Culture_et_detente
{
    public partial class FormeEmail : Form
    {
        private bool ValidEmail;
        private string ReaderEmail;
        public FormeEmail()
        {
            InitializeComponent();
        }

        private void buttonValidEmail_Click(object sender, EventArgs e)
        {
            if (ValidEmail)
                MessageBox.Show("Email Valide");
            else
                MessageBox.Show("Email non Valid : le format de votre email doit être example@exemple.fr");
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ReaderEmail = textBoxEmail.Text;
            Regex regexMail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match matchMail = regexMail.Match(ReaderEmail);
            if (matchMail.Success)
               ValidEmail  = true;
            else
               ValidEmail  = false;
        }

        private void buttonCloseEmail_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
