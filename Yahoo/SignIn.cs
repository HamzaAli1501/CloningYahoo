using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahoo
{
    public partial class SignIn : Form
    {
        SqlConnection con;

        public SignIn()
        {
            InitializeComponent();
        }
        private void SignIn_Load(object sender, EventArgs e)
        {
            usern_email_inp.Focus();
            usern_email_inp.Text = "Username, email or mobile";
            pswd_inp.Text = "Enter Your Password";
            usern_email_inp.ForeColor = Color.Gray;
            pswd_inp.ForeColor = Color.Gray;

            string con_string = ("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Hamza\\Desktop\\Yahoo\\Yahoo\\YahooLogin.mdf; Integrated Security = True");

            con = new SqlConnection(con_string);
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
        }
        private void createbtn_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        

        private void usern_email_inp_MouseEnter(object sender, EventArgs e)
        {
            if (usern_email_inp.Text == "Username, email or mobile")
            {
                usern_email_inp.Text = string.Empty;
            }
        }

        private void usern_email_inp_MouseLeave(object sender, EventArgs e)
        {
            if (usern_email_inp.Text == string.Empty)
            {
                usern_email_inp.Text = "Username, email or mobile";
                usern_email_inp.ForeColor = Color.Gray;
            }
        }

        private void pswd_inp_MouseEnter(object sender, EventArgs e)
        {
            if (pswd_inp.Text == "Enter Your Password")
            {
                pswd_inp.Text = string.Empty;
            }
        }

        private void pswd_inp_MouseLeave(object sender, EventArgs e)
        {
            if (pswd_inp.Text == string.Empty)
            {
                pswd_inp.Text = "Enter Your Password";
                pswd_inp.ForeColor = Color.Gray;
            }
        }

        private void usern_email_inp_Validating(object sender, CancelEventArgs e)
        {
            if (usern_email_inp.Text == string.Empty)
            {
                errorProvider1.SetError(usern_email_inp, "Please Enter username, email or phone number");
            }
        }

        private void pswd_inp_Validating(object sender, CancelEventArgs e)
        {
            if (pswd_inp.Text == string.Empty)
            {
                errorProvider2.SetError(pswd_inp, "Please Enter password");
            }
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            /*  try
              {
                  SqlCommand mycmd = new SqlCommand("SELECT COUNT(*) FROM UserInfo WHERE Email='" + usern_email_inp.Text + "' AND Password='" + pswd_inp.Text + "'", con);

                  mycmd.BeginExecuteNonQuery();
                  SqlParameter p1 = new SqlParameter("username", usern_email_inp.Text);
                  SqlParameter p2 = new SqlParameter("password", pswd_inp.Text);
                  mycmd.Parameters.Add(p1);
                  mycmd.Parameters.Add(p2);
                  con.Open();
                  SqlDataReader rd = mycmd.ExecuteReader();
                  if (rd.HasRows)
                  {
                      rd.Read();
                      MessageBox.Show("Login successful.");
                  }
                  else
                  {
                      MessageBox.Show("Invalid username or password.");
                  }

              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }*/
            int index = usern_email_inp.Text.IndexOf('@');
            string eml;
            if (index == -1)
            {
                eml = usern_email_inp.Text + "@yahoo.com";
            }
            else { eml = usern_email_inp.Text; }


            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM yahoo WHERE Email='" + eml + "' AND Password='" + pswd_inp.Text + "'", con);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                MessageBox.Show("Sign in successful");
            }
            else
                MessageBox.Show("Invalid email or password. Kindly re-try");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void googlebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just for replica", "Blah Blah");
        }

        private void forgot_usrname_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doesn't do anything", "Useless");
        }

        private void StaySignedin_check_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Just for replica", "Blah Blah");
        }
    }
}