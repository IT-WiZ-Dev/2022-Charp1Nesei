
namespace SplitCost
{
    partial class FormSplitCost
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSplitCost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelMoneyLeft = new System.Windows.Forms.Label();
            this.textMoney = new System.Windows.Forms.TextBox();
            this.textPeople = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSplitCost
            // 
            this.buttonSplitCost.Location = new System.Drawing.Point(213, 269);
            this.buttonSplitCost.Name = "buttonSplitCost";
            this.buttonSplitCost.Size = new System.Drawing.Size(132, 38);
            this.buttonSplitCost.TabIndex = 0;
            this.buttonSplitCost.Text = "計算する";
            this.buttonSplitCost.UseVisualStyleBackColor = true;
            this.buttonSplitCost.Click += new System.EventHandler(this.buttonSplitCost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "税抜き金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "人数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "円";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "一人あたり";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "余り";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(66, 200);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(0, 20);
            this.labelMoney.TabIndex = 7;
            // 
            // labelMoneyLeft
            // 
            this.labelMoneyLeft.AutoSize = true;
            this.labelMoneyLeft.Location = new System.Drawing.Point(375, 200);
            this.labelMoneyLeft.Name = "labelMoneyLeft";
            this.labelMoneyLeft.Size = new System.Drawing.Size(0, 20);
            this.labelMoneyLeft.TabIndex = 8;
            // 
            // textMoney
            // 
            this.textMoney.Location = new System.Drawing.Point(68, 87);
            this.textMoney.Name = "textMoney";
            this.textMoney.Size = new System.Drawing.Size(170, 26);
            this.textMoney.TabIndex = 9;
            this.textMoney.Text = "0";
            this.textMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textPeople
            // 
            this.textPeople.Location = new System.Drawing.Point(379, 87);
            this.textPeople.Name = "textPeople";
            this.textPeople.Size = new System.Drawing.Size(154, 26);
            this.textPeople.TabIndex = 10;
            this.textPeople.Text = "0";
            this.textPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormSplitCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 341);
            this.Controls.Add(this.textPeople);
            this.Controls.Add(this.textMoney);
            this.Controls.Add(this.labelMoneyLeft);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSplitCost);
            this.Name = "FormSplitCost";
            this.Text = "割り勘";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSplitCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelMoneyLeft;
        private System.Windows.Forms.TextBox textMoney;
        private System.Windows.Forms.TextBox textPeople;
    }
}

