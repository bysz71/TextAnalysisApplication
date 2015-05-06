using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using TextAnalysisAppModel;

namespace TextAnalysisAppUnitTest
{
    [TestClass]
    public class UnitTestModel
    {
        [TestMethod]
        public void TestGetWordOccur(){
            var list = new List<string>(){"aaa","bbb","aaa","ccc","a","asdfasd"};
            var wordOccur = TextAnalysisModel.GetWordOccur(list);
            PrintWordOccur(wordOccur);
        }
        public void PrintWordOccur(Dictionary<string, int> wordOccur)
        {
            foreach (KeyValuePair<string, int> kvp in wordOccur)
                Console.WriteLine("word = {0}, occur = {1}\n", kvp.Key, kvp.Value);
        }

        [TestMethod]
        public void TestGetLengthWord(){
            var list = new List<string>() { "aaa", "bbb", "aaa", "ccc", "a", "asdfasd" };
            var lengthWords = TextAnalysisModel.GetLengthWords(list);
            PrintLengthWords(lengthWords);
        }
        public void PrintLengthWords(Dictionary<int,SortedSet<string>> lengthWords)
        {
            foreach (KeyValuePair<int, SortedSet<string>> kvp in lengthWords)
            {
                Console.WriteLine("length = {0}, words = ", kvp.Key);
                foreach (string word in kvp.Value)
                {
                    Console.Write("-{0}-", word);
                }
                Console.Write("\n");
            }
        }

        [TestMethod]
        public void TestGetMaxOccur()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "a", "asdfasd" };
            var tam = new TextAnalysisModel(list);
            Assert.AreEqual(2, tam.GetMaxOccur());
        }

        [TestMethod]
        public void TestGetMostCommonWords()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "a", "asdfasd" };
            var tam = new TextAnalysisModel(list);
            var mostCommonWords = tam.GetMostCommonWords();
            foreach (string word in mostCommonWords)
                Console.WriteLine("{0}, ",word);
        }

        [TestMethod]
        public void TestGetMaxLength()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "a", "asdfasd" };
            var tam = new TextAnalysisModel(list);
            Assert.AreEqual(7, tam.GetMaxLength());
        }

        [TestMethod]
        public void TestGetMinLength()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "a", "asdfasd" };
            var tam = new TextAnalysisModel(list);
            Assert.AreEqual(1, tam.GetMinLength());
        }

        [TestMethod]
        public void TestGetWordsOfLength()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "a", "asdfasd" };
            var tam = new TextAnalysisModel(list);
            int length = tam.GetMaxLength();
            var longestWords = tam.GetWordsOfLength(length);
            foreach (string word in longestWords)
                Console.WriteLine("{0}, ",word);
            var words = tam.GetWordsOfLength(4);
            foreach (string word in words)
                Console.WriteLine("{0}, ", word);
        }

        [TestMethod]
        public void TestGetOccurOfWord()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "a", "asdfasd" };
            var tam = new TextAnalysisModel(list);
            int occur1 = tam.GetOccurOfWord("bbb");
            int occur2 = tam.GetOccurOfWord("ccc");
            Console.WriteLine("bbb: {0} ; ccc: {1} ", occur1, occur2);
        }

        [TestMethod]
        public void TestGetAverageLength()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "a", "asdfasd" };
            var tam = new TextAnalysisModel(list);
            double averageLength = tam.GetAverageLength();
            double aver = 20.0 / 6;
            Assert.AreEqual(aver, averageLength);
        }

        [TestMethod]
        public void TestGetUniqWords()
        {
            var list = new List<string>() { "aaa", "bbb", "aaa", "bbb", "a", "asdfasd" };
            var tam = new TextAnalysisModel(list);
            string uniqWords = String.Join(", ",tam.GetUniqWords());
            Console.WriteLine(uniqWords);
        }
    }
}
