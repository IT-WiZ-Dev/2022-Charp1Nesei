
namespace WindowsFormsApp1_練習問題p63
{
    partial class コントロールの状態
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
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.radiobutton1 = new System.Windows.Forms.RadioButton();
            this.radiobutton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCheckBox = new System.Windows.Forms.Label();
            this.labelRadioButton1 = new System.Windows.Forms.Label();
            this.labelRadioButton2 = new System.Windows.Forms.Label();
            this.labelnumericUpDown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(31, 50);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(132, 22);
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.Text = "チェックボックス";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // radiobutton1
            // 
            this.radiobutton1.AutoSize = true;
            this.radiobutton1.Location = new System.Drawing.Point(31, 140);
            this.radiobutton1.Name = "radiobutton1";
            this.radiobutton1.Size = new System.Drawing.Size(123, 22);
            this.radiobutton1.TabIndex = 1;
            this.radiobutton1.TabStop = true;
            this.radiobutton1.Text = "ラジオボタン1";
            this.radiobutton1.UseVisualStyleBackColor = true;
            this.radiobutton1.CheckedChanged += new System.EventHandler(this.radiobutton1_CheckedChanged);
            // 
            // radiobutton2
            // 
            this.radiobutton2.AutoSize = true;
            this.radiobutton2.Location = new System.Drawing.Point(31, 212);
            this.radiobutton2.Name = "radiobutton2";
            this.radiobutton2.Size = new System.Drawing.Size(123, 22);
            this.radiobutton2.TabIndex = 2;
            this.radiobutton2.TabStop = true;
            this.radiobutton2.Text = "ラジオボタン2";
            this.radiobutton2.UseVisualStyleBackColor = true;
            this.radiobutton2.CheckedChanged += new System.EventHandler(this.radiobutton2_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(34, 291);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(175, 25);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.ニューメリックアップダウン_ValueChanged);
            this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ニューメリックアップダウン";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCheckBox
            // 
            this.labelCheckBox.AutoSize = true;
            this.labelCheckBox.Location = new System.Drawing.Point(432, 50);
            this.labelCheckBox.Name = "labelCheckBox";
            this.labelCheckBox.Size = new System.Drawing.Size(52, 18);
            this.labelCheckBox.TabIndex = 6;
            this.labelCheckBox.Text = "label1";
            this.labelCheckBox.Click += new System.EventHandler(this.labelCheckBox_Click);
            // 
            // labelRadioButton1
            // 
            this.labelRadioButton1.AutoSize = true;
            this.labelRadioButton1.Location = new System.Drawing.Point(432, 143);
            this.labelRadioButton1.Name = "labelRadioButton1";
            this.labelRadioButton1.Size = new System.Drawing.Size(52, 18);
            this.labelRadioButton1.TabIndex = 7;
            this.labelRadioButton1.Text = "label2";
            this.labelRadioButton1.Click += new System.EventHandler(this.labelRadioButtin1_Click);
            // 
            // labelRadioButton2
            // 
            this.labelRadioButton2.AutoSize = true;
            this.labelRadioButton2.Location = new System.Drawing.Point(432, 212);
            this.labelRadioButton2.Name = "labelRadioButton2";
            this.labelRadioButton2.Size = new System.Drawing.Size(52, 18);
            this.labelRadioButton2.TabIndex = 8;
            this.labelRadioButton2.Text = "label3";
            this.labelRadioButton2.CursorChanged += new System.EventHandler(this.labelRadioButton2_CursorChanged);
            this.labelRadioButton2.Click += new System.EventHandler(this.labelRadioButton2_Click);
            // 
            // labelnumericUpDown
            // 
            this.labelnumericUpDown.AutoSize = true;
            this.labelnumericUpDown.Location = new System.Drawing.Point(435, 291);
            this.labelnumericUpDown.Name = "labelnumericUpDown";
            this.labelnumericUpDown.Size = new System.Drawing.Size(52, 18);
            this.labelnumericUpDown.TabIndex = 9;
            this.labelnumericUpDown.Text = "label4";
            this.labelnumericUpDown.Click += new System.EventHandler(this.labelNumericUpDown_Click);
            // 
            // コントロールの状態
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelnumericUpDown);
            this.Controls.Add(this.labelRadioButton2);
            this.Controls.Add(this.labelRadioButton1);
            this.Controls.Add(this.labelCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.radiobutton2);
            this.Controls.Add(this.radiobutton1);
            this.Controls.Add(this.CheckBox1);
            this.Name = "コントロールの状態";
            this.Text = "コントロールの状態";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.RadioButton radiobutton1;
        private System.Windows.Forms.RadioButton radiobutton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCheckBox;
        private System.Windows.Forms.Label labelRadioButton1;
        private System.Windows.Forms.Label labelRadioButton2;
        private System.Windows.Forms.Label labelnumericUpDown;
    }
}

