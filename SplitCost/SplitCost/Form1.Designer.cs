
namespace SplitCost
{
    partial class FormAddTax
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
            this.labelhuman = new System.Windows.Forms.Label();
            this.textBoxMoney1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.human = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAddTax = new System.Windows.Forms.Label();
            this.labelAddTax2 = new System.Windows.Forms.Label();
            this.buttonAddTax = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // labelhuman
            // 
            this.labelhuman.AutoSize = true;
            this.labelhuman.Location = new System.Drawing.Point(272, 23);
            this.labelhuman.Name = "labelhuman";
            this.labelhuman.Size = new System.Drawing.Size(44, 18);
            this.labelhuman.TabIndex = 1;
            this.labelhuman.Text = "人数";
            // 
            // textBoxMoney1
            // 
            this.textBoxMoney1.Location = new System.Drawing.Point(29, 45);
            this.textBoxMoney1.Name = "textBoxMoney1";
            this.textBoxMoney1.Size = new System.Drawing.Size(100, 25);
            this.textBoxMoney1.TabIndex = 10;
            this.textBoxMoney1.Text = "0";
            this.textBoxMoney1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "円";
            // 
            // human
            // 
            this.human.Location = new System.Drawing.Point(275, 45);
            this.human.Name = "human";
            this.human.Size = new System.Drawing.Size(100, 25);
            this.human.TabIndex = 11;
            this.human.Text = "0";
            this.human.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "一人当たり";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "余り";
            // 
            // labelAddTax
            // 
            this.labelAddTax.AutoSize = true;
            this.labelAddTax.Location = new System.Drawing.Point(29, 149);
            this.labelAddTax.Name = "labelAddTax";
            this.labelAddTax.Size = new System.Drawing.Size(17, 18);
            this.labelAddTax.TabIndex = 6;
            this.labelAddTax.Text = "0";
            // 
            // labelAddTax2
            // 
            this.labelAddTax2.AutoSize = true;
            this.labelAddTax2.Location = new System.Drawing.Point(275, 149);
            this.labelAddTax2.Name = "labelAddTax2";
            this.labelAddTax2.Size = new System.Drawing.Size(17, 18);
            this.labelAddTax2.TabIndex = 8;
            this.labelAddTax2.Text = "0";
            // 
            // buttonAddTax
            // 
            this.buttonAddTax.Location = new System.Drawing.Point(84, 201);
            this.buttonAddTax.Name = "buttonAddTax";
            this.buttonAddTax.Size = new System.Drawing.Size(201, 34);
            this.buttonAddTax.TabIndex = 12;
            this.buttonAddTax.Text = "計算する";
            this.buttonAddTax.UseVisualStyleBackColor = true;
            this.buttonAddTax.Click += new System.EventHandler(this.buttonAddTax_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "円";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "円";
            // 
            // FormAddTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonAddTax);
            this.Controls.Add(this.labelAddTax2);
            this.Controls.Add(this.labelAddTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.human);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMoney1);
            this.Controls.Add(this.labelhuman);
            this.Controls.Add(this.label1);
            this.Name = "FormAddTax";
            this.Text = "割り勘";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelhuman;
        private System.Windows.Forms.TextBox textBoxMoney1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox human;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAddTax;
        private System.Windows.Forms.Label labelAddTax2;
        private System.Windows.Forms.Button buttonAddTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

