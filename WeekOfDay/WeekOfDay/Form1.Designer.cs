
namespace WeekOfDay
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
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "日";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(427, 82);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 3;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(73, 76);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(72, 26);
            this.textBoxYear.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 173);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(598, 37);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "曜日算出";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(189, 77);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(57, 26);
            this.numericUpDownMonth.TabIndex = 6;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Location = new System.Drawing.Point(307, 77);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownDay.TabIndex = 7;
            this.numericUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 320);
            this.Controls.Add(this.numericUpDownDay);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "曜日算出";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
    }
}

