using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hangman.Klassen;

namespace Hangman
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string word = "";
        public string hiddenword = "";
        public int mistakes = 1;
        public int score = 0;

        public MainWindow()
        {
            InitializeComponent();
            InitializeWord();
            
        }


        private void InitializeWord()
        {
            word = FileReader.Read();
           
            for (int i = 0; i < word.Length; i++)
                hiddenword += "_";

            UpdateText();

        }
        
        private void UpdateText()
        {
            text.Text = "";
            for(int i = 0; i < hiddenword.Length; i++)
                text.Text += hiddenword[i]+" ";

            scoretxt.Text=score.ToString();
        }


        private void ChooseLetter(object sender, string letter)
        {
            if (word.Contains(letter))
                Replaceletter(letter);
            else
            {
                mistakes++;
                ChangePicture(mistakes);
            }
               

            if (sender is Button clickedButton)
            {
               
                clickedButton.Visibility = Visibility.Collapsed;
            }

            UpdateText();
            if (mistakes == 6)
                Gameover();
        }


        //funkt nicht
        private void ChangePicture(int mistakes)
        {
            image.Source = new BitmapImage(new Uri($"../../../frames/pixil-frame-{mistakes}.png",UriKind.Relative));
        }

       
        //Buchstabe erstetzen 
        private void Replaceletter(string letter)
        {
            string newHiddenword = "";
            for (int i = 0; i < hiddenword.Length; i++)
            {
                
                if (letter == word[i].ToString())
                    newHiddenword+=(char.Parse(letter));
                else if(hiddenword[i]=='_')
                    newHiddenword+=('_');
                else
                    newHiddenword += hiddenword[i];

               
            }
            hiddenword = newHiddenword;
            //erkennen ob spiel gewonnen ist
            if (!hiddenword.Contains("_"))
                Restart();
                
                
        }

        private void allbvisible()
        {
            a.Visibility = Visibility.Visible;
            b.Visibility = Visibility.Visible;
            c.Visibility = Visibility.Visible;
            d.Visibility = Visibility.Visible;
            e.Visibility = Visibility.Visible;
            f.Visibility = Visibility.Visible;
            g.Visibility = Visibility.Visible;
            h.Visibility = Visibility.Visible;
            i.Visibility = Visibility.Visible;
            j.Visibility = Visibility.Visible;
            k.Visibility = Visibility.Visible;
            l.Visibility = Visibility.Visible;
            m.Visibility = Visibility.Visible;
            n.Visibility = Visibility.Visible;
            o.Visibility = Visibility.Visible;
            p.Visibility = Visibility.Visible;
            q.Visibility = Visibility.Visible;
            r.Visibility = Visibility.Visible;
            s.Visibility = Visibility.Visible;
            t.Visibility = Visibility.Visible;
            u.Visibility = Visibility.Visible;
            v.Visibility = Visibility.Visible;
            w.Visibility = Visibility.Visible;
            x.Visibility = Visibility.Visible;
            y.Visibility = Visibility.Visible;
            z.Visibility = Visibility.Visible;
        }

        private void Gameover()
        {
            alllements.Visibility = Visibility.Collapsed;
            allgameover.Visibility = Visibility.Visible;
        }
        private void Restart()
        {
            score++;
            mistakes = 1;
            word = "";
            hiddenword = "";
            InitializeWord();
            ChangePicture(mistakes);
            allbvisible();
        }
        #region Buchstaben buttons

        private void a_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "a");
        }
        
         
        private void b_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender,"b");
        }
        
        private void c_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "c");
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "d");
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "e");
        }

        private void f_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "f");
        }

        private void g_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "g");
        }

        private void h_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "h");
        }

        private void i_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "i");
        }

        private void j_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "j");
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "k");
        }

        private void l_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "l");
        }

        private void m_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "m");
        }

        private void n_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "n");
        }

        private void o_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "o");
        }

        private void p_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "p");
        }

        private void q_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "q");
        }

        private void r_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "r");
        }

        private void s_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "s");
        }

        private void t_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "t");
        }

        private void u_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "u");
        }

        private void v_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "v");
        }

        private void w_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "w");
        }

        private void x_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "x");
        }

        private void y_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "y");
        }

        private void z_Click(object sender, RoutedEventArgs e)
        {
            ChooseLetter(sender, "z");
        }


        #endregion

        private void restart_Click(object sender, RoutedEventArgs e)
        {
            Restart();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
