
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
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.numericUpDownManth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculation = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "日";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(68, 68);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 25);
            this.textBoxYear.TabIndex = 3;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // numericUpDownManth
            // 
            this.numericUpDownManth.Location = new System.Drawing.Point(223, 68);
            this.numericUpDownManth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownManth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownManth.Name = "numericUpDownManth";
            this.numericUpDownManth.Size = new System.Drawing.Size(62, 25);
            this.numericUpDownManth.TabIndex = 4;
            this.numericUpDownManth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Location = new System.Drawing.Point(335, 69);
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
            this.numericUpDownDay.Size = new System.Drawing.Size(61, 25);
            this.numericUpDownDay.TabIndex = 5;
            this.numericUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.ValueChanged += new System.EventHandler(this.numericUpDownDay_ValueChanged);
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.Location = new System.Drawing.Point(68, 112);
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.Size = new System.Drawing.Size(432, 59);
            this.buttonCalculation.TabIndex = 6;
            this.buttonCalculation.Text = "曜日算出";
            this.buttonCalculation.UseVisualStyleBackColor = true;
            this.buttonCalculation.Click += new System.EventHandler(this.ButtonCalculation_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(430, 69);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(52, 18);
            this.labelAnswer.TabIndex = 7;
            this.labelAnswer.Text = "label4";
            this.labelAnswer.Click += new System.EventHandler(this.labelAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 227);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.buttonCalculation);
            this.Controls.Add(this.numericUpDownDay);
            this.Controls.Add(this.numericUpDownManth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "曜日算出";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.NumericUpDown numericUpDownManth;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
        private System.Windows.Forms.Button buttonCalculation;
        private System.Windows.Forms.Label labelAnswer;
    }
}

