
namespace SplitCost_Ver._2
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.Zeimoney = new System.Windows.Forms.TextBox();
            this.person1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modmoney = new System.Windows.Forms.Label();
            this.buttonAddTax = new System.Windows.Forms.Button();
            this.Bochimoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "人数";
            // 
            // Zeimoney
            // 
            this.Zeimoney.Location = new System.Drawing.Point(73, 49);
            this.Zeimoney.Name = "Zeimoney";
            this.Zeimoney.Size = new System.Drawing.Size(100, 25);
            this.Zeimoney.TabIndex = 2;
            this.Zeimoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // person1
            // 
            this.person1.Location = new System.Drawing.Point(262, 49);
            this.person1.Name = "person1";
            this.person1.Size = new System.Drawing.Size(100, 25);
            this.person1.TabIndex = 3;
            this.person1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "円";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "一人当たり";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "余り";
            // 
            // modmoney
            // 
            this.modmoney.AutoSize = true;
            this.modmoney.Location = new System.Drawing.Point(268, 136);
            this.modmoney.Name = "modmoney";
            this.modmoney.Size = new System.Drawing.Size(26, 18);
            this.modmoney.TabIndex = 8;
            this.modmoney.Text = "円";
            // 
            // buttonAddTax
            // 
            this.buttonAddTax.Location = new System.Drawing.Point(73, 190);
            this.buttonAddTax.Name = "buttonAddTax";
            this.buttonAddTax.Size = new System.Drawing.Size(339, 28);
            this.buttonAddTax.TabIndex = 9;
            this.buttonAddTax.Text = "計算する";
            this.buttonAddTax.UseVisualStyleBackColor = true;
            this.buttonAddTax.Click += new System.EventHandler(this.buttonAddTax_Click);
            // 
            // Bochimoney
            // 
            this.Bochimoney.AutoSize = true;
            this.Bochimoney.Location = new System.Drawing.Point(70, 136);
            this.Bochimoney.Name = "Bochimoney";
            this.Bochimoney.Size = new System.Drawing.Size(0, 18);
            this.Bochimoney.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 309);
            this.Controls.Add(this.Bochimoney);
            this.Controls.Add(this.buttonAddTax);
            this.Controls.Add(this.modmoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.person1);
            this.Controls.Add(this.Zeimoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "割り勘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Zeimoney;
        private System.Windows.Forms.TextBox person1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label modmoney;
        private System.Windows.Forms.Button buttonAddTax;
        private System.Windows.Forms.Label Bochimoney;
    }
}

