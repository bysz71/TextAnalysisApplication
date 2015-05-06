using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysisAppModel
{
    public class TextAnalysisModel
    {
        private List<string> _rawData;
        private Dictionary<string, int> _wordOccur;
        private Dictionary<int, SortedSet<string>> _lengthWords;

        public TextAnalysisModel(List<string> rawData)
        {
            _rawData = new List<string>(rawData);
            _wordOccur = GetWordOccur(_rawData);
            _lengthWords = GetLengthWords(_rawData);

        }

        public Dictionary<string, int> GetWordOccur()
        {
            return _wordOccur;
        }

        public static Dictionary<string, int> GetWordOccur(List<string> list)
        {
            Dictionary<string, int> wordOccur = new Dictionary<string, int>();
            for (int i = 0; i < list.Count(); i++)
            {
                if (!wordOccur.ContainsKey(list.ElementAt(i)))
                    wordOccur.Add(list.ElementAt(i), 1);
                else
                    wordOccur[list.ElementAt(i)]++;
            }
            return wordOccur;
        }

        public static Dictionary<int, SortedSet<string>> GetLengthWords(List<string> list)
        {
            Dictionary<int, SortedSet<string>> lengthWords = new Dictionary<int, SortedSet<string>>();
            foreach (string word in list.Where(word => word != ""))
            {
                if (lengthWords.ContainsKey(word.Length))
                    lengthWords[word.Length].Add(word);
                else
                    lengthWords[word.Length] = new SortedSet<string> { word };
            }
            return lengthWords;
        }


        public int GetMaxOccur()
        {
            int maxOccur = _wordOccur.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
            return maxOccur;
        }

        public SortedSet<string> GetMostCommonWords()
        {
            var mostCommonWords = new SortedSet<string>();
            int maxOccur = GetMaxOccur();
            foreach (KeyValuePair<string, int> kvp in _wordOccur)
                if (kvp.Value == maxOccur)
                    mostCommonWords.Add(kvp.Key);
            return mostCommonWords;
        }

        public int GetMaxLength()
        {
            int maxLength = _lengthWords.Keys.Max();
            return maxLength;
        }

        public int GetMinLength()
        {
            int minLength = _lengthWords.Keys.Min();
            return minLength;
        }

        public SortedSet<string> GetWordsOfLength(int length)
        {
            var wordsOfLength = new SortedSet<string>();
            try
            {
                wordsOfLength = _lengthWords[length];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return wordsOfLength;
        }

        public int GetOccurOfWord(string word)
        {
            int occurOfWord = 0;
            try
            {
                occurOfWord = _wordOccur[word];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return occurOfWord;
        }

        public double GetAverageLength()
        {
            double sum = 0;
            double average = 0;
            foreach (string word in _rawData)
            {
                sum += word.Length;
            }
            average = sum / _rawData.Count;
            average = Math.Round(average, 2);
            return average;
        }

        public SortedSet<string> GetUniqWords()
        {
            var uniqWords = new SortedSet<string>();
            foreach (string word in _rawData)
                uniqWords.Add(word);
            return uniqWords;
        }


    }
}
