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
        private static List<RepeatCounter> _searches = new List<RepeatCounter> { };


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

        //Save instance of object to list
        public void Save()
        {
            _searches.Add(this);
        }

        public static List<RepeatCounter> GetAll()
        {
            return _searches;
        }

        public static void ClearAll()
        {
            _searches.Clear();
        }

        //Check if split phrase has instances of target word.
        public int CheckSplitPhrase()
        {
            //SetTargetWord(targetWord);
            //string inputWord = GetTargetWord();
            //SetSplitCompareString(targetPhrase);
            //string[] inputPhrase = GetComparePhrase();
            if (!_comparePhrase.Contains(_targetWord))
            {
                return _result = 0;
            }
            else
            {
                int i = 0;
                foreach (string word in _comparePhrase)
                {
                    if (_targetWord == _comparePhrase[i])
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
        public int RunCounter()
        {
            CheckSplitPhrase();
            return GetResult();
        }
    }
}
