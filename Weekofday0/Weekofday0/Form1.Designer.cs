
namespace Weekofday0
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
            this.labelAnswer = new System.Windows.Forms.Label();
            this.Hi = new System.Windows.Forms.NumericUpDown();
            this.Tuki = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTosi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tuki)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "日";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(636, 113);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(44, 18);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "曜日";
            this.labelAnswer.Click += new System.EventHandler(this.labelAnswer_Click);
            // 
            // Hi
            // 
            this.Hi.Location = new System.Drawing.Point(448, 111);
            this.Hi.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Hi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Hi.Name = "Hi";
            this.Hi.Size = new System.Drawing.Size(120, 25);
            this.Hi.TabIndex = 4;
            this.Hi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Tuki
            // 
            this.Tuki.Location = new System.Drawing.Point(268, 110);
            this.Tuki.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Tuki.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tuki.Name = "Tuki";
            this.Tuki.Size = new System.Drawing.Size(120, 25);
            this.Tuki.TabIndex = 5;
            this.Tuki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "曜日算出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxTosi
            // 
            this.textBoxTosi.Location = new System.Drawing.Point(74, 110);
            this.textBoxTosi.Name = "textBoxTosi";
            this.textBoxTosi.Size = new System.Drawing.Size(100, 25);
            this.textBoxTosi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTosi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tuki);
            this.Controls.Add(this.Hi);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "曜日算出";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tuki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.NumericUpDown Hi;
        private System.Windows.Forms.NumericUpDown Tuki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTosi;
    }
}

