using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class GuessGame : Form
    {
        public GuessGame()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // 產生亂數
            string temp = "0123456789";
            string question = ""; // 四個不重複的數字

            Random rdn = new Random();
            for (int i = 0; i < 4; i++)
            {
                int index = rdn.Next(0, temp.Length);
                string s = temp.Substring(index, 1);
                question += s;
                temp = temp.Replace(s, "");
            }


            // 要記錄幾A幾B的地方
            int a = 0, b = 0;

            // 答對，五次
            int cnt = 0;
            string result;
            while (a != 4 && cnt < 6)
            {
                cnt++;
                a = 0;
                b = 0;

                // 處理使用者輸入的訊息
                string[] ans = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    ans[i] = TxtNum.Text.Substring(i, 1);
                }

                for (int k = 0; k < 4; k++)
                {
                    if (question.IndexOf(ans[k]) == k)
                    {
                        a++;
                    }
                    else if (question.IndexOf(ans[k]) > -1)
                    {
                        b++;
                    }
                }

                if (a == 4)
                {
                    MessageBox.Show("恭喜答對了");

                    // break;

                    // cnt = 999;
                }


            }
            result = $"您輸入的是:{TxtNum.Text}\r\n{a}A{b}B";
            TxtResult.Text += (result+"\r\n");
        }

        private void GuessGame_Load(object sender, EventArgs e)
        {

        }
    }
}
