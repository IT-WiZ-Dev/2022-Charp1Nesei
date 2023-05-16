
namespace p63
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
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelCheckBox = new System.Windows.Forms.Label();
            this.labelRadioButton1 = new System.Windows.Forms.Label();
            this.labelRadioButton2 = new System.Windows.Forms.Label();
            this.labelNumericUpDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Location = new System.Drawing.Point(22, 22);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(132, 22);
            this.checkbox1.TabIndex = 0;
            this.checkbox1.Text = "チェックボックス";
            this.checkbox1.UseVisualStyleBackColor = true;
            this.checkbox1.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 22);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ラジオボタン１";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 22);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ラジオボタン２";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(19, 151);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(170, 25);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelCheckBox
            // 
            this.labelCheckBox.AutoSize = true;
            this.labelCheckBox.Location = new System.Drawing.Point(250, 22);
            this.labelCheckBox.Name = "labelCheckBox";
            this.labelCheckBox.Size = new System.Drawing.Size(52, 18);
            this.labelCheckBox.TabIndex = 5;
            this.labelCheckBox.Text = "label1";
            this.labelCheckBox.Click += new System.EventHandler(this.labelCheckBox_Click);
            // 
            // labelRadioButton1
            // 
            this.labelRadioButton1.AutoSize = true;
            this.labelRadioButton1.Location = new System.Drawing.Point(250, 50);
            this.labelRadioButton1.Name = "labelRadioButton1";
            this.labelRadioButton1.Size = new System.Drawing.Size(52, 18);
            this.labelRadioButton1.TabIndex = 6;
            this.labelRadioButton1.Text = "label2";
            // 
            // labelRadioButton2
            // 
            this.labelRadioButton2.AutoSize = true;
            this.labelRadioButton2.Location = new System.Drawing.Point(250, 78);
            this.labelRadioButton2.Name = "labelRadioButton2";
            this.labelRadioButton2.Size = new System.Drawing.Size(52, 18);
            this.labelRadioButton2.TabIndex = 7;
            this.labelRadioButton2.Text = "label3";
            // 
            // labelNumericUpDown
            // 
            this.labelNumericUpDown.AutoSize = true;
            this.labelNumericUpDown.Location = new System.Drawing.Point(250, 130);
            this.labelNumericUpDown.Name = "labelNumericUpDown";
            this.labelNumericUpDown.Size = new System.Drawing.Size(52, 18);
            this.labelNumericUpDown.TabIndex = 8;
            this.labelNumericUpDown.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "ニューメリックアップダウン";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNumericUpDown);
            this.Controls.Add(this.labelRadioButton2);
            this.Controls.Add(this.labelRadioButton1);
            this.Controls.Add(this.labelCheckBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkbox1);
            this.Name = "Form1";
            this.Text = "4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelCheckBox;
        private System.Windows.Forms.Label labelRadioButton1;
        private System.Windows.Forms.Label labelRadioButton2;
        private System.Windows.Forms.Label labelNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}

