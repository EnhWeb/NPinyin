using System;
using System.Collections.Generic;
using System.Text;

namespace NPinyin
{
    class Startup
    {
        [STAThread]
        public static void Main(string[] args)
        {
            string str;

            Console.WriteLine("--------------------  PinYin Test  --------------------");
            Console.WriteLine("说明：请输入要翻译的中文，示例如下。");
            Console.Write("->> ");
            Console.WriteLine(str = "中文翻译测试一下，效果如何？");
                Console.WriteLine($"    {Pinyin.GetInitials(str)} | {Pinyin.GetPinyin(str)}");
            Console.WriteLine();

        readline:
            Console.Write("->> ");
            str = Console.ReadLine();

            if (str.ToLower() != "exit")
            {
                Console.WriteLine($"    {Pinyin.GetInitials(str)} | {Pinyin.GetPinyin(str)}");
                Console.WriteLine();
                goto readline;
            }
        }

    }
}