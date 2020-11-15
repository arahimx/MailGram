using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailGram
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Close_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void Pass_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sbmit_btn_Click(object sender, EventArgs e)
        {


            if (Pass_txtbox.Text == "123" && username_txtbox.Text == "admin")
            {
                Username_lbl.Text = "Username";
                pass_lbl.Text = "Password";
                Close();
                home home = new home();
                home.Show();

                //Error colors
                Username_lbl.ForeColor = Color.CornflowerBlue;
                username_txtbox.ForeColor = Color.CornflowerBlue;
                Usernaem_panel.BackColor = Color.CornflowerBlue;
                pass_lbl.ForeColor = Color.CornflowerBlue;
                Pass_txtbox.ForeColor = Color.CornflowerBlue;
                err_lbl.ForeColor = Color.CornflowerBlue;
                Pass_panel.BackColor = Color.CornflowerBlue;
            }
            else
            {

                err_lbl.Text = "wrong username or Password";
                //Error colors
                Username_lbl.ForeColor = Color.PaleVioletRed;
                username_txtbox.ForeColor = Color.PaleVioletRed;
                Usernaem_panel.BackColor = Color.PaleVioletRed;
                pass_lbl.ForeColor = Color.PaleVioletRed;
                Pass_txtbox.ForeColor = Color.PaleVioletRed;
                err_lbl.ForeColor = Color.PaleVioletRed;
                Pass_panel.BackColor = Color.PaleVioletRed;

            }
        }

        private void logout_lbl_Click(object sender, EventArgs e)
        {
            sgnup sgnup = new sgnup();
            sgnup.Show();

            Close();

        }

        private void frgtpass_lbl_Click(object sender, EventArgs e)
        {
            frgtpss forgetpass = new frgtpss();
            forgetpass.Show();

            Close();

        }
    }
}
