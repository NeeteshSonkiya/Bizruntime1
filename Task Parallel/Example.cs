using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.IO;

namespace TaskParallel
{
    class Example
    {
        static void Main(string[] args)
        {
            String[] words = CreateWordArray(@"http://www.gutenberg.org/files/2009/2009.txt");
           
            #region ParallelTasks
            Parallel.Invoke(() =>
            {
                Console.WriteLine("Begin first Task....");
                GetLongestWord(words);
            },
            ()=>
            {
                Console.WriteLine("Begin Second task....");
                GetMostCommonWords(words);
            },
            ()=>
            {
                Console.WriteLine("Begin Third task....");
                GetCountForword(words, "species");
            }
            );
            Console.WriteLine("Returned from Parallel.Invoke");
            #endregion
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        #region HelperMethods
        private static void GetCountForword(string[] words, string term)
        {
            var findWord = from word in words
                           where word.ToUpper().Contains(term.ToUpper())
                           select word;
            Console.WriteLine(@"Task 3 -- The word ""{0}"" occurs {1} times." , term, findWord.Count());
        }
        private static void GetMostCommonWords(string [] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;
            var commonWords = frequencyOrder.Take(10);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 2 -- The most common words are : ");
            foreach (var v in commonWords)
            {
                sb.AppendLine(" " + v);
            }
            Console.WriteLine(sb.ToString());
        }
        private static string GetLongestWord(string[] words)
        {
            var longestWord = (from w in words
                               orderby w.Length descending
                               select w).First();
            Console.WriteLine("Task 1 -- The longest word is {0}", longestWord);
            return longestWord;
        }
        static string[] CreateWordArray(string uri)
        {
            Console.WriteLine("Retriving from {0}", uri);
            string s = new WebClient().DownloadString(uri);
            return s.Split(
                            new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' },
                            StringSplitOptions.RemoveEmptyEntries);
        }
        #endregion
    }
}
