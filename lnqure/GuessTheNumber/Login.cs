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

namespace GuessTheNumber
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewUser NewUser = new NewUser();
            this.Hide();
            NewUser.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-V1S3I6B\\SQLEXPRESS;Initial Catalog=GuessTheNumber;Integrated Security=True");
           // SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HFEAG3C\\GOWORK;Initial Catalog=GuessTheNumber;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = $"SELECT UserID FROM NewUser where UserID = @UserID and UserPassword = @UserPassword";
            cmd.Parameters.AddWithValue("@UserID", TxtUser.Text);
            cmd.Parameters.AddWithValue("@UserPassword", TxtPassword.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count != 0)
            {
                GuessGame GuessGame =new GuessGame();
                this.Hide();
                GuessGame.Show();
                cn.Close();
            }
            else
            {
                MessageBox.Show("帳號密碼有誤");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
