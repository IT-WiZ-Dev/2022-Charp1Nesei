
namespace GradeCheck
{
    partial class FormGrade
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
            this.textBoxAttendanceM = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceP = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceE = new System.Windows.Forms.TextBox();
            this.textBoxScoreP = new System.Windows.Forms.TextBox();
            this.textBoxScoreE = new System.Windows.Forms.TextBox();
            this.textBoxScoreM = new System.Windows.Forms.TextBox();
            this.labelResultM = new System.Windows.Forms.Label();
            this.labelResultP = new System.Windows.Forms.Label();
            this.labelResultE = new System.Windows.Forms.Label();
            this.labelCompAvgM = new System.Windows.Forms.Label();
            this.labelCompAvgP = new System.Windows.Forms.Label();
            this.labelCompAvgE = new System.Windows.Forms.Label();
            this.buttonJudge = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAttendanceM
            // 
            this.textBoxAttendanceM.Location = new System.Drawing.Point(140, 123);
            this.textBoxAttendanceM.Name = "textBoxAttendanceM";
            this.textBoxAttendanceM.Size = new System.Drawing.Size(101, 22);
            this.textBoxAttendanceM.TabIndex = 1;
            this.textBoxAttendanceM.Text = "0.0";
            this.textBoxAttendanceM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceP
            // 
            this.textBoxAttendanceP.Location = new System.Drawing.Point(140, 192);
            this.textBoxAttendanceP.Name = "textBoxAttendanceP";
            this.textBoxAttendanceP.Size = new System.Drawing.Size(100, 22);
            this.textBoxAttendanceP.TabIndex = 3;
            this.textBoxAttendanceP.Text = "0.0";
            this.textBoxAttendanceP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceE
            // 
            this.textBoxAttendanceE.Location = new System.Drawing.Point(141, 257);
            this.textBoxAttendanceE.Name = "textBoxAttendanceE";
            this.textBoxAttendanceE.Size = new System.Drawing.Size(100, 22);
            this.textBoxAttendanceE.TabIndex = 5;
            this.textBoxAttendanceE.Text = "0.0";
            this.textBoxAttendanceE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreP
            // 
            this.textBoxScoreP.Location = new System.Drawing.Point(318, 192);
            this.textBoxScoreP.Name = "textBoxScoreP";
            this.textBoxScoreP.Size = new System.Drawing.Size(100, 22);
            this.textBoxScoreP.TabIndex = 4;
            this.textBoxScoreP.Text = "0";
            this.textBoxScoreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreE
            // 
            this.textBoxScoreE.Location = new System.Drawing.Point(318, 257);
            this.textBoxScoreE.Name = "textBoxScoreE";
            this.textBoxScoreE.Size = new System.Drawing.Size(100, 22);
            this.textBoxScoreE.TabIndex = 6;
            this.textBoxScoreE.Text = "0";
            this.textBoxScoreE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreM
            // 
            this.textBoxScoreM.Location = new System.Drawing.Point(318, 123);
            this.textBoxScoreM.Name = "textBoxScoreM";
            this.textBoxScoreM.Size = new System.Drawing.Size(100, 22);
            this.textBoxScoreM.TabIndex = 2;
            this.textBoxScoreM.Text = "0";
            this.textBoxScoreM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelResultM
            // 
            this.labelResultM.AutoSize = true;
            this.labelResultM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultM.Location = new System.Drawing.Point(499, 123);
            this.labelResultM.Name = "labelResultM";
            this.labelResultM.Size = new System.Drawing.Size(51, 20);
            this.labelResultM.TabIndex = 6;
            this.labelResultM.Text = "合格";
            // 
            // labelResultP
            // 
            this.labelResultP.AutoSize = true;
            this.labelResultP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultP.Location = new System.Drawing.Point(499, 199);
            this.labelResultP.Name = "labelResultP";
            this.labelResultP.Size = new System.Drawing.Size(51, 20);
            this.labelResultP.TabIndex = 7;
            this.labelResultP.Text = "合格";
            // 
            // labelResultE
            // 
            this.labelResultE.AutoSize = true;
            this.labelResultE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultE.Location = new System.Drawing.Point(499, 260);
            this.labelResultE.Name = "labelResultE";
            this.labelResultE.Size = new System.Drawing.Size(51, 20);
            this.labelResultE.TabIndex = 8;
            this.labelResultE.Text = "合格";
            // 
            // labelCompAvgM
            // 
            this.labelCompAvgM.AutoSize = true;
            this.labelCompAvgM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgM.Location = new System.Drawing.Point(622, 123);
            this.labelCompAvgM.Name = "labelCompAvgM";
            this.labelCompAvgM.Size = new System.Drawing.Size(114, 20);
            this.labelCompAvgM.TabIndex = 9;
            this.labelCompAvgM.Text = "平均点以上";
            // 
            // labelCompAvgP
            // 
            this.labelCompAvgP.AutoSize = true;
            this.labelCompAvgP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgP.Location = new System.Drawing.Point(622, 199);
            this.labelCompAvgP.Name = "labelCompAvgP";
            this.labelCompAvgP.Size = new System.Drawing.Size(114, 20);
            this.labelCompAvgP.TabIndex = 10;
            this.labelCompAvgP.Text = "平均点以上";
            // 
            // labelCompAvgE
            // 
            this.labelCompAvgE.AutoSize = true;
            this.labelCompAvgE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgE.Location = new System.Drawing.Point(622, 260);
            this.labelCompAvgE.Name = "labelCompAvgE";
            this.labelCompAvgE.Size = new System.Drawing.Size(114, 20);
            this.labelCompAvgE.TabIndex = 11;
            this.labelCompAvgE.Text = "平均点以上";
            // 
            // buttonJudge
            // 
            this.buttonJudge.Location = new System.Drawing.Point(234, 351);
            this.buttonJudge.Name = "buttonJudge";
            this.buttonJudge.Size = new System.Drawing.Size(75, 23);
            this.buttonJudge.TabIndex = 7;
            this.buttonJudge.Text = "判定";
            this.buttonJudge.UseVisualStyleBackColor = true;
            this.buttonJudge.Click += new System.EventHandler(this.ButtonJudge_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(445, 351);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "リセット";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "科目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "数学";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "物理";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "英語";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "出席率";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "得点";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "判定結果";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "平均点と比較";
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonJudge);
            this.Controls.Add(this.labelCompAvgE);
            this.Controls.Add(this.labelCompAvgP);
            this.Controls.Add(this.labelCompAvgM);
            this.Controls.Add(this.labelResultE);
            this.Controls.Add(this.labelResultP);
            this.Controls.Add(this.labelResultM);
            this.Controls.Add(this.textBoxScoreM);
            this.Controls.Add(this.textBoxScoreE);
            this.Controls.Add(this.textBoxScoreP);
            this.Controls.Add(this.textBoxAttendanceE);
            this.Controls.Add(this.textBoxAttendanceP);
            this.Controls.Add(this.textBoxAttendanceM);
            this.Name = "FormGrade";
            this.Text = "成績判定";
            this.Load += new System.EventHandler(this.FormGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAttendanceM;
        private System.Windows.Forms.TextBox textBoxAttendanceP;
        private System.Windows.Forms.TextBox textBoxAttendanceE;
        private System.Windows.Forms.TextBox textBoxScoreP;
        private System.Windows.Forms.TextBox textBoxScoreE;
        private System.Windows.Forms.TextBox textBoxScoreM;
        private System.Windows.Forms.Label labelResultM;
        private System.Windows.Forms.Label labelResultP;
        private System.Windows.Forms.Label labelResultE;
        private System.Windows.Forms.Label labelCompAvgM;
        private System.Windows.Forms.Label labelCompAvgP;
        private System.Windows.Forms.Label labelCompAvgE;
        private System.Windows.Forms.Button buttonJudge;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

