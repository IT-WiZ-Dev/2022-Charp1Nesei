
namespace WeekOfDay
{
    partial class FormYoubi
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
            this.labelSeireki = new System.Windows.Forms.Label();
            this.textBoxToshi = new System.Windows.Forms.TextBox();
            this.labelTsuki = new System.Windows.Forms.Label();
            this.numericTsuki = new System.Windows.Forms.NumericUpDown();
            this.labelHi = new System.Windows.Forms.Label();
            this.numericHi = new System.Windows.Forms.NumericUpDown();
            this.labelYoubi = new System.Windows.Forms.Label();
            this.buttonSanshutsu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericTsuki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSeireki
            // 
            this.labelSeireki.AutoSize = true;
            this.labelSeireki.Location = new System.Drawing.Point(12, 9);
            this.labelSeireki.Name = "labelSeireki";
            this.labelSeireki.Size = new System.Drawing.Size(52, 15);
            this.labelSeireki.TabIndex = 0;
            this.labelSeireki.Text = "西暦年";
            this.labelSeireki.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxToshi
            // 
            this.textBoxToshi.Location = new System.Drawing.Point(15, 27);
            this.textBoxToshi.Name = "textBoxToshi";
            this.textBoxToshi.Size = new System.Drawing.Size(79, 22);
            this.textBoxToshi.TabIndex = 1;
            // 
            // labelTsuki
            // 
            this.labelTsuki.AutoSize = true;
            this.labelTsuki.Location = new System.Drawing.Point(120, 9);
            this.labelTsuki.Name = "labelTsuki";
            this.labelTsuki.Size = new System.Drawing.Size(22, 15);
            this.labelTsuki.TabIndex = 2;
            this.labelTsuki.Text = "月";
            // 
            // numericTsuki
            // 
            this.numericTsuki.Location = new System.Drawing.Point(123, 28);
            this.numericTsuki.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericTsuki.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTsuki.Name = "numericTsuki";
            this.numericTsuki.Size = new System.Drawing.Size(58, 22);
            this.numericTsuki.TabIndex = 3;
            this.numericTsuki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelHi
            // 
            this.labelHi.AutoSize = true;
            this.labelHi.Location = new System.Drawing.Point(208, 9);
            this.labelHi.Name = "labelHi";
            this.labelHi.Size = new System.Drawing.Size(22, 15);
            this.labelHi.TabIndex = 4;
            this.labelHi.Text = "日";
            // 
            // numericHi
            // 
            this.numericHi.Location = new System.Drawing.Point(211, 28);
            this.numericHi.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericHi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHi.Name = "numericHi";
            this.numericHi.Size = new System.Drawing.Size(58, 22);
            this.numericHi.TabIndex = 5;
            this.numericHi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelYoubi
            // 
            this.labelYoubi.AutoSize = true;
            this.labelYoubi.Location = new System.Drawing.Point(302, 30);
            this.labelYoubi.Name = "labelYoubi";
            this.labelYoubi.Size = new System.Drawing.Size(43, 15);
            this.labelYoubi.TabIndex = 6;
            this.labelYoubi.Text = "label1";
            // 
            // buttonSanshutsu
            // 
            this.buttonSanshutsu.Location = new System.Drawing.Point(12, 68);
            this.buttonSanshutsu.Name = "buttonSanshutsu";
            this.buttonSanshutsu.Size = new System.Drawing.Size(392, 34);
            this.buttonSanshutsu.TabIndex = 7;
            this.buttonSanshutsu.Text = "曜日算出";
            this.buttonSanshutsu.UseVisualStyleBackColor = true;
            this.buttonSanshutsu.Click += new System.EventHandler(this.buttonSanshutsu_Click);
            // 
            // FormYoubi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 114);
            this.Controls.Add(this.buttonSanshutsu);
            this.Controls.Add(this.labelYoubi);
            this.Controls.Add(this.numericHi);
            this.Controls.Add(this.labelHi);
            this.Controls.Add(this.numericTsuki);
            this.Controls.Add(this.labelTsuki);
            this.Controls.Add(this.textBoxToshi);
            this.Controls.Add(this.labelSeireki);
            this.Name = "FormYoubi";
            this.Text = "曜日算出";
            this.Load += new System.EventHandler(this.FormYoubi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericTsuki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeireki;
        private System.Windows.Forms.TextBox textBoxToshi;
        private System.Windows.Forms.Label labelTsuki;
        private System.Windows.Forms.NumericUpDown numericTsuki;
        private System.Windows.Forms.Label labelHi;
        private System.Windows.Forms.NumericUpDown numericHi;
        private System.Windows.Forms.Label labelYoubi;
        private System.Windows.Forms.Button buttonSanshutsu;
    }
}

