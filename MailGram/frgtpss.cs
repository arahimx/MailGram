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
    public partial class frgtpss : Form
    {
        public frgtpss()
        {
            InitializeComponent();
        }

        private void lgn_lbl_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Close_lbl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sgnup_lbl_Click(object sender, EventArgs e)
        {
            sgnup signup = new sgnup();
            signup.Show();
            Close();
        }

        private void sbmit_btn_Click(object sender, EventArgs e)
        {
            login lgin = new login();
            lgin.Show();
        }

        private void frgtpss_Load(object sender, EventArgs e)
        {

        }
    }
}
