using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using TextAnalysisAppControl;
namespace TextAnalysisAppUnitTest
{
    [TestClass]
    public class UnitTestControl
    {
        [TestMethod]
        public void TestGetMostCommonWords()
        {
            var list = new List<string>(){"aaa","bbb","aaa","bbb","aaa","cc","1234","7777777"};
            var textAnalysisControl = new TextAnalysisControl(list);
            string mostCommonWords = textAnalysisControl.GetMostCommonWords();
            Console.Write(mostCommonWords);
        }

        [TestMethod]
        public void TestGetLongestWords()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "aaa", "cc", "1234", "7777777" };
            var textAnalysisControl = new TextAnalysisControl(list);
            string longestWords = textAnalysisControl.GetLongestWords();
            Console.Write(longestWords);
        }

        [TestMethod]
        public void TestGetShortestWords()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "aaa", "cc", "1234", "7777777" };
            var textAnalysisControl = new TextAnalysisControl(list);
            string shortestWords = textAnalysisControl.GetShortestWords();
            Console.Write(shortestWords);
        }

        [TestMethod]
        public void TestGetAverageLength()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "aaa", "cc", "1234", "7777777" };
            var textAnalysisControl = new TextAnalysisControl(list);
            string average = textAnalysisControl.GetAverageLength();
            Assert.AreEqual(28.0 / 8, Convert.ToDouble(average));
        }

        [TestMethod]
        public void TestGetOccurOfWord()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "aaa", "cc", "1234", "7777777" };
            var textAnalysisControl = new TextAnalysisControl(list);
            string occurOfWord = textAnalysisControl.GetOccurOfWord("aaa");
            string occurOfWord2 = textAnalysisControl.GetOccurOfWord("111");
            Console.WriteLine(occurOfWord);
            Console.WriteLine(occurOfWord2);
        }

        [TestMethod]
        public void TestGetWordsOfLength()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "aaa", "cc", "1234", "7777777" };
            var textAnalysisControl = new TextAnalysisControl(list);
            string wordsOfLength = textAnalysisControl.GetWordsOfLength(3);
            string wordsOfLength2 = textAnalysisControl.GetWordsOfLength(5);
            Console.WriteLine(wordsOfLength);
            Console.WriteLine(wordsOfLength2);
        }

        [TestMethod]
        public void TestGetUniqWords()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "aaa", "cc", "1234", "7777777" };
            var textAnalysisControl = new TextAnalysisControl(list);
            string uniqWords = textAnalysisControl.GetUniqWords();
            Console.WriteLine(uniqWords);
        }

        [TestMethod]
        public void TestIsNum()
        {
            int n;
            bool isNum = int.TryParse("123", out n);
            Console.WriteLine("123 is {0}", isNum);
            isNum = int.TryParse("abc", out n);
            Console.WriteLine("abc is {0}", isNum);
            isNum = int.TryParse("12A", out n);
            Console.WriteLine("12A is {0}", isNum);
        }
    }

}
