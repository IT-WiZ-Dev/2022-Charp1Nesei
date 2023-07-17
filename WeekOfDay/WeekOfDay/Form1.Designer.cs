
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(176, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(436, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(605, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "日";
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDayOfWeek.Location = new System.Drawing.Point(672, 104);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(0, 30);
            this.labelDayOfWeek.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(310, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "曜日算出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxYear.Location = new System.Drawing.Point(160, 96);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(121, 38);
            this.textBoxYear.TabIndex = 0;
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDownMonth.Location = new System.Drawing.Point(310, 96);
            this.numericUpDownMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            this.numericUpDownMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(120, 38);
            this.numericUpDownMonth.TabIndex = 1;
            this.numericUpDownMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDownDay.Location = new System.Drawing.Point(479, 96);
            this.numericUpDownDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.numericUpDownDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(120, 38);
            this.numericUpDownDay.TabIndex = 2;
            this.numericUpDownDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 309);
            this.Controls.Add(this.numericUpDownDay);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDayOfWeek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
    }
}

