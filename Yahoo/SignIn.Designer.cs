namespace Yahoo
{
    partial class SignIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.signin_lbl = new System.Windows.Forms.Label();
            this.ext_lbl = new System.Windows.Forms.Label();
            this.pswd_inp = new System.Windows.Forms.MaskedTextBox();
            this.usern_email_inp = new System.Windows.Forms.MaskedTextBox();
            this.StaySignedin_check = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.forgot_usrname = new System.Windows.Forms.Label();
            this.yahoologo = new System.Windows.Forms.PictureBox();
            this.usernamepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.googlebtn = new ePOSOne.btnProduct.Button_WOC();
            this.createbtn = new ePOSOne.btnProduct.Button_WOC();
            this.signinbtn = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.yahoologo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // signin_lbl
            // 
            this.signin_lbl.AutoSize = true;
            this.signin_lbl.BackColor = System.Drawing.Color.White;
            this.signin_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_lbl.ForeColor = System.Drawing.Color.Black;
            this.signin_lbl.Location = new System.Drawing.Point(133, 96);
            this.signin_lbl.Name = "signin_lbl";
            this.signin_lbl.Size = new System.Drawing.Size(60, 19);
            this.signin_lbl.TabIndex = 1;
            this.signin_lbl.Text = "Sign in";
            // 
            // ext_lbl
            // 
            this.ext_lbl.AutoSize = true;
            this.ext_lbl.BackColor = System.Drawing.Color.White;
            this.ext_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ext_lbl.ForeColor = System.Drawing.Color.Black;
            this.ext_lbl.Location = new System.Drawing.Point(66, 115);
            this.ext_lbl.Name = "ext_lbl";
            this.ext_lbl.Size = new System.Drawing.Size(215, 21);
            this.ext_lbl.TabIndex = 6;
            this.ext_lbl.Text = "using your Yahoo account";
            // 
            // pswd_inp
            // 
            this.pswd_inp.BackColor = System.Drawing.Color.White;
            this.pswd_inp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pswd_inp.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.pswd_inp.ForeColor = System.Drawing.Color.Black;
            this.pswd_inp.Location = new System.Drawing.Point(25, 211);
            this.pswd_inp.Name = "pswd_inp";
            this.pswd_inp.Size = new System.Drawing.Size(275, 18);
            this.pswd_inp.TabIndex = 8;
            this.pswd_inp.MouseEnter += new System.EventHandler(this.pswd_inp_MouseEnter);
            this.pswd_inp.MouseLeave += new System.EventHandler(this.pswd_inp_MouseLeave);
            this.pswd_inp.Validating += new System.ComponentModel.CancelEventHandler(this.pswd_inp_Validating);
            // 
            // usern_email_inp
            // 
            this.usern_email_inp.BackColor = System.Drawing.Color.White;
            this.usern_email_inp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usern_email_inp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usern_email_inp.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.usern_email_inp.ForeColor = System.Drawing.Color.Black;
            this.usern_email_inp.Location = new System.Drawing.Point(25, 170);
            this.usern_email_inp.Name = "usern_email_inp";
            this.usern_email_inp.Size = new System.Drawing.Size(275, 18);
            this.usern_email_inp.TabIndex = 9;
            this.usern_email_inp.MouseEnter += new System.EventHandler(this.usern_email_inp_MouseEnter);
            this.usern_email_inp.MouseLeave += new System.EventHandler(this.usern_email_inp_MouseLeave);
            this.usern_email_inp.Validating += new System.ComponentModel.CancelEventHandler(this.usern_email_inp_Validating);
            // 
            // StaySignedin_check
            // 
            this.StaySignedin_check.AutoSize = true;
            this.StaySignedin_check.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaySignedin_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.StaySignedin_check.Location = new System.Drawing.Point(12, 257);
            this.StaySignedin_check.Name = "StaySignedin_check";
            this.StaySignedin_check.Size = new System.Drawing.Size(126, 24);
            this.StaySignedin_check.TabIndex = 11;
            this.StaySignedin_check.Text = "Stay signed in";
            this.StaySignedin_check.UseVisualStyleBackColor = true;
            this.StaySignedin_check.CheckedChanged += new System.EventHandler(this.StaySignedin_check_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(101, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Or, continue with";
            // 
            // forgot_usrname
            // 
            this.forgot_usrname.AutoSize = true;
            this.forgot_usrname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_usrname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.forgot_usrname.Location = new System.Drawing.Point(206, 257);
            this.forgot_usrname.Name = "forgot_usrname";
            this.forgot_usrname.Size = new System.Drawing.Size(132, 20);
            this.forgot_usrname.TabIndex = 16;
            this.forgot_usrname.Text = "Forgot username";
            this.forgot_usrname.Click += new System.EventHandler(this.forgot_usrname_Click);
            // 
            // yahoologo
            // 
            this.yahoologo.Image = ((System.Drawing.Image)(resources.GetObject("yahoologo.Image")));
            this.yahoologo.Location = new System.Drawing.Point(70, 35);
            this.yahoologo.Name = "yahoologo";
            this.yahoologo.Size = new System.Drawing.Size(201, 58);
            this.yahoologo.TabIndex = 17;
            this.yahoologo.TabStop = false;
            // 
            // usernamepanel
            // 
            this.usernamepanel.BackColor = System.Drawing.Color.DimGray;
            this.usernamepanel.ForeColor = System.Drawing.Color.Black;
            this.usernamepanel.Location = new System.Drawing.Point(25, 188);
            this.usernamepanel.Name = "usernamepanel";
            this.usernamepanel.Size = new System.Drawing.Size(275, 2);
            this.usernamepanel.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(25, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 2);
            this.panel1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(316, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 455);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // googlebtn
            // 
            this.googlebtn.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.googlebtn.ButtonColor = System.Drawing.Color.White;
            this.googlebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.googlebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googlebtn.Location = new System.Drawing.Point(69, 444);
            this.googlebtn.Name = "googlebtn";
            this.googlebtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.googlebtn.OnHoverButtonColor = System.Drawing.Color.White;
            this.googlebtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.googlebtn.Size = new System.Drawing.Size(201, 48);
            this.googlebtn.TabIndex = 20;
            this.googlebtn.Text = "Google";
            this.googlebtn.TextColor = System.Drawing.Color.DimGray;
            this.googlebtn.UseVisualStyleBackColor = true;
            this.googlebtn.Click += new System.EventHandler(this.googlebtn_Click);
            // 
            // createbtn
            // 
            this.createbtn.BorderColor = System.Drawing.Color.Transparent;
            this.createbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.Location = new System.Drawing.Point(70, 360);
            this.createbtn.Name = "createbtn";
            this.createbtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.createbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.createbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.createbtn.Size = new System.Drawing.Size(200, 48);
            this.createbtn.TabIndex = 19;
            this.createbtn.Text = "Create an account";
            this.createbtn.TextColor = System.Drawing.Color.White;
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // signinbtn
            // 
            this.signinbtn.BorderColor = System.Drawing.Color.Transparent;
            this.signinbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.signinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbtn.Location = new System.Drawing.Point(70, 303);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.signinbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.signinbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.signinbtn.Size = new System.Drawing.Size(201, 48);
            this.signinbtn.TabIndex = 18;
            this.signinbtn.Text = "Sign in";
            this.signinbtn.TextColor = System.Drawing.Color.White;
            this.signinbtn.UseVisualStyleBackColor = true;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 515);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usernamepanel);
            this.Controls.Add(this.googlebtn);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.signinbtn);
            this.Controls.Add(this.yahoologo);
            this.Controls.Add(this.forgot_usrname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StaySignedin_check);
            this.Controls.Add(this.usern_email_inp);
            this.Controls.Add(this.pswd_inp);
            this.Controls.Add(this.ext_lbl);
            this.Controls.Add(this.signin_lbl);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yahoo SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yahoologo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label signin_lbl;
        private System.Windows.Forms.Label ext_lbl;
        private System.Windows.Forms.MaskedTextBox pswd_inp;
        private System.Windows.Forms.MaskedTextBox usern_email_inp;
        private System.Windows.Forms.CheckBox StaySignedin_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label forgot_usrname;
        private System.Windows.Forms.PictureBox yahoologo;
        private ePOSOne.btnProduct.Button_WOC signinbtn;
        private ePOSOne.btnProduct.Button_WOC createbtn;
        private ePOSOne.btnProduct.Button_WOC googlebtn;
        private System.Windows.Forms.Panel usernamepanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

