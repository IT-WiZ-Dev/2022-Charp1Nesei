
namespace WindowsFormsApp2
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
            this.labelCheckBox = new System.Windows.Forms.Label();
            this.labelRadioButton1 = new System.Windows.Forms.Label();
            this.labelRadioButton2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelNumericUpDown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(342, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "チェックボックス";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(345, 138);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ラジオボタン１";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(345, 181);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ラジオボタン２";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // labelCheckBox
            // 
            this.labelCheckBox.AutoSize = true;
            this.labelCheckBox.Location = new System.Drawing.Point(540, 102);
            this.labelCheckBox.Name = "labelCheckBox";
            this.labelCheckBox.Size = new System.Drawing.Size(114, 12);
            this.labelCheckBox.TabIndex = 4;
            this.labelCheckBox.Text = "ニューメリックアップダウン";
            this.labelCheckBox.Click += new System.EventHandler(this.labelCheckBox_Click);
            // 
            // labelRadioButton1
            // 
            this.labelRadioButton1.AutoSize = true;
            this.labelRadioButton1.Location = new System.Drawing.Point(540, 140);
            this.labelRadioButton1.Name = "labelRadioButton1";
            this.labelRadioButton1.Size = new System.Drawing.Size(35, 12);
            this.labelRadioButton1.TabIndex = 5;
            this.labelRadioButton1.Text = "label2";
            // 
            // labelRadioButton2
            // 
            this.labelRadioButton2.AutoSize = true;
            this.labelRadioButton2.Location = new System.Drawing.Point(540, 185);
            this.labelRadioButton2.Name = "labelRadioButton2";
            this.labelRadioButton2.Size = new System.Drawing.Size(35, 12);
            this.labelRadioButton2.TabIndex = 6;
            this.labelRadioButton2.Text = "label3";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(320, 226);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNumericUpDown
            // 
            this.labelNumericUpDown.AutoSize = true;
            this.labelNumericUpDown.Location = new System.Drawing.Point(540, 233);
            this.labelNumericUpDown.Name = "labelNumericUpDown";
            this.labelNumericUpDown.Size = new System.Drawing.Size(35, 12);
            this.labelNumericUpDown.TabIndex = 8;
            this.labelNumericUpDown.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 540);
            this.Controls.Add(this.labelNumericUpDown);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.labelRadioButton2);
            this.Controls.Add(this.labelRadioButton1);
            this.Controls.Add(this.labelCheckBox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label labelCheckBox;
        private System.Windows.Forms.Label labelRadioButton1;
        private System.Windows.Forms.Label labelRadioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelNumericUpDown;
    }
}

