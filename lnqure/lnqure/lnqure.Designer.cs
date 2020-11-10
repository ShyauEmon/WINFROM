namespace lnqure
{
    partial class Lab_Insert
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSlect = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.DgvDimCurrency = new System.Windows.Forms.DataGridView();
            this.TxtCondition = new System.Windows.Forms.TextBox();
            this.BtnStatus = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxtCurrencyKey = new System.Windows.Forms.TextBox();
            this.TxtCurrencyAlternateKey = new System.Windows.Forms.TextBox();
            this.TxtCurrencyName = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnPK = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDimCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSlect
            // 
            this.BtnSlect.Location = new System.Drawing.Point(4, 93);
            this.BtnSlect.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSlect.Name = "BtnSlect";
            this.BtnSlect.Size = new System.Drawing.Size(214, 57);
            this.BtnSlect.TabIndex = 0;
            this.BtnSlect.Text = "全部列出";
            this.BtnSlect.UseVisualStyleBackColor = true;
            this.BtnSlect.Click += new System.EventHandler(this.BtnSlect_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(6, 46);
            this.BtnFind.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(219, 29);
            this.BtnFind.TabIndex = 1;
            this.BtnFind.Text = "查詢";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // DgvDimCurrency
            // 
            this.DgvDimCurrency.AllowUserToAddRows = false;
            this.DgvDimCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDimCurrency.Location = new System.Drawing.Point(6, 190);
            this.DgvDimCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.DgvDimCurrency.Name = "DgvDimCurrency";
            this.DgvDimCurrency.RowHeadersWidth = 62;
            this.DgvDimCurrency.RowTemplate.Height = 24;
            this.DgvDimCurrency.Size = new System.Drawing.Size(884, 778);
            this.DgvDimCurrency.TabIndex = 2;
            this.DgvDimCurrency.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDimCurrency_CellClick);
            this.DgvDimCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvDimCurrency_KeyDown);
            // 
            // TxtCondition
            // 
            this.TxtCondition.Location = new System.Drawing.Point(4, 19);
            this.TxtCondition.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCondition.Name = "TxtCondition";
            this.TxtCondition.Size = new System.Drawing.Size(219, 29);
            this.TxtCondition.TabIndex = 3;
            // 
            // BtnStatus
            // 
            this.BtnStatus.Location = new System.Drawing.Point(225, 93);
            this.BtnStatus.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStatus.Name = "BtnStatus";
            this.BtnStatus.Size = new System.Drawing.Size(210, 57);
            this.BtnStatus.TabIndex = 4;
            this.BtnStatus.Text = "狀態查詢";
            this.BtnStatus.UseVisualStyleBackColor = true;
            this.BtnStatus.Click += new System.EventHandler(this.BtnStatus_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(898, 18);
            this.TxtResult.Margin = new System.Windows.Forms.Padding(4);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(497, 950);
            this.TxtResult.TabIndex = 5;
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(442, 19);
            this.BtnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(147, 57);
            this.BtnPrev.TabIndex = 6;
            this.BtnPrev.Text = "<<<上一頁";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(590, 19);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(147, 57);
            this.BtnNext.TabIndex = 7;
            this.BtnNext.Text = "下一頁>>>";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(740, 38);
            this.LblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(44, 18);
            this.LblResult.TabIndex = 8;
            this.LblResult.Text = "頁數";
            // 
            // TxtCurrencyKey
            // 
            this.TxtCurrencyKey.Location = new System.Drawing.Point(6, 155);
            this.TxtCurrencyKey.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCurrencyKey.Name = "TxtCurrencyKey";
            this.TxtCurrencyKey.Size = new System.Drawing.Size(212, 29);
            this.TxtCurrencyKey.TabIndex = 9;
            // 
            // TxtCurrencyAlternateKey
            // 
            this.TxtCurrencyAlternateKey.Location = new System.Drawing.Point(225, 155);
            this.TxtCurrencyAlternateKey.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCurrencyAlternateKey.Name = "TxtCurrencyAlternateKey";
            this.TxtCurrencyAlternateKey.Size = new System.Drawing.Size(210, 29);
            this.TxtCurrencyAlternateKey.TabIndex = 10;
            // 
            // TxtCurrencyName
            // 
            this.TxtCurrencyName.Location = new System.Drawing.Point(443, 155);
            this.TxtCurrencyName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCurrencyName.Name = "TxtCurrencyName";
            this.TxtCurrencyName.Size = new System.Drawing.Size(296, 29);
            this.TxtCurrencyName.TabIndex = 11;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(442, 129);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(147, 29);
            this.BtnUpdate.TabIndex = 12;
            this.BtnUpdate.Text = "修改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(592, 93);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(145, 65);
            this.BtnInsert.TabIndex = 13;
            this.BtnInsert.Text = "存檔";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnPK
            // 
            this.BtnPK.Location = new System.Drawing.Point(225, 19);
            this.BtnPK.Name = "BtnPK";
            this.BtnPK.Size = new System.Drawing.Size(210, 56);
            this.BtnPK.TabIndex = 14;
            this.BtnPK.Text = "讀取PK";
            this.BtnPK.UseVisualStyleBackColor = true;
            this.BtnPK.Click += new System.EventHandler(this.BtnPK_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(439, 93);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(146, 29);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "刪除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Lab_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 962);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnPK);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtCurrencyName);
            this.Controls.Add(this.TxtCurrencyAlternateKey);
            this.Controls.Add(this.TxtCurrencyKey);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnStatus);
            this.Controls.Add(this.TxtCondition);
            this.Controls.Add(this.DgvDimCurrency);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnSlect);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lab_Insert";
            this.Text = "查詢";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Lab_Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDimCurrency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSlect;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.DataGridView DgvDimCurrency;
        private System.Windows.Forms.TextBox TxtCondition;
        private System.Windows.Forms.Button BtnStatus;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxtCurrencyKey;
        private System.Windows.Forms.TextBox TxtCurrencyAlternateKey;
        private System.Windows.Forms.TextBox TxtCurrencyName;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnPK;
        private System.Windows.Forms.Button BtnDelete;
    }
}

