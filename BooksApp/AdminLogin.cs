using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksApp
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void OnLoadAdminLog(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;
            string pass = passField.Text;

            if(login=="book" && pass=="book")
            {
                AdminWindow admin = new AdminWindow();
                admin.Show();
                this.Close();
            }
            else
            {
                loginMessageField.ForeColor = Color.Red;
                loginMessageField.Text = "Hasło lub login są niepoprawne";
            }
        }
    }
}
