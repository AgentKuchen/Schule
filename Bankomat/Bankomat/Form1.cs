using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Bankomat
{
    public partial class Form1 : Form
    {
        List<int> Pin = new List<int>();
        List<int> button = new List<int>();
        int wichcard = 0;
        string[] arrtxt;
       

        //erstellt von Leon Raphael Wagner 2AHIT

        public Form1()
        {

            button.Add(0);
            InitializeComponent();
            bl1.Text = "";
            bl2.Text = "";
            bl3.Text = "";
            bl4.Text = "";
            bl5.Text = "";
            bl6.Text = "";
            error_Katnum.Text = "";
            InputNumpad.Text = "";
            label2.Text = "";


        }


        // Buttons auf der Seite
        private void button1_Click(object sender, EventArgs e)
        {
            int Kontostand= int.Parse(arrtxt[0]);
            
            buttonPress(1);
            button.Add(1);
            Loadform(button);
            //fügt 10 euro hinzu 
            if (button[1] == 1)
            {
                Kontostand += 10;
            }
            //zieht 10 euro ab
            else if (button[1] == 4)
               Kontostand -= 10;
            //Zeigt Kontostand an
            else if (button[1] == 3)
            {
                label2.Text = "Kontostand";
                InputNumpad.Text =arrtxt[2].ToString();
            }

            arrtxt[2] = Kontostand.ToString(); 
               
            button[0] = 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loadform(button);
            buttonPress(2);

            Loadform(button);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonPress(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonPress(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonPress(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonPress(6);
        }
        private void Kartnum_TextChanged(object sender, EventArgs e)
        {
            string katnume= Kartnum.Text;
            IsKatnumCorrect(katnume);
            Loadform(button);
        }

       


        //Die Labels die zu den Buttons dazugehören

        private void bl1_Click(object sender, EventArgs e)
        {
            
        }

        private void bl2_Click(object sender, EventArgs e)
        {

        }

        private void bl3_Click(object sender, EventArgs e)
        {

        }

        private void bl4_Click(object sender, EventArgs e)
        {

        }

        private void bl5_Click(object sender, EventArgs e)
        {

        }
        //Algemein abbrechen
        private void bl6_Click(object sender, EventArgs e)
        {
            button[0] -= 1;
            Loadform(button);
        }
        //Pin wird eingegeben aka NumPad
        private void button13_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 5);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 9);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 0);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            PinLong(Pin, 24);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button[0]-=1;
            Loadform(button);
        }
        private void InputNumpad_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// schauen ob der Pin zu lang ist
        /// </summary>
        /// <param name="pin"></param>
        private void PinLong(List<int> pin, int eingabe)
        {
            label2.Text = "Geben sie ihren Pin an:";
            if (pin.Count != 4)
                pin.Add(eingabe);
            else
                IsPinRight(pin);
            if(eingabe<10)
            InputNumpad.Text += "*";
        }
        /// <summary>
        /// schauen ob der Pin richtig ist
        /// </summary>
        /// <param name="pin"></param>
       
        private void IsPinRight(List<int> pin)
        {
            
           
            string pintxt = arrtxt[1].ToString();
            bool pinright=true;
           
           for(int i = 0; i > pin.Count; i++)
            {
                if(pin[i]!=pintxt[i])
                    pinright=false;
            }
            if (pinright)
            {
                Loadform(button);
                label2.Text = "";
                InputNumpad.Text = "";
            }
            
        }

        /// <summary>
        /// Unterprogramm gibt wert an für labels zum weiterverarbeiten
        /// </summary>
        /// <param name="v">Nummer des Gedrückten Buttons</param>
        private void buttonPress(int v)
        {
            if (button[0] == 0 && v != 2 && v != 5)
                button[0] = v;

        }
        /// <summary>
        /// Schaut nach ob die Karte in der TXT vorhanden ist
        /// </summary>
        /// <param name="katnume"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void IsKatnumCorrect(string katnume)
        {
            bool stringfound=false;
            bool end=false;
            wichcard = 0;
            StreamReader sr = new StreamReader(@"E:\Programieren\github neu\Schule\Schule\Bankomat\Kartendaten.txt");
            while (stringfound == false&&end==false)
            {
                wichcard++;
                string txt = sr.ReadLine();
                arrtxt = txt.Split(';');
                if (arrtxt[0]==katnume)
                    stringfound = true;
                else if(arrtxt[0]=="end")
                    end = true;

               
            }
            
            sr.Close();
            if (end)
                error_Katnum.Text = "Error falsche Kartenummer";
            else if (stringfound)
                error_Katnum.Text = "";
           
                

        }
        /// <summary>
        /// die form wird hier geladen
        /// </summary>
        /// <param name="button"></param>
        private void Loadform(List<int> button)
        {
            int l = button[0];
            if (l == 0)
            {
                bl1.Text = "Einzahlen";
                bl2.Text = "";
                bl3.Text = "Kontostand";
                bl4.Text = "Abheben";
                bl5.Text = "";
                bl6.Text = "Karte Ausgeben";
                InputNumpad.Text = "";
                label2.Text = "";
            }
            else if(l == 1 ||l==4)
            {
                bl1.Text = "10";
                bl2.Text = "20";
                bl3.Text = "50";
                bl4.Text = "100";
                bl5.Text = "eigener Betrag";
                bl6.Text = "Abbrechen";
                InputNumpad.Text = "";
                label2.Text = "";
            }
            else if (l == 3)
            {
                bl1.Text = "";
                bl2.Text = "";
                bl3.Text = "";
                bl4.Text = "";
                bl5.Text = "";
                bl6.Text = "Abbrechen";
                error_Katnum.Text = "";
                InputNumpad.Text = "";
                label2.Text = "Ihr Kontostand beträgt"+arrtxt[2];
            }
            else if (l == 6)
            {
                bl1.Text = "";
                bl2.Text = "";
                bl3.Text = "";
                bl4.Text = "";
                bl5.Text = "";
                bl6.Text = "";
                error_Katnum.Text = "";
                InputNumpad.Text = "";
                label2.Text = "";
                Environment.Exit(0);
            }
                
        }

        
    }
    }
