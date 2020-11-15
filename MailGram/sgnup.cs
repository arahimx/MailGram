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
    public partial class sgnup : Form
    {
        public string name;
        
        public sgnup()
        {
            InitializeComponent();
            
        }
        public DataTable dtmailgrm = new DataTable();

        private void Close_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lgin_lbl_Click(object sender, EventArgs e)
        {
            login sgnin = new login();
            sgnin.Show();
            Close();
        }

        private void frgtpass_lbl_Click(object sender, EventArgs e)
        {
            frgtpss forgetpass = new frgtpss();
            forgetpass.Show();
            Close();

        }

        private void sgnup_btn_Click(object sender, EventArgs e)
        {
            name = Frstname_txtbox.Text + Lstnam_txtbox.Text;


            if (Pass_txtbox.Text == Cpas_txtbox.Text)
            {
                dtmailgrm.Rows.Add("'" + name + "'", "'" + Pass_txtbox.Text + "'");
                err_lbl.Text = "Regsiter successfully, Login Now";
                Close();

                pass_panel.BackColor = Color.CornflowerBlue;
                Pass_lbl.ForeColor = Color.CornflowerBlue;
                Cpass_lbl.ForeColor = Color.CornflowerBlue;
                Cpas_txtbox.ForeColor = Color.CornflowerBlue;
                Pass_txtbox.ForeColor = Color.CornflowerBlue;
                err_lbl.ForeColor = Color.CornflowerBlue;
                Cpass_panel.BackColor = Color.CornflowerBlue;

            }
            else
            {
                pass_panel.BackColor = Color.PaleVioletRed;
                Pass_lbl.ForeColor = Color.PaleVioletRed;
                Cpass_lbl.ForeColor = Color.PaleVioletRed;
                Cpas_txtbox.ForeColor = Color.PaleVioletRed;
                Pass_txtbox.ForeColor = Color.PaleVioletRed;
                err_lbl.ForeColor = Color.PaleVioletRed;
                Cpass_panel.BackColor = Color.PaleVioletRed;
                
                err_lbl.Text = "both password must match";
            }
        }

        private void sgnup_Load(object sender, EventArgs e)
        {
            dtmailgrm.Columns.Add("Name");
            dtmailgrm.Columns.Add("username");
            dtmailgrm.Columns.Add("password");
        }

        private void pass_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Frstname_txtbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Frstname_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Lstnam_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
