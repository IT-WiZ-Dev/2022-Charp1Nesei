
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
            this.textBoxnen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownTuk = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownday = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.labelsan = new System.Windows.Forms.Label();
            this.buttonkei = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // textBoxnen
            // 
            this.textBoxnen.Location = new System.Drawing.Point(35, 60);
            this.textBoxnen.Name = "textBoxnen";
            this.textBoxnen.Size = new System.Drawing.Size(100, 25);
            this.textBoxnen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "月";
            // 
            // numericUpDownTuk
            // 
            this.numericUpDownTuk.Location = new System.Drawing.Point(158, 60);
            this.numericUpDownTuk.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownTuk.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTuk.Name = "numericUpDownTuk";
            this.numericUpDownTuk.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownTuk.TabIndex = 3;
            this.numericUpDownTuk.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownday
            // 
            this.numericUpDownday.Location = new System.Drawing.Point(321, 61);
            this.numericUpDownday.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownday.Name = "numericUpDownday";
            this.numericUpDownday.Size = new System.Drawing.Size(99, 25);
            this.numericUpDownday.TabIndex = 4;
            this.numericUpDownday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "日";
            // 
            // labelsan
            // 
            this.labelsan.AutoSize = true;
            this.labelsan.Location = new System.Drawing.Point(469, 63);
            this.labelsan.Name = "labelsan";
            this.labelsan.Size = new System.Drawing.Size(52, 18);
            this.labelsan.TabIndex = 6;
            this.labelsan.Text = "label4";
            // 
            // buttonkei
            // 
            this.buttonkei.Location = new System.Drawing.Point(35, 109);
            this.buttonkei.Name = "buttonkei";
            this.buttonkei.Size = new System.Drawing.Size(486, 34);
            this.buttonkei.TabIndex = 7;
            this.buttonkei.Text = "曜日算出";
            this.buttonkei.UseVisualStyleBackColor = true;
            this.buttonkei.Click += new System.EventHandler(this.buttonkei_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 167);
            this.Controls.Add(this.buttonkei);
            this.Controls.Add(this.labelsan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownday);
            this.Controls.Add(this.numericUpDownTuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxnen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "曜日算出";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownTuk;
        private System.Windows.Forms.NumericUpDown numericUpDownday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelsan;
        private System.Windows.Forms.Button buttonkei;
    }
}

