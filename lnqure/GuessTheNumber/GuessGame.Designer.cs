namespace GuessTheNumber
{
    partial class GuessGame
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
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtNum
            // 
            this.TxtNum.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtNum.Location = new System.Drawing.Point(44, 50);
            this.TxtNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(625, 45);
            this.TxtNum.TabIndex = 0;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnEnter.Location = new System.Drawing.Point(680, 50);
            this.BtnEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(150, 50);
            this.BtnEnter.TabIndex = 1;
            this.BtnEnter.Text = "確定";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnUpdate.Location = new System.Drawing.Point(838, 50);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(150, 50);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "更正";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // TxtResult
            // 
            this.TxtResult.AcceptsReturn = true;
            this.TxtResult.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtResult.Location = new System.Drawing.Point(44, 134);
            this.TxtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(1136, 522);
            this.TxtResult.TabIndex = 3;
            // 
            // GuessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtNum);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GuessGame";
            this.Text = "GuessGame";
            this.Load += new System.EventHandler(this.GuessGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtResult;
    }
}