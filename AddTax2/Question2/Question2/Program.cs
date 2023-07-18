using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 問2
 * 変数ageは遊園地の入場者の年齢が格納されている。
 * 年齢の値によって入場料を算出するプログラムを、
 * if文の【（）】の中身を記述して完成させよ。
 * ※【（）】の中以外をコーディングするのはNGとする。
 * ※論理式（AND、OR）を使わないとできない。
 * 
 * また料金表は以下の通りである。
 * 幼児（6歳以下）　　　　　　  ：　0円
 * こども（18歳以下6歳より上）  ：　300円
 * 大人（60歳未満18歳より上）　 ：　800円
 * シルバー（60歳以上）         ：　500円
 * 
*/
namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            int cost; // 入場料を格納する変数

            if ()
            {
                cost = 800;
            }
            else if ()
            {
                cost = 500;
            }
            else if ()
            {
                cost = 300;
            }
            else
            {
                cost = 0;
            }

            Console.WriteLine($"年齢{age}歳の入場料は{cost}円です。");


        }
    }
}
