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
    public partial class pass : Form
    {
        public pass()
        {
            InitializeComponent();
        }

        private void Close_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbmit_btn_Click(object sender, EventArgs e)
        {
            if(inpt_textbox.Text == "123456")
            {
                Hide();
                error_lbl.Text = "";
                Pass_panel.BackColor = Color.CornflowerBlue;
                pass_lbl.ForeColor = Color.CornflowerBlue;
                inpt_textbox.ForeColor = Color.CornflowerBlue;
                error_lbl.ForeColor = Color.CornflowerBlue;
                home home = new home();
                home.Show();
                Hide();


            }
            else
            {
                error_lbl.Text = "Wrong Passcode";
                Pass_panel.BackColor = Color.PaleVioletRed;
                pass_lbl.ForeColor = Color.PaleVioletRed;
                inpt_textbox.ForeColor = Color.PaleVioletRed;
                error_lbl.ForeColor = Color.PaleVioletRed;


            }
        }

        private void logout_lbl_Click(object sender, EventArgs e)
        {
            login sgnin = new login();
            sgnin.Show();
            Hide();
      

        }

        private void pass_Load(object sender, EventArgs e)
        {

        }
    }
}
