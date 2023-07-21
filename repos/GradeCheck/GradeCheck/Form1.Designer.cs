
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
            this.labelResultM = new System.Windows.Forms.Label();
            this.textBoxScoreM = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceE = new System.Windows.Forms.TextBox();
            this.textBoxScoreE = new System.Windows.Forms.TextBox();
            this.textBoxScoreP = new System.Windows.Forms.TextBox();
            this.labelCompAvgM = new System.Windows.Forms.Label();
            this.labelCompAvgP = new System.Windows.Forms.Label();
            this.labelResultP = new System.Windows.Forms.Label();
            this.labelCompAvgE = new System.Windows.Forms.Label();
            this.labelResultE = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonJudge = new System.Windows.Forms.Button();
            this.buttonReat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAttendanceM
            // 
            this.textBoxAttendanceM.Location = new System.Drawing.Point(105, 72);
            this.textBoxAttendanceM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAttendanceM.Name = "textBoxAttendanceM";
            this.textBoxAttendanceM.Size = new System.Drawing.Size(164, 31);
            this.textBoxAttendanceM.TabIndex = 0;
            this.textBoxAttendanceM.Text = "0.0";
            this.textBoxAttendanceM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAttendanceM.Click += new System.EventHandler(this.Form1_Load);
            this.textBoxAttendanceM.TextChanged += new System.EventHandler(this.texBoxAttendanceM_TextChanged);
            // 
            // textBoxAttendanceP
            // 
            this.textBoxAttendanceP.Location = new System.Drawing.Point(105, 156);
            this.textBoxAttendanceP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAttendanceP.Name = "textBoxAttendanceP";
            this.textBoxAttendanceP.Size = new System.Drawing.Size(164, 31);
            this.textBoxAttendanceP.TabIndex = 1;
            this.textBoxAttendanceP.Text = "0.0";
            this.textBoxAttendanceP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAttendanceP.Click += new System.EventHandler(this.Form1_Load);
            this.textBoxAttendanceP.TextChanged += new System.EventHandler(this.textBoxAttendanceP_TextChanged);
            // 
            // labelResultM
            // 
            this.labelResultM.AutoSize = true;
            this.labelResultM.Location = new System.Drawing.Point(542, 77);
            this.labelResultM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultM.Name = "labelResultM";
            this.labelResultM.Size = new System.Drawing.Size(58, 24);
            this.labelResultM.TabIndex = 2;
            this.labelResultM.Text = "合格";
            // 
            // textBoxScoreM
            // 
            this.textBoxScoreM.Location = new System.Drawing.Point(369, 68);
            this.textBoxScoreM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxScoreM.Name = "textBoxScoreM";
            this.textBoxScoreM.Size = new System.Drawing.Size(164, 31);
            this.textBoxScoreM.TabIndex = 4;
            this.textBoxScoreM.Text = "0";
            this.textBoxScoreM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxScoreM.TextChanged += new System.EventHandler(this.textBoxScoreM_TextChanged);
            // 
            // textBoxAttendanceE
            // 
            this.textBoxAttendanceE.Location = new System.Drawing.Point(105, 235);
            this.textBoxAttendanceE.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAttendanceE.Name = "textBoxAttendanceE";
            this.textBoxAttendanceE.Size = new System.Drawing.Size(164, 31);
            this.textBoxAttendanceE.TabIndex = 3;
            this.textBoxAttendanceE.Text = "0.0";
            this.textBoxAttendanceE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAttendanceE.Click += new System.EventHandler(this.Form1_Load);
            this.textBoxAttendanceE.TextChanged += new System.EventHandler(this.textBoxAttendanceE_TextChanged);
            // 
            // textBoxScoreE
            // 
            this.textBoxScoreE.Location = new System.Drawing.Point(365, 231);
            this.textBoxScoreE.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxScoreE.Name = "textBoxScoreE";
            this.textBoxScoreE.Size = new System.Drawing.Size(164, 31);
            this.textBoxScoreE.TabIndex = 6;
            this.textBoxScoreE.Text = "0";
            this.textBoxScoreE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxScoreE.Click += new System.EventHandler(this.Form1_Load);
            this.textBoxScoreE.TextChanged += new System.EventHandler(this.textBoxScoreE_TextChanged);
            // 
            // textBoxScoreP
            // 
            this.textBoxScoreP.Location = new System.Drawing.Point(365, 147);
            this.textBoxScoreP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxScoreP.Name = "textBoxScoreP";
            this.textBoxScoreP.Size = new System.Drawing.Size(164, 31);
            this.textBoxScoreP.TabIndex = 5;
            this.textBoxScoreP.Text = "0";
            this.textBoxScoreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxScoreP.Click += new System.EventHandler(this.Form1_Load);
            this.textBoxScoreP.TextChanged += new System.EventHandler(this.textBoxScoreP_TextChanged);
            // 
            // labelCompAvgM
            // 
            this.labelCompAvgM.AutoSize = true;
            this.labelCompAvgM.Location = new System.Drawing.Point(668, 72);
            this.labelCompAvgM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompAvgM.Name = "labelCompAvgM";
            this.labelCompAvgM.Size = new System.Drawing.Size(130, 24);
            this.labelCompAvgM.TabIndex = 7;
            this.labelCompAvgM.Text = "平均点以上";
            // 
            // labelCompAvgP
            // 
            this.labelCompAvgP.AutoSize = true;
            this.labelCompAvgP.Location = new System.Drawing.Point(668, 156);
            this.labelCompAvgP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompAvgP.Name = "labelCompAvgP";
            this.labelCompAvgP.Size = new System.Drawing.Size(130, 24);
            this.labelCompAvgP.TabIndex = 9;
            this.labelCompAvgP.Text = "平均点以上";
            // 
            // labelResultP
            // 
            this.labelResultP.AutoSize = true;
            this.labelResultP.Location = new System.Drawing.Point(542, 160);
            this.labelResultP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultP.Name = "labelResultP";
            this.labelResultP.Size = new System.Drawing.Size(58, 24);
            this.labelResultP.TabIndex = 8;
            this.labelResultP.Text = "合格";
            // 
            // labelCompAvgE
            // 
            this.labelCompAvgE.AutoSize = true;
            this.labelCompAvgE.Location = new System.Drawing.Point(668, 240);
            this.labelCompAvgE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompAvgE.Name = "labelCompAvgE";
            this.labelCompAvgE.Size = new System.Drawing.Size(130, 24);
            this.labelCompAvgE.TabIndex = 11;
            this.labelCompAvgE.Text = "平均点以上";
            // 
            // labelResultE
            // 
            this.labelResultE.AutoSize = true;
            this.labelResultE.Location = new System.Drawing.Point(542, 244);
            this.labelResultE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultE.Name = "labelResultE";
            this.labelResultE.Size = new System.Drawing.Size(58, 24);
            this.labelResultE.TabIndex = 10;
            this.labelResultE.Text = "合格";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "得点";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "出席率";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "平均点と比較";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "判定結果";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 240);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "英語";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 156);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "物理";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 72);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 24);
            this.label13.TabIndex = 16;
            this.label13.Text = "数学";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(278, 240);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "％";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 156);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 24);
            this.label15.TabIndex = 20;
            this.label15.Text = "％";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(278, 72);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 24);
            this.label16.TabIndex = 19;
            this.label16.Text = "％";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 12);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 24);
            this.label17.TabIndex = 22;
            this.label17.Text = "科目";
            // 
            // buttonJudge
            // 
            this.buttonJudge.Location = new System.Drawing.Point(259, 323);
            this.buttonJudge.Margin = new System.Windows.Forms.Padding(4);
            this.buttonJudge.Name = "buttonJudge";
            this.buttonJudge.Size = new System.Drawing.Size(97, 31);
            this.buttonJudge.TabIndex = 23;
            this.buttonJudge.Text = "判定";
            this.buttonJudge.UseVisualStyleBackColor = true;
            this.buttonJudge.Click += new System.EventHandler(this.ButtonJudge_Click);
            // 
            // buttonReat
            // 
            this.buttonReat.Location = new System.Drawing.Point(407, 323);
            this.buttonReat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReat.Name = "buttonReat";
            this.buttonReat.Size = new System.Drawing.Size(97, 31);
            this.buttonReat.TabIndex = 24;
            this.buttonReat.Text = "リセット";
            this.buttonReat.UseVisualStyleBackColor = true;
            this.buttonReat.Click += new System.EventHandler(this.buttonReat_Click);
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.buttonReat);
            this.Controls.Add(this.buttonJudge);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelCompAvgE);
            this.Controls.Add(this.labelResultE);
            this.Controls.Add(this.labelCompAvgP);
            this.Controls.Add(this.labelResultP);
            this.Controls.Add(this.labelCompAvgM);
            this.Controls.Add(this.textBoxScoreE);
            this.Controls.Add(this.textBoxScoreP);
            this.Controls.Add(this.textBoxScoreM);
            this.Controls.Add(this.textBoxAttendanceE);
            this.Controls.Add(this.labelResultM);
            this.Controls.Add(this.textBoxAttendanceP);
            this.Controls.Add(this.textBoxAttendanceM);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGrade";
            this.Text = "成績判定";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.texBoxAttendanceM_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAttendanceM;
        private System.Windows.Forms.TextBox textBoxAttendanceP;
        private System.Windows.Forms.Label labelResultM;
        private System.Windows.Forms.TextBox textBoxScoreM;
        private System.Windows.Forms.TextBox textBoxAttendanceE;
        private System.Windows.Forms.TextBox textBoxScoreE;
        private System.Windows.Forms.TextBox textBoxScoreP;
        private System.Windows.Forms.Label labelCompAvgM;
        private System.Windows.Forms.Label labelCompAvgP;
        private System.Windows.Forms.Label labelResultP;
        private System.Windows.Forms.Label labelCompAvgE;
        private System.Windows.Forms.Label labelResultE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonJudge;
        private System.Windows.Forms.Button buttonReat;
    }
}

