using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCheck
{
    public partial class FormGrade : Form
    {
        public FormGrade()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
        }

        private void texBoxAttendanceM_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxScoreM_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAttendanceP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxScoreP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAttendanceE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxScoreE_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReat_Click(object sender, EventArgs e)
        {

        }
        private void TextToValue(string text, out double val)
        {
            if (double.TryParse(text, out val) == false)
                val = -1.0;
        }

        private void TextToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }

        private string ScoreJudge(double attendance, int score)
        {
            string result;

            if (attendance < 0.0 || attendance > 100.0 ||
                score < 0 || score > 100)
                result = "エラー";
            else if(attendance >= 80.0)
            {
                if (score >= 80)
                    result = "A判定";
                else if (score >= 70)
                    result = "B判定";
                else if (score >= 60)
                    result = "C判定";
                else
                    result = "不合格";
            }
            else
                result = "不合格";

            return result;
            }

                private string AveageJudge( int score, string subject)
        {
            string result;
            int average;

            const int MathAverage = 73;    　　//数学の平均点
            const int PhysicalAverage = 65;　 //物理の平均点
            const int EhglishAverage = 77; 　 //英語の平均点

            if (score < 0 || score > 100)
                return "エラー";

            switch (subject)
            {
                case "数学":
                    average = MathAverage;
                    break;
                case "物理":
                    average = PhysicalAverage;
                    break;
                case "英語":
                    average = EhglishAverage;
                    break;
                default:
                    return "エラー";
            }

            if (score >= average)
                result = "平均点以上";
            else
                result = "平均点未満";

            return result;

            }
        
        private void ButtonJudge_Click(object sender, EventArgs e)
        {
            //出席率を浮動小数点値に変換
            double attendanceM, attendanceP, attendanceE;
            TextToValue(textBoxScoreM.Text, out attendanceM);
            TextToValue(textBoxScoreP.Text, out attendanceP);
            TextToValue(textBoxScoreP.Text, out attendanceE);

            //得点を整数値に変換
            int scoreM, scoreP, scoreE;
            TextToValue(textBoxScoreM.Text, out scoreM);
            TextToValue(textBoxScoreP.Text, out scoreP);
            TextToValue(textBoxScoreE.Text, out scoreE);

            //成績を判定する
            labelResultM.Text = ScoreJudge(attendanceM, scoreM);
            labelResultM.Text = ScoreJudge(attendanceP, scoreP);
            labelResultM.Text = ScoreJudge(attendanceE, scoreE);

            //

            labelResultM.Text = ScoreJudge(attendanceM, scoreM);
            labelResultP.Text = ScoreJudge(attendanceP, scoreP);
            labelResultE.Text = ScoreJudge(attendanceE, scoreE);

            //
            labelCompAvgM.Text = AveageJudge(scoreM, "数学");
            labelCompAvgP.Text = AveageJudge(scoreP, "物理");
            labelCompAvgE.Text = AveageJudge(scoreE, "物理");

        }
        private void ButtonReset_Click(object sender, EventArgs e)

        {
            textBoxAttendanceM.Text = "0.0";
            textBoxAttendanceP.Text = "0.0";
            textBoxAttendanceE.Text = "0.0";
            textBoxScoreM.Text = "0";
            textBoxScoreP.Text = "0";
            textBoxScoreE.Text = "0";
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";

        }








    }










        
    }
