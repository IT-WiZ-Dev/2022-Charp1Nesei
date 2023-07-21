
namespace weekofday
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
            this.year1 = new System.Windows.Forms.Label();
            this.month1 = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.Label();
            this.week = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.day = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            this.SuspendLayout();
            // 
            // year1
            // 
            this.year1.AutoSize = true;
            this.year1.Location = new System.Drawing.Point(73, 35);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(52, 15);
            this.year1.TabIndex = 0;
            this.year1.Text = "西暦年";
            // 
            // month1
            // 
            this.month1.AutoSize = true;
            this.month1.Location = new System.Drawing.Point(224, 36);
            this.month1.Name = "month1";
            this.month1.Size = new System.Drawing.Size(22, 15);
            this.month1.TabIndex = 1;
            this.month1.Text = "月";
            // 
            // day1
            // 
            this.day1.AutoSize = true;
            this.day1.Location = new System.Drawing.Point(350, 35);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(22, 15);
            this.day1.TabIndex = 2;
            this.day1.Text = "日";
            // 
            // week
            // 
            this.week.AutoSize = true;
            this.week.Location = new System.Drawing.Point(479, 56);
            this.week.Name = "week";
            this.week.Size = new System.Drawing.Size(88, 15);
            this.week.TabIndex = 3;
            this.week.Text = "曜日が出ます";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(76, 53);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 22);
            this.year.TabIndex = 5;
            this.year.TextChanged += new System.EventHandler(this.year_TextChanged);
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(76, 128);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(446, 23);
            this.go.TabIndex = 6;
            this.go.Text = "曜日算出";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(227, 54);
            this.month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(81, 22);
            this.month.TabIndex = 7;
            this.month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(353, 53);
            this.day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(83, 22);
            this.day.TabIndex = 8;
            this.day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.go);
            this.Controls.Add(this.year);
            this.Controls.Add(this.week);
            this.Controls.Add(this.day1);
            this.Controls.Add(this.month1);
            this.Controls.Add(this.year1);
            this.Name = "Form1";
            this.Text = "曜日算出";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label year1;
        private System.Windows.Forms.Label month1;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.Label week;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.NumericUpDown day;
    }
}

