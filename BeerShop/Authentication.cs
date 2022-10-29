using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeerShop.Data;
using System.Runtime;
using System.IO;
namespace BeerShop
{
   
    public partial class Authentication : Form
    {
        private string[] UserLog;
        private string[] AdminLog;
        public Authentication()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            if (login_TextBox.Text == UserLog[0] && password_TextBox.Text == UserLog[1])
            {
           
                MainMenu mainMenu = new MainMenu(this);
                mainMenu.Show();
                this.Hide();
             
            }
            else if (login_TextBox.Text == AdminLog[0] && password_TextBox.Text == AdminLog[1])
            {
                AdminPanel adminPanel = new AdminPanel(this);
                adminPanel.Show();
                this.Hide();
            }
            login_TextBox.Clear();
            password_TextBox.Clear();
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            StreamReader stream=new StreamReader(@"login.TXT");
            UserLog = stream.ReadLine().Split(' ');
            AdminLog = stream.ReadLine().Split(' ');
            stream.Close();
        }
    }
}
