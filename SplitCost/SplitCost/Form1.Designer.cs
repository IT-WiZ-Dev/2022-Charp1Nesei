
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSplitCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(40, 42);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(100, 22);
            this.textBoxMoney.TabIndex = 1;
            this.textBoxMoney.Text = "0";
            this.textBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMoney.TextChanged += new System.EventHandler(this.textBoxMoney_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "円";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "人数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "人";
            // 
            // textBoxPerson
            // 
            this.textBoxPerson.Location = new System.Drawing.Point(249, 42);
            this.textBoxPerson.Name = "textBoxPerson";
            this.textBoxPerson.Size = new System.Drawing.Size(100, 22);
            this.textBoxPerson.TabIndex = 5;
            this.textBoxPerson.Text = "0";
            this.textBoxPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "一人あたり";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "余り";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "0円";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "0円";
            // 
            // buttonSplitCost
            // 
            this.buttonSplitCost.Location = new System.Drawing.Point(232, 214);
            this.buttonSplitCost.Name = "buttonSplitCost";
            this.buttonSplitCost.Size = new System.Drawing.Size(129, 31);
            this.buttonSplitCost.TabIndex = 10;
            this.buttonSplitCost.Text = "計算する";
            this.buttonSplitCost.UseVisualStyleBackColor = true;
            this.buttonSplitCost.Click += new System.EventHandler(this.buttonSplitCost_Click);
            // 
            // FormSplitCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSplitCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.label1);
            this.Name = "FormSplitCost";
            this.Text = "割り勘";
            this.Load += new System.EventHandler(this.FormSplitCost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSplitCost;
    }
}

