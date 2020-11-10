namespace GuessTheNumber
{
    partial class NewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNewUser = new System.Windows.Forms.TextBox();
            this.BtnExamination = new System.Windows.Forms.Button();
            this.BtnNewUser = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtPasswordFirst = new System.Windows.Forms.TextBox();
            this.TxtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(449, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(397, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密碼:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(345, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "確認密碼:";
            // 
            // TxtNewUser
            // 
            this.TxtNewUser.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtNewUser.Location = new System.Drawing.Point(635, 72);
            this.TxtNewUser.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtNewUser.Name = "TxtNewUser";
            this.TxtNewUser.Size = new System.Drawing.Size(498, 46);
            this.TxtNewUser.TabIndex = 3;
            this.TxtNewUser.TextChanged += new System.EventHandler(this.TxtNewUser_TextChanged);
            // 
            // BtnExamination
            // 
            this.BtnExamination.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnExamination.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnExamination.Location = new System.Drawing.Point(1151, 72);
            this.BtnExamination.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnExamination.Name = "BtnExamination";
            this.BtnExamination.Size = new System.Drawing.Size(163, 54);
            this.BtnExamination.TabIndex = 6;
            this.BtnExamination.Text = "檢查";
            this.BtnExamination.UseVisualStyleBackColor = true;
            this.BtnExamination.Click += new System.EventHandler(this.BtnExamination_Click);
            // 
            // BtnNewUser
            // 
            this.BtnNewUser.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnNewUser.Location = new System.Drawing.Point(635, 470);
            this.BtnNewUser.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnNewUser.Name = "BtnNewUser";
            this.BtnNewUser.Size = new System.Drawing.Size(228, 118);
            this.BtnNewUser.TabIndex = 7;
            this.BtnNewUser.Text = "確定";
            this.BtnNewUser.UseVisualStyleBackColor = true;
            this.BtnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCancel.Location = new System.Drawing.Point(910, 470);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(228, 118);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtPasswordFirst
            // 
            this.TxtPasswordFirst.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtPasswordFirst.Location = new System.Drawing.Point(635, 206);
            this.TxtPasswordFirst.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtPasswordFirst.Name = "TxtPasswordFirst";
            this.TxtPasswordFirst.Size = new System.Drawing.Size(498, 46);
            this.TxtPasswordFirst.TabIndex = 9;
            // 
            // TxtPasswordConfirm
            // 
            this.TxtPasswordConfirm.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtPasswordConfirm.Location = new System.Drawing.Point(635, 338);
            this.TxtPasswordConfirm.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtPasswordConfirm.Name = "TxtPasswordConfirm";
            this.TxtPasswordConfirm.Size = new System.Drawing.Size(498, 46);
            this.TxtPasswordConfirm.TabIndex = 10;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 900);
            this.Controls.Add(this.TxtPasswordConfirm);
            this.Controls.Add(this.TxtPasswordFirst);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnNewUser);
            this.Controls.Add(this.BtnExamination);
            this.Controls.Add(this.TxtNewUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNewUser;
        private System.Windows.Forms.Button BtnExamination;
        private System.Windows.Forms.Button BtnNewUser;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtPasswordFirst;
        private System.Windows.Forms.TextBox TxtPasswordConfirm;
    }
}