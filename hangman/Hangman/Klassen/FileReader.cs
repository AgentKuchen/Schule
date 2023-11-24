using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.TextFormatting;
using Hangman;

namespace Hangman.Klassen
{
    internal class FileReader
    {
        public static string Read()
        {
            StreamReader sr = new StreamReader(@"../../../textfiles/Wordlist.txt");
            Random random = new Random();
            int row = random.Next(1, 120);
            int cntrow = 0;
            string word = "";
            while (sr.EndOfStream == false)
            {
                if (row == cntrow)
                {
                    word = sr.ReadLine();
                }
                sr.ReadLine();
                cntrow++;
            }

            sr.Close();
            return word.ToLower();
        }

        public static int hightscoreRead()
        {
            int highscore = 0;
            string input = "";
            

            StreamReader sr = new StreamReader(@"../../../textfiles/Scores.txt");

            while (sr.EndOfStream == false)
            {
                input= sr.ReadLine();
                string[] arrgstring = input.Split(',');

                if (highscore < int.Parse(arrgstring[1])) 
                    highscore= int.Parse(arrgstring[1]);
            }

            sr.Close();
            return highscore;

        }
    }
}
