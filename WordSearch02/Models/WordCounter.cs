using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSearch02.Models
{
    public class RepeatCounter
    {
        private int _result;
        private string _targetWord;
        private string[] _comparePhrase;
        private static List<RepeatCounter> _searchedWords = new List<RepeatCounter> { };

        //Create Default and Overloaded Constructors.
        public RepeatCounter()
        {

        }

        public RepeatCounter(string targetWord = "")
        {
            _targetWord = targetWord;
        }

        public RepeatCounter(string targetWord = "", string phrase = "")
        {
            _targetWord = targetWord;
            _comparePhrase = phrase.ToLower().Split(' ');
        }


        // Set & Get Target Word.
        public void SetTargetWord(string newTargetWord)
        {
            _targetWord = newTargetWord.ToLower();
        }
        public string GetTargetWord()
        {
            return _targetWord;
        }

        //Set and Get Phrase to compare with target word.
        public void SetSplitCompareString(string newComparePhrase)
        {
            char[] splitChars = { ' ', '.', ',', '!', '?', '-', '_', '#', '@', ':', ';', '(', ')', '*', '<', '>' };
            _comparePhrase = newComparePhrase.ToLower().Split(splitChars);
        }

        public string[] GetComparePhrase()
        {
            return _comparePhrase;
        }

        public void SaveWord(string word)
        {
            _searchedWords.Add(this);
        }

        public static List<RepeatCounter> GetAll()
        {
            return _searchedWords;
        }

        public static void ClearAll()
        {
            _searchedWords.Clear();
        }


        //Check if split phrase has instances of target word.
        public int CheckSplitPhrase(string targetWord, string targetPhrase)
        {
            SetTargetWord(targetWord);
            string inputWord = GetTargetWord();
            SetSplitCompareString(targetPhrase);
            string[] inputPhrase = GetComparePhrase();
            if (!inputPhrase.Contains(inputWord))
            {
                return _result = 0;
            }
            else
            {
                int i = 0;
                foreach (string word in inputPhrase)
                {
                    if (inputWord == inputPhrase[i])
                    {
                        _result += 1;
                    }
                    i++;
                }
                return _result;
            }
        }

        //Return Result of comparison
        public int GetResult()
        {
            return _result;
        }

        //Run Repeat Counter
        public int RunCounter(string word, string phrase)
        {
            CheckSplitPhrase(word, phrase);
            return GetResult();
        }
    }
}
