using EF_CODEFIRST_WFA.Context;
using EF_CODEFIRST_WFA.Models.Entities;
using EF_CODEFIRST_WFA.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CODEFIRST_WFA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            AppUser appUser = db.appUsers.Where(u => u.UserName == txtUserName.Text && u.Password == txtPassword.Text).First();
            if (appUser != null)
            {
                MessageBox.Show("Panel Sayfasına yönlendiriliyorsunuz");
                Panel panel = new Panel();
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış şifre ");
            }



        }
    }
}
