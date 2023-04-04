using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks.Hometask_Lesson12
{
    internal class Lesson12_Task1
    {
        static List<string> words = new List<string> { "hello", "all", "a", "people", "33", "beer", "beer", "c", "cheese", "check 3", "3", "33" };

        static Dictionary<int, string> numbers = new Dictionary<int, string>()
            {
                {1, "One" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" },
                {5, "Five" },
                {6, "Six" },
                {7, "Seven" },
                {8, "Eight" },
                {9, "Nine" },
                {10, "Ten" }
            };

        public static void FindFirstWordWithOneLetter()
        {
            var checkFirstWordWithOneLetter = words.FirstOrDefault(w => w.Length == 1);
            Console.WriteLine(checkFirstWordWithOneLetter);
        }

        public static void FindLastWordWithEE()
        {
            var checkLastWordWithEE = words.LastOrDefault(w => w.Contains("ee"));
            Console.WriteLine(checkLastWordWithEE);
        }

        public static void FindLastWordWithCondition()
        {
            var sort = words.OrderBy(w => w.Length);
            var min = sort.FirstOrDefault();
            var max = sort.LastOrDefault();
            var checkLastWordWithCondition  = sort.LastOrDefault(w => w.Length > min.Length && w.Length < max.Length);
            Console.WriteLine(checkLastWordWithCondition);
        }

        public static void FindUniqueValues()
        {
            var uniqValues = words.Distinct();
            var countValues = uniqValues.Count();
            Console.WriteLine(countValues);
        }

        public static void FindFromFifth()
        {
            var checkFromFifth = from w in words.Skip(4)
                                 where w.Contains("3")
                                 select w;

            foreach(var element in checkFromFifth)
            {
                Console.WriteLine(element);
            }
        }

        public static void FindShortestLenght()
        {
            var sort = words.OrderBy(w => w.Length);
            var min = sort.FirstOrDefault();
            Console.WriteLine(min.Length);
        }

        public static void DictionaryToList()
        {
            List<int> listKeys = numbers.Keys.ToList();
            List<string> listValues = numbers.Values.ToList();

            var newList = listValues.Zip(listKeys);

            foreach (var element in newList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
