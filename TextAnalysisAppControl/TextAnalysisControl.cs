using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TextAnalysisAppModel;

namespace TextAnalysisAppControl
{
    public class TextAnalysisControl
    {
        private TextAnalysisModel _textAnalysisModel;
        public TextAnalysisControl(List<string> list)
        {
            _textAnalysisModel = new TextAnalysisModel(list);
        }

        public Dictionary<string, int> GetWordOccur()
        {
            return _textAnalysisModel.GetWordOccur();
        }

        public string GetMostCommonWords()
        {
            int occur = _textAnalysisModel.GetMaxOccur();
            string mostCommonWords = "Frequency:" + occur + " times.\n" + String.Join(", ",_textAnalysisModel.GetMostCommonWords());
            return mostCommonWords;
        }

        public string GetLongestWords()
        {
            int length = _textAnalysisModel.GetMaxLength();
            string longestWords = "Longest:" + length + " letters.\n" + String.Join(", ",_textAnalysisModel.GetWordsOfLength(length));
            return longestWords;
        }

        public string GetShortestWords()
        {
            int length = _textAnalysisModel.GetMinLength();
            string shortestWords = "Shortest:" + length + " letters.\n" + String.Join(", ",_textAnalysisModel.GetWordsOfLength(length));
            return shortestWords;
        }

        public string GetAverageLength()
        {
            double average = _textAnalysisModel.GetAverageLength();
            return average.ToString();
        }

        public string GetOccurOfWord(string word)
        {
            string occurOfWord = "";
            occurOfWord = "Number of occurrences: " + _textAnalysisModel.GetOccurOfWord(word);
            return occurOfWord;
        }

        public string GetWordsOfLength(int length)
        {
            string wordsOfLength = String.Join(", ",_textAnalysisModel.GetWordsOfLength(length));
            return wordsOfLength;
        }

        public string GetUniqWords()
        {
            string uniqWords = String.Join(", ", _textAnalysisModel.GetUniqWords());
            return uniqWords;
        }


    }
}
