using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Klassen
{
    internal class FileReader
    {
       public static string Read()
        {
            StreamReader sr = new StreamReader(@"F:\Bankomat\Kartendaten.txt");
            while (sr.EndOfStream == false)
                txtall.Add(sr.ReadLine());
            sr.Close();
        }
           
        
               
          
    }
}
