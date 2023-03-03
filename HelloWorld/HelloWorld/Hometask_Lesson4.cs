using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    class Hometask_Lesson4
    {
        public static void Lesson4_Task1()
        {
            string text = "test test test hello 1 2 3 te1st test23 32ejew";

            Regex regex = new Regex(@"\d");
            string target = "";
            text = regex.Replace(text, target);

            text = text.Replace("test", "testing");

            Console.WriteLine(text);
        }

        public static void Lesson4_Task2()
        {
            string t1 = "Welcome";
            string t2 = "to";
            string t3 = "the";
            string t4 = "TMS";
            string t5 = "lessons";
            string t6 = t1 + " " + t2 + " " + t3 + " " + t4 + " " + t5 + ".";

            Console.WriteLine(t6);
        }

        public static void Lesson4_Task3()
        {
            string text = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            text = text.Replace("abc", " ");

            string[] words = text.Split(' ');

            Console.WriteLine(words[0] + "\n" + words[1]);
        }

        public static void Lesson4_Task4()
        {
            string text = "Bad day";
            text = text.Substring(4);

            string word = "Good ";
            string symbol = "!!!!!!!!!";
            text = text.Insert(0, word);
            text = text.Insert(8, symbol);

            int ind = text.Length - 1;
            text = text.Remove(ind);
            text = text.Insert(text.Length, "?");

            Console.WriteLine(text);
        }
    }
}
