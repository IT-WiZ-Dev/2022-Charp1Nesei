
namespace WindowsFormsApp3
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Clabel1 = new System.Windows.Forms.Label();
            this.Rlabel1 = new System.Windows.Forms.Label();
            this.Rlabel2 = new System.Windows.Forms.Label();
            this.Newlabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(53, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "チェックボックス";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(53, 108);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 22);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ラジオボタン１";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(53, 162);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 22);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ラジオボタン２";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(53, 242);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Clabel1
            // 
            this.Clabel1.AutoSize = true;
            this.Clabel1.Location = new System.Drawing.Point(365, 54);
            this.Clabel1.Name = "Clabel1";
            this.Clabel1.Size = new System.Drawing.Size(52, 18);
            this.Clabel1.TabIndex = 5;
            this.Clabel1.Text = "label1";
            // 
            // Rlabel1
            // 
            this.Rlabel1.AutoSize = true;
            this.Rlabel1.Location = new System.Drawing.Point(365, 108);
            this.Rlabel1.Name = "Rlabel1";
            this.Rlabel1.Size = new System.Drawing.Size(52, 18);
            this.Rlabel1.TabIndex = 6;
            this.Rlabel1.Text = "label2";
            // 
            // Rlabel2
            // 
            this.Rlabel2.AutoSize = true;
            this.Rlabel2.Location = new System.Drawing.Point(365, 162);
            this.Rlabel2.Name = "Rlabel2";
            this.Rlabel2.Size = new System.Drawing.Size(52, 18);
            this.Rlabel2.TabIndex = 7;
            this.Rlabel2.Text = "label3";
            // 
            // Newlabel1
            // 
            this.Newlabel1.AutoSize = true;
            this.Newlabel1.Location = new System.Drawing.Point(365, 221);
            this.Newlabel1.Name = "Newlabel1";
            this.Newlabel1.Size = new System.Drawing.Size(52, 18);
            this.Newlabel1.TabIndex = 8;
            this.Newlabel1.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "ニューメリックアップダウン";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Newlabel1);
            this.Controls.Add(this.Rlabel2);
            this.Controls.Add(this.Rlabel1);
            this.Controls.Add(this.Clabel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "コントロールの状態";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Clabel1;
        private System.Windows.Forms.Label Rlabel1;
        private System.Windows.Forms.Label Rlabel2;
        private System.Windows.Forms.Label Newlabel1;
        private System.Windows.Forms.Label label1;
    }
}

