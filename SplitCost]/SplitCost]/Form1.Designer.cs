﻿
namespace SplitCost_
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxmoney = new System.Windows.Forms.TextBox();
            this.textBoxpeople = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.syo1 = new System.Windows.Forms.Label();
            this.amari1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "人数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "一人当たり";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "計算する";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxmoney
            // 
            this.textBoxmoney.Location = new System.Drawing.Point(107, 88);
            this.textBoxmoney.Name = "textBoxmoney";
            this.textBoxmoney.Size = new System.Drawing.Size(150, 25);
            this.textBoxmoney.TabIndex = 7;
            this.textBoxmoney.Text = "0";
            this.textBoxmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxpeople
            // 
            this.textBoxpeople.Location = new System.Drawing.Point(409, 85);
            this.textBoxpeople.Name = "textBoxpeople";
            this.textBoxpeople.Size = new System.Drawing.Size(150, 25);
            this.textBoxpeople.TabIndex = 8;
            this.textBoxpeople.Text = "0";
            this.textBoxpeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "余り";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "円";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "人";
            // 
            // syo1
            // 
            this.syo1.AutoSize = true;
            this.syo1.Location = new System.Drawing.Point(172, 185);
            this.syo1.Name = "syo1";
            this.syo1.Size = new System.Drawing.Size(35, 18);
            this.syo1.TabIndex = 12;
            this.syo1.Text = "0円";
            // 
            // amari1
            // 
            this.amari1.AutoSize = true;
            this.amari1.Location = new System.Drawing.Point(434, 185);
            this.amari1.Name = "amari1";
            this.amari1.Size = new System.Drawing.Size(35, 18);
            this.amari1.TabIndex = 13;
            this.amari1.Text = "0円";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amari1);
            this.Controls.Add(this.syo1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxpeople);
            this.Controls.Add(this.textBoxmoney);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxmoney;
        private System.Windows.Forms.TextBox textBoxpeople;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label syo1;
        private System.Windows.Forms.Label amari1;
    }
}

