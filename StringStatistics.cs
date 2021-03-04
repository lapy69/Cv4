using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringStatistics
    {
        public string str;
        public char[] symbolw = new char[] { ' ', '.', ',', ';', '!', '(', ')', '?', '\n' };
        public char[] symbolr = new char[] { '\n' };
        public char[] symbols = new char[] { '.', '!', '?' };
        public string[] WordArray;
        public string[] RowArray;
        public string[] SentenceArray;

        public StringStatistics(string temp)
        {
            str = temp;
            WordArray = str.Split(symbolw, StringSplitOptions.RemoveEmptyEntries);
            RowArray = str.Split(symbolr);
            SentenceArray = str.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
        }

       

        public int Wordn()
        {
            return WordArray.Length;
        }

        public int Rown()
        {
            return RowArray.Length;
        }

        public int Sentencen()
        {
            int i = 0;
            string UpperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (string sentence in SentenceArray)
            {
                if (UpperLetters.Contains(sentence[0]) || UpperLetters.Contains(sentence[1]))
                {
                    i++;
                }
            }

            return i;
        }

        public string Longest()
        {
            int lenght = 0;
            string final = "";

            foreach (string word in WordArray)
            {
                if (lenght < word.Length)
                {
                    lenght = word.Length;
                }
            }

            foreach (string word in WordArray)
            {
                if (lenght == word.Length)
                {
                    final = final + word + " ";
                }
            }

            return final;

        }

        public string Shortest()
        {
            int lenght = Int32.MaxValue;
            string final = "";

            foreach (string word in WordArray)
            {
                if (lenght > word.Length)
                {
                    lenght = word.Length;
                }
            }

            foreach (string word in WordArray)
            {
                if (lenght == word.Length)
                {
                    final = final + word + " ";
                }
            }

            return final;
        }

        public string Sortw()
        {
            Array.Sort(WordArray);
            string final = "";

            foreach (string word in WordArray)
            {
                final = final + word + " ";
            }

            return final;
        }

        public string Most()
        {
            Array.Sort(WordArray);
            int temp = 1;
            int current = 1;

            string final = "";

            for (int i = 1; i < WordArray.Length-1; i++)
            {
                
                if(WordArray[i-1]==WordArray[i])
                {
                    temp++;
                    if(temp>current)
                    {
                        current = temp;
                        final = WordArray[i];
                    }
                }
                else
                {
                    temp = 1;
                }
            }

            return final;
        }

        public bool IsInfected()
        {
            string covid1 = "covid";
            string covid2 = "covid-19";
            string covid3 = "sars-cov-2";
            string strlower = str.ToLower();

            if (strlower.Contains(covid1) || strlower.Contains(covid2) || strlower.Contains(covid3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
