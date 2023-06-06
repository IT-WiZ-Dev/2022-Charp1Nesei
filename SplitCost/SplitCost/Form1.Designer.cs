
namespace SplitCost
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
            this.Zeimoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.person1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bochimoney = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.modmoney = new System.Windows.Forms.Label();
            this.buttonAddTax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // Zeimoney
            // 
            this.Zeimoney.Location = new System.Drawing.Point(31, 45);
            this.Zeimoney.Name = "Zeimoney";
            this.Zeimoney.Size = new System.Drawing.Size(100, 25);
            this.Zeimoney.TabIndex = 1;
            this.Zeimoney.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "円";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "人数";
            // 
            // person1
            // 
            this.person1.Location = new System.Drawing.Point(241, 45);
            this.person1.Name = "person1";
            this.person1.Size = new System.Drawing.Size(100, 25);
            this.person1.TabIndex = 4;
            this.person1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "一人当たり";
            // 
            // Bochimoney
            // 
            this.Bochimoney.AutoSize = true;
            this.Bochimoney.Location = new System.Drawing.Point(34, 127);
            this.Bochimoney.Name = "Bochimoney";
            this.Bochimoney.Size = new System.Drawing.Size(0, 18);
            this.Bochimoney.TabIndex = 7;
            this.Bochimoney.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "余り";
            // 
            // modmoney
            // 
            this.modmoney.AutoSize = true;
            this.modmoney.Location = new System.Drawing.Point(244, 126);
            this.modmoney.Name = "modmoney";
            this.modmoney.Size = new System.Drawing.Size(26, 18);
            this.modmoney.TabIndex = 9;
            this.modmoney.Text = "円";
            this.modmoney.Click += new System.EventHandler(this.label8_Click);
            // 
            // buttonAddTax
            // 
            this.buttonAddTax.Location = new System.Drawing.Point(31, 179);
            this.buttonAddTax.Name = "buttonAddTax";
            this.buttonAddTax.Size = new System.Drawing.Size(310, 31);
            this.buttonAddTax.TabIndex = 10;
            this.buttonAddTax.Text = "計算する";
            this.buttonAddTax.UseVisualStyleBackColor = true;
            this.buttonAddTax.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddTax);
            this.Controls.Add(this.modmoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Bochimoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.person1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Zeimoney);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Zeimoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox person1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Bochimoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label modmoney;
        private System.Windows.Forms.Button buttonAddTax;
    }
}

