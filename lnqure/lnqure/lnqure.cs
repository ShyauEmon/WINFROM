using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lnqure
{
    public partial class Lab_Insert : Form
    {
        public Lab_Insert()
        {
            InitializeComponent();
        }
        #region 我自己的連線字串
        string connString = Properties.Settings.Default.AdventureWorksDW2017;
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        #endregion

        #region 自己的變數
        static int pageNum = 0;
        string sqlComm = $"SELECT * FROM DimCurrency ORDER BY CurrencyAlternateKey OFFSET @pageNum ROWS FETCH NEXT 5 ROWS ONLY";
        #endregion
        private void setDgvCurrency()
        {
            // 有東西再去清除
            if (ds.Tables["DimCurrency"] != null && ds.Tables["DimCurrency"].Rows.Count > 0)
            {
                ds.Tables["DimCurrency"].Clear();
            }
            da.FillSchema(ds, SchemaType.Source, "DimCurrency");
            da.Fill(ds, "DimCurrency");
            this.DgvDimCurrency.DataSource = ds.Tables["DimCurrency"];
            DgvDimCurrency.Columns["CurrencyKey"].HeaderText = "編號";
            DgvDimCurrency.Columns["CurrencyAlternateKey"].HeaderText = "貨幣縮寫";
            DgvDimCurrency.Columns["CurrencyName"].HeaderText = "貨幣名稱";
            DgvDimCurrency.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        //表單讀取
        private void Lab_Insert_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connString);
            da = new SqlDataAdapter();
            ds = new DataSet();
            LblResult.Text = $"第{pageNum + 1}筆 - 第{pageNum + 5}筆";
            da.SelectCommand = new SqlCommand(sqlComm, cn);
            da.SelectCommand.Parameters.AddWithValue("@pageNum", pageNum);

        }
        // 表單關閉
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string checkModify = "";
            foreach (DataRow row in ds.Tables["DimCurrency"].Rows)
            {
                if (row.RowState == DataRowState.Modified)
                {
                    checkModify += string.Join("-", row.ItemArray) + Environment.NewLine;
                }
            }

            if (!string.IsNullOrEmpty(checkModify))
            {
                if (MessageBox.Show("有異動資料沒存檔:" + checkModify
                            , "這是系統標題可以自己改"
                            , MessageBoxButtons.OKCancel
                            , MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }
        //全部列出
        private void BtnSlect_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from DimCurrency", cn);

            setDgvCurrency();
            if (TxtCurrencyKey.DataBindings.Count == 0)
            {
                TxtCurrencyKey.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyKey");
                TxtCurrencyAlternateKey.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyAlternateKey");
                TxtCurrencyName.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyName");
            }


        }
        //查詢
        private void BtnFind_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "";
            foreach (DataGridViewRow row in DgvDimCurrency.Rows)
            {
                // textBox1.Text += row.Cells[1].Value + Environment.NewLine;
                if ((string)row.Cells[1].Value == TxtCondition.Text)
                {
                    DgvDimCurrency.Rows[row.Index].Selected = true;
                    DgvDimCurrency.FirstDisplayedScrollingRowIndex = row.Index;
                }
                else
                {
                    DgvDimCurrency.Rows[row.Index].Selected = false;
                }
            }


        }
        //狀態查詢
        private void BtnStatus_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "";

            foreach (DataRow row in ds.Tables["DimCurrency"].Rows)
            {
                //txtResult.Text += 
                //  item.RowState + "\r\n";

                TxtResult.Text += string.Join(",", row.ItemArray) +
                    row.RowState + Environment.NewLine;
            }
        }
        //上一頁
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            pageNum = (pageNum - 5) >= 0 ? pageNum - 5 : pageNum;
            LblResult.Text = $"第{pageNum + 1}筆 - 第{pageNum + 5}筆";
            da.SelectCommand = new SqlCommand(sqlComm, cn);
            da.SelectCommand.Parameters.AddWithValue("@pageNum", pageNum);
            setDgvCurrency();
        }
        //下一頁
        private void BtnNext_Click(object sender, EventArgs e)
        {
            pageNum = (5 == ds.Tables["DimCurrency"].Rows.Count) ? pageNum + 5 : pageNum;
            LblResult.Text = $"第{pageNum + 1}筆 - 第{pageNum + 5}筆";
            da.SelectCommand = new SqlCommand(sqlComm, cn);
            da.SelectCommand.Parameters.AddWithValue("@pageNum", pageNum);
            setDgvCurrency();
        }
        //修改
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            //// 方法一
            //SqlCommandBuilder sb = new SqlCommandBuilder(da);
            //da.UpdateCommand = sb.GetUpdateCommand();
            //int cnt = da.Update(ds.Tables["DimCurrency"]);
            //MessageBox.Show($"作業筆數為:{cnt}");


            // 方法二
            //SqlCommandBuilder sb = new SqlCommandBuilder(da);
            //da.UpdateCommand = sb.GetUpdateCommand();
            //TxtResult.Text = sb.GetUpdateCommand().CommandText; //查看SQL產生指令
            //da.UpdateCommand.Parameters[0] = new SqlParameter("@p1", TxtCurrencyAlternateKey.Text);
            //da.UpdateCommand.Parameters[0] = new SqlParameter("@p2", TxtCurrencyAlternateKey.Text);
            //da.UpdateCommand.Parameters[0] = new SqlParameter("@p3", TxtCurrencyAlternateKey.Text);
            //da.UpdateCommand.Parameters[0] = new SqlParameter("@p4", TxtCurrencyAlternateKey.Text);
            //da.UpdateCommand.Parameters[0] = new SqlParameter("@p5", TxtCurrencyAlternateKey.Text);
            //cn.Open();
            //da.UpdateCommand.ExecuteNonQuery();
            //cn.Close();
            // 方法三
            cn.Open();
            da.UpdateCommand =
                new SqlCommand("update DimCurrency set CurrencyName = @CurrencyName where CurrencyKey = @CurrencyKey ", cn);

            da.UpdateCommand.Parameters.AddWithValue("@CurrencyName", TxtCurrencyName.Text);
            da.UpdateCommand.Parameters.AddWithValue("@CurrencyKey", TxtCurrencyKey.Text);

            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();

        }
        //新增
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            //方法一
            //foreach (DataRow row in ds.Tables["DimCurrency"].Rows)
            //{
            //    TxtResult.Text += row.RowState + Environment.NewLine;
            //}

            //SqlCommandBuilder sb = new SqlCommandBuilder(da);
            //da.InsertCommand = sb.GetInsertCommand();
            //cn.Open();
            //da.Update(ds, "DimCurrency");
            //cn.Close();
            //方法二
            //DataRow nrow = ds.Tables["DimCurrency"].NewRow();
            //nrow["CurrencyKey"] = TxtCurrencyKey.Text;
            //nrow["CurrencyAlternateKey"] = TxtCurrencyAlternateKey.Text;
            //nrow["CurrencyName"] = TxtCurrencyName.Text;
            //ds.Tables["DimCurrency"].Rows.Add(nrow);

            //SqlCommandBuilder sb = new SqlCommandBuilder(da);
            //da.InsertCommand = sb.GetInsertCommand();
            ////cn.Open();
            //int cnt = da.Update(ds, "DimCurrency");
            ////cn.Close();
            //MessageBox.Show($"新增筆數： {cnt} 筆");
            //方法三
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = $" insert into DimCurrency " +
                $" (CurrencyAlternateKey, CurrencyName) " +
                $" values (@CurrencyAlternateKey ,@CurrencyName) ";
            cmd.Parameters.AddWithValue("@CurrencyAlternateKey", TxtCurrencyAlternateKey.Text);
            cmd.Parameters.AddWithValue("@CurrencyName", TxtCurrencyName.Text);
            da.InsertCommand = cmd;
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
            int cnt = da.Update(ds, "DimCurrency");
            //cn.Close();
            MessageBox.Show($"新增筆數： {cnt} 筆");

        }
        //讀key
        private void BtnPK_Click(object sender, EventArgs e)
        {
            //先清空欄位
            TxtResult.Text = "";
            //讀出 資料表 裡面的 primary key
            DataColumn[] col = ds.Tables["DimCurrency"].PrimaryKey;
            for (int i = 0; i < col.Length; i++)
            {
                TxtResult.Text += col[i];
            }
        }
        //刪除
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"是否要刪除資料 " +
                $"{string.Join("-", ds.Tables["DimCurrency"].Rows[DgvDimCurrency.CurrentRow.Index].ItemArray)}",
                "刪除資料中"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // 查看目前使用者點選是哪一列
                //txtResult.Text = dgvCurrency.CurrentRow.Index.ToString();

                // 刪除 dataset 中 指定的資料表 指定的資料列
                ds.Tables["DimCurrency"].Rows[DgvDimCurrency.CurrentRow.Index].Delete();

                // 直接更新回資料庫
                SqlCommandBuilder sb = new SqlCommandBuilder(da);
                da.DeleteCommand = sb.GetDeleteCommand();
                da.Update(ds, "DimCurrency");
                int cnt = da.Update(ds.Tables["DimCurrency"]);
                MessageBox.Show($"作業筆數為:{cnt}");
            }
        }

        private void DgvDimCurrency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow dr = DgvDimCurrency.CurrentRow;
            //TxtCurrencyKey.Text = dr.Cells["CurrencyKey"].Value.ToString();
            //TxtCurrencyAlternateKey.Text = dr.Cells["CurrencyAlternateKey"].Value.ToString();
            //TxtCurrencyName.Text = dr.Cells["CurrencyName."].Value.ToString();

        }

        private void DgvDimCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            //讀出每一行
            int row_current_index = DgvDimCurrency.CurrentRow.Index;
            //未來變化
            int next_index=0;
            //設定邊界最大
            int end_index = DgvDimCurrency.Rows.Count - 1;
            if (e.KeyCode == Keys.Up)
            {
                next_index = row_current_index - 1 > 0 ? row_current_index - 1 : 0;
                TxtResult.Text = next_index.ToString();
                
            }
            else if (e.KeyCode == Keys.Down)
            {
                next_index = row_current_index + 1 > end_index ? end_index : row_current_index + 1;
                TxtResult.Text = next_index.ToString();
                
            }
            DgvDimCurrency.Rows[next_index].Selected = true;

        }
    }
}
