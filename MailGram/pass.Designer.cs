namespace MailGram
{
    partial class pass
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
            this.Close_lbl = new System.Windows.Forms.Label();
            this.inpt_textbox = new System.Windows.Forms.TextBox();
            this.Pass_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.logout_lbl = new System.Windows.Forms.Label();
            this.sbmit_btn = new System.Windows.Forms.Button();
            this.error_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.Close_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 24);
            this.panel1.TabIndex = 0;
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
            // inpt_textbox
            // 
            this.inpt_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.inpt_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpt_textbox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpt_textbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.inpt_textbox.Location = new System.Drawing.Point(97, 184);
            this.inpt_textbox.Name = "inpt_textbox";
            this.inpt_textbox.PasswordChar = '•';
            this.inpt_textbox.Size = new System.Drawing.Size(179, 24);
            this.inpt_textbox.TabIndex = 1;
            // 
            // Pass_panel
            // 
            this.Pass_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(179)))), ((int)(((byte)(243)))));
            this.Pass_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(203)))));
            this.Pass_panel.Location = new System.Drawing.Point(97, 211);
            this.Pass_panel.Name = "Pass_panel";
            this.Pass_panel.Size = new System.Drawing.Size(179, 1);
            this.Pass_panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(49, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your local passcode";
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(203)))));
            this.pass_lbl.Location = new System.Drawing.Point(97, 166);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(117, 18);
            this.pass_lbl.TabIndex = 4;
            this.pass_lbl.Text = "Your passcode";
            // 
            // logout_lbl
            // 
            this.logout_lbl.AutoSize = true;
            this.logout_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_lbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.logout_lbl.Location = new System.Drawing.Point(161, 295);
            this.logout_lbl.Name = "logout_lbl";
            this.logout_lbl.Size = new System.Drawing.Size(51, 18);
            this.logout_lbl.TabIndex = 5;
            this.logout_lbl.Text = "log out";
            this.logout_lbl.Click += new System.EventHandler(this.logout_lbl_Click);
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
            this.sbmit_btn.Location = new System.Drawing.Point(136, 245);
            this.sbmit_btn.Name = "sbmit_btn";
            this.sbmit_btn.Size = new System.Drawing.Size(101, 34);
            this.sbmit_btn.TabIndex = 6;
            this.sbmit_btn.Text = "SUBMIT";
            this.sbmit_btn.UseVisualStyleBackColor = false;
            this.sbmit_btn.Click += new System.EventHandler(this.sbmit_btn_Click);
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(118)))), ((int)(((byte)(171)))));
            this.error_lbl.Location = new System.Drawing.Point(115, 216);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 19);
            this.error_lbl.TabIndex = 7;
            // 
            // pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(374, 479);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.sbmit_btn);
            this.Controls.Add(this.logout_lbl);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass_panel);
            this.Controls.Add(this.inpt_textbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.pass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close_lbl;
        private System.Windows.Forms.TextBox inpt_textbox;
        private System.Windows.Forms.Panel Pass_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Label logout_lbl;
        private System.Windows.Forms.Button sbmit_btn;
        private System.Windows.Forms.Label error_lbl;
    }
}

