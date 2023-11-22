using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Klassen
{
    public class FileWriter
    {

        public static void Write(string name, int score)
        {
            string filename = @"";
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine($"{name},{score}");
                
            }
            
        }
    }
}
