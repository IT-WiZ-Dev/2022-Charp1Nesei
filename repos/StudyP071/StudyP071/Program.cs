using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP071
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数宣言
            int a;
            double x, y;

            //変数の代入
            a = 123;

            //変数の参照
            Console.WriteLine(a);

            //名前
            string mame = "吉田温翔";

            //年齢
            int nennrei = 18;

            //性別
            char seibetu = '男';

            //身長
            double tall = 184.0;

            //体重
            double weight = 44.0;

            //成人してるか
            bool seijinn = true;

            //BMIを入れる変数
            double bmi =
                   weight / (tall * tall);
            //bmiを表示
            Console.WriteLine(bmi);

            //インクリメント，デクリメント
            Console.WriteLine(nennrei++);//後置インクリメント
            Console.WriteLine(++nennrei);//前置インクリメント

            //文字列連結
            Console.WriteLine( "私は"+name+"です。年齢は"  nennrei )
        //tallをm単位へ


            //複合代入演算子
            //身長から体重を引く処理
            tall -= weight;
                
                
                
                
                
                
                }







    }
}
