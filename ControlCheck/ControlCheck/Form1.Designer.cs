
namespace ControlCheck
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
            this.label2 = new System.Windows.Forms.Label();
            this.Clabel = new System.Windows.Forms.Label();
            this.Rlabel1 = new System.Windows.Forms.Label();
            this.Rlabel2 = new System.Windows.Forms.Label();
            this.Nlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 22);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "チェックボックス";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 22);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ラジオボタン１";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 99);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 22);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ラジオボタン2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 187);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "ニューメリックアップダウン";
            // 
            // Clabel
            // 
            this.Clabel.AutoSize = true;
            this.Clabel.Location = new System.Drawing.Point(188, 16);
            this.Clabel.Name = "Clabel";
            this.Clabel.Size = new System.Drawing.Size(55, 18);
            this.Clabel.TabIndex = 6;
            this.Clabel.Text = "label１";
            // 
            // Rlabel1
            // 
            this.Rlabel1.AutoSize = true;
            this.Rlabel1.Location = new System.Drawing.Point(188, 70);
            this.Rlabel1.Name = "Rlabel1";
            this.Rlabel1.Size = new System.Drawing.Size(52, 18);
            this.Rlabel1.TabIndex = 7;
            this.Rlabel1.Text = "label2";
            // 
            // Rlabel2
            // 
            this.Rlabel2.AutoSize = true;
            this.Rlabel2.Location = new System.Drawing.Point(188, 127);
            this.Rlabel2.Name = "Rlabel2";
            this.Rlabel2.Size = new System.Drawing.Size(52, 18);
            this.Rlabel2.TabIndex = 8;
            this.Rlabel2.Text = "label3";
            this.Rlabel2.Click += new System.EventHandler(this.label5_Click);
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Location = new System.Drawing.Point(188, 187);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(52, 18);
            this.Nlabel.TabIndex = 9;
            this.Nlabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nlabel);
            this.Controls.Add(this.Rlabel2);
            this.Controls.Add(this.Rlabel1);
            this.Controls.Add(this.Clabel);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Clabel;
        private System.Windows.Forms.Label Rlabel1;
        private System.Windows.Forms.Label Rlabel2;
        private System.Windows.Forms.Label Nlabel;
    }
}

