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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        #region 資料庫連線的相關資訊
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        #endregion
        private void NewUser_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-V1S3I6B\\SQLEXPRESS;Initial Catalog=GuessTheNumber;Integrated Security=True");
           // cn = new SqlConnection("Data Source=DESKTOP-HFEAG3C\\GOWORK;Initial Catalog=GuessTheNumber;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = $"SELECT UserID FROM NewUser where UserID = @UserID";
            cmd.Parameters.AddWithValue("@UserID", TxtNewUser.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            //判斷da是否有東西
            if (dt.Rows.Count == 0)
            {
                if (TxtPasswordFirst.Text == TxtPasswordConfirm.Text)
                {
                    da = new SqlDataAdapter();
                    cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = $" insert into NewUser " +
                        $" (UserID, UserPassword) " +
                        $" values ( @UserID, @UserPassword) ";

                    cmd.Parameters.AddWithValue("@UserID", TxtNewUser.Text);
                    cmd.Parameters.AddWithValue("@UserPassword", TxtPasswordConfirm.Text);

                    da.InsertCommand = cmd;                  
                    da.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("註冊成功");
                }
                else
                {
                    MessageBox.Show("請再次確認密碼一樣");
                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("已有此帳號");
            }


            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            this.Hide();
            Login.Show();
        }

        private void BtnExamination_Click(object sender, EventArgs e)

        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-V1S3I6B\\SQLEXPRESS;Initial Catalog=GuessTheNumber;Integrated Security=True");
           // SqlConnection cn = new SqlConnection("Data Source=DESKTOP-HFEAG3C\\GOWORK;Initial Catalog=GuessTheNumber;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = $"SELECT UserID FROM NewUser where UserID = @UserID";
            cmd.Parameters.AddWithValue("@UserID", TxtNewUser.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count==0)
            {
                MessageBox.Show("可以使用此帳號");
                cn.Close();
            }
            else 
            {
                MessageBox.Show("已有此帳號");
            }
        }

        private void TxtNewUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
