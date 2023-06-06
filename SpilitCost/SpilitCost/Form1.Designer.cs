
namespace SpilitCost
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNoTaxPrice = new System.Windows.Forms.TextBox();
            this.textnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PerOne = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "人数";
            // 
            // textNoTaxPrice
            // 
            this.textNoTaxPrice.Location = new System.Drawing.Point(162, 142);
            this.textNoTaxPrice.Name = "textNoTaxPrice";
            this.textNoTaxPrice.Size = new System.Drawing.Size(124, 31);
            this.textNoTaxPrice.TabIndex = 1;
            this.textNoTaxPrice.Text = "0";
            this.textNoTaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textnumber
            // 
            this.textnumber.Location = new System.Drawing.Point(494, 145);
            this.textnumber.Name = "textnumber";
            this.textnumber.Size = new System.Drawing.Size(100, 31);
            this.textnumber.TabIndex = 1;
            this.textnumber.Text = "0";
            this.textnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "円";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "一人当たり";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "余り";
            // 
            // PerOne
            // 
            this.PerOne.AutoSize = true;
            this.PerOne.Location = new System.Drawing.Point(162, 247);
            this.PerOne.Name = "PerOne";
            this.PerOne.Size = new System.Drawing.Size(0, 24);
            this.PerOne.TabIndex = 0;
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.Location = new System.Drawing.Point(494, 247);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(0, 24);
            this.over.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textnumber);
            this.Controls.Add(this.textNoTaxPrice);
            this.Controls.Add(this.over);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PerOne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label PerOne;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNoTaxPrice;
        private System.Windows.Forms.TextBox textnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.Button button1;
    }
}

