namespace MailGram
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Close_lbl = new System.Windows.Forms.Label();
            this.sbmit_btn = new System.Windows.Forms.Button();
            this.sgnup_lbl = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Usernaem_panel = new System.Windows.Forms.Panel();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.Pass_panel = new System.Windows.Forms.Panel();
            this.Pass_txtbox = new System.Windows.Forms.TextBox();
            this.err_lbl = new System.Windows.Forms.Label();
            this.frgtpass_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Close_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 24);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Login";
            // 
            // Close_lbl
            // 
            this.Close_lbl.AutoSize = true;
            this.Close_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Close_lbl.Location = new System.Drawing.Point(353, 4);
            this.Close_lbl.Name = "Close_lbl";
            this.Close_lbl.Size = new System.Drawing.Size(17, 16);
            this.Close_lbl.TabIndex = 0;
            this.Close_lbl.Text = "X";
            this.Close_lbl.Click += new System.EventHandler(this.Close_lbl_Click);
            // 
            // sbmit_btn
            // 
            this.sbmit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbmit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.sbmit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbmit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbmit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sbmit_btn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sbmit_btn.Location = new System.Drawing.Point(139, 267);
            this.sbmit_btn.Name = "sbmit_btn";
            this.sbmit_btn.Size = new System.Drawing.Size(101, 34);
            this.sbmit_btn.TabIndex = 14;
            this.sbmit_btn.Text = "SUBMIT";
            this.sbmit_btn.UseVisualStyleBackColor = false;
            this.sbmit_btn.Click += new System.EventHandler(this.sbmit_btn_Click);
            // 
            // sgnup_lbl
            // 
            this.sgnup_lbl.AutoSize = true;
            this.sgnup_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sgnup_lbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgnup_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.sgnup_lbl.Location = new System.Drawing.Point(157, 366);
            this.sgnup_lbl.Name = "sgnup_lbl";
            this.sgnup_lbl.Size = new System.Drawing.Size(65, 18);
            this.sgnup_lbl.TabIndex = 13;
            this.sgnup_lbl.Text = "Join Now";
            this.sgnup_lbl.Click += new System.EventHandler(this.logout_lbl_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(203)))));
            this.Username_lbl.Location = new System.Drawing.Point(100, 112);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(82, 18);
            this.Username_lbl.TabIndex = 12;
            this.Username_lbl.Text = "Username";
            // 
            // Usernaem_panel
            // 
            this.Usernaem_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(179)))), ((int)(((byte)(243)))));
            this.Usernaem_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(203)))));
            this.Usernaem_panel.Location = new System.Drawing.Point(100, 156);
            this.Usernaem_panel.Name = "Usernaem_panel";
            this.Usernaem_panel.Size = new System.Drawing.Size(179, 1);
            this.Usernaem_panel.TabIndex = 10;
            // 
            // username_txtbox
            // 
            this.username_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.username_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txtbox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txtbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.username_txtbox.Location = new System.Drawing.Point(100, 129);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(179, 24);
            this.username_txtbox.TabIndex = 9;
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(203)))));
            this.pass_lbl.Location = new System.Drawing.Point(100, 178);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(75, 18);
            this.pass_lbl.TabIndex = 18;
            this.pass_lbl.Text = "Password";
            // 
            // Pass_panel
            // 
            this.Pass_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(179)))), ((int)(((byte)(243)))));
            this.Pass_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(203)))));
            this.Pass_panel.Location = new System.Drawing.Point(100, 225);
            this.Pass_panel.Name = "Pass_panel";
            this.Pass_panel.Size = new System.Drawing.Size(179, 1);
            this.Pass_panel.TabIndex = 17;
            // 
            // Pass_txtbox
            // 
            this.Pass_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.Pass_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass_txtbox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_txtbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.Pass_txtbox.Location = new System.Drawing.Point(100, 197);
            this.Pass_txtbox.Name = "Pass_txtbox";
            this.Pass_txtbox.PasswordChar = '•';
            this.Pass_txtbox.Size = new System.Drawing.Size(179, 24);
            this.Pass_txtbox.TabIndex = 16;
            this.Pass_txtbox.TextChanged += new System.EventHandler(this.Pass_txtbox_TextChanged);
            // 
            // err_lbl
            // 
            this.err_lbl.AutoSize = true;
            this.err_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.err_lbl.Location = new System.Drawing.Point(103, 232);
            this.err_lbl.Name = "err_lbl";
            this.err_lbl.Size = new System.Drawing.Size(0, 19);
            this.err_lbl.TabIndex = 19;
            // 
            // frgtpass_lbl
            // 
            this.frgtpass_lbl.AutoSize = true;
            this.frgtpass_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frgtpass_lbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frgtpass_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.frgtpass_lbl.Location = new System.Drawing.Point(131, 319);
            this.frgtpass_lbl.Name = "frgtpass_lbl";
            this.frgtpass_lbl.Size = new System.Drawing.Size(117, 18);
            this.frgtpass_lbl.TabIndex = 13;
            this.frgtpass_lbl.Text = "Forget Password?";
            this.frgtpass_lbl.Click += new System.EventHandler(this.frgtpass_lbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(176, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "OR";
            this.label2.Click += new System.EventHandler(this.logout_lbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter your username and passcode";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(374, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.err_lbl);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.Pass_panel);
            this.Controls.Add(this.Pass_txtbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sbmit_btn);
            this.Controls.Add(this.frgtpass_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sgnup_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.Usernaem_panel);
            this.Controls.Add(this.username_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close_lbl;
        private System.Windows.Forms.Button sbmit_btn;
        private System.Windows.Forms.Label sgnup_lbl;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Panel Usernaem_panel;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Panel Pass_panel;
        private System.Windows.Forms.TextBox Pass_txtbox;
        private System.Windows.Forms.Label err_lbl;
        private System.Windows.Forms.Label frgtpass_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}