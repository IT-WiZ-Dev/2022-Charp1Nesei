﻿
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labeldivision = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelremainder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxnumber = new System.Windows.Forms.TextBox();
            this.textBoxmoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "人数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "円";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "円";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "一人あたり";
            // 
            // labeldivision
            // 
            this.labeldivision.AutoSize = true;
            this.labeldivision.Location = new System.Drawing.Point(121, 224);
            this.labeldivision.Name = "labeldivision";
            this.labeldivision.Size = new System.Drawing.Size(30, 15);
            this.labeldivision.TabIndex = 5;
            this.labeldivision.Text = "0円";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "余り";
            // 
            // labelremainder
            // 
            this.labelremainder.AutoSize = true;
            this.labelremainder.Location = new System.Drawing.Point(465, 224);
            this.labelremainder.Name = "labelremainder";
            this.labelremainder.Size = new System.Drawing.Size(30, 15);
            this.labelremainder.TabIndex = 7;
            this.labelremainder.Text = "0円";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(592, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "計算する";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxnumber
            // 
            this.textBoxnumber.Location = new System.Drawing.Point(468, 99);
            this.textBoxnumber.Name = "textBoxnumber";
            this.textBoxnumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxnumber.TabIndex = 9;
            this.textBoxnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxmoney
            // 
            this.textBoxmoney.Location = new System.Drawing.Point(124, 99);
            this.textBoxmoney.Name = "textBoxmoney";
            this.textBoxmoney.Size = new System.Drawing.Size(100, 22);
            this.textBoxmoney.TabIndex = 10;
            this.textBoxmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxmoney);
            this.Controls.Add(this.textBoxnumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelremainder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labeldivision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labeldivision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelremainder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxnumber;
        private System.Windows.Forms.TextBox textBoxmoney;
    }
}

