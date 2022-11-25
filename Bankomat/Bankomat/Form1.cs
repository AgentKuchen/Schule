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
        List<string> txtall = new List<string>();
        int wichcard = 0;
        string[] arrtxt;
        char rechenzeichen;
        string zeichenkette = "";


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
            int Kontostand= int.Parse(arrtxt[2]);
            //Geht ins Hinzufüg Menü rein
            if (button[0] == 0)
            {
                buttonPress(1);
                Loadform(button);
               
            }
            else if (button[0] != 0)
            {
                //zieht Geld ab
            if (button[0] == 4)
                {
                    Loadform(button);
                    Kontostand -= 10;

                }
                //fügt Geld hinzu 
                else if (button[0] == 1)
                {
                    Kontostand += 10;
                }

                arrtxt[2] = Kontostand.ToString();
                KontostandSpeichern();
            }
            
            
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int Kontostand = int.Parse(arrtxt[2]);
            //fügt Geld hinzu 
            if (button[0] == 1)
            {
                Loadform(button);
                Kontostand += 20;
                

            }
            //zieht Geld ab
            else if (button[0] == 4)
            {
                Loadform(button);
                Kontostand -= 20;
            }


            arrtxt[2] = Kontostand.ToString();
            KontostandSpeichern();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Kontostand = int.Parse(arrtxt[2]);
             if (button[0] == 0)
            {
                button[0] = 3;
                Loadform(button);
            }
             else if (button[0] != 0){
                //fügt Geld hinzu 
                if (button[0] == 1)
                {
                    Loadform(button);
                    Kontostand += 50;

                }

                //zieht Geld ab
                else if (button[0] == 4)
                {
                    Loadform(button);
                    Kontostand -= 50;
                }

                arrtxt[2] = Kontostand.ToString();
                KontostandSpeichern();
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Kontostand = int.Parse(arrtxt[2]);
            //fügt Geld hinzu 
            if (button[0] == 1)
            {
                Loadform(button);
                Kontostand += 100;

            }
            //Geht ins Abheb Menü rein
            else if (button[0] == 0 )
            {
                buttonPress(4);
                Loadform(button);
                
            }
            //zieht Geld ab
            else if (button[0] == 4)
                Kontostand -= 100;

            arrtxt[2] = Kontostand.ToString();
            KontostandSpeichern();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            int Kontostand = int.Parse(arrtxt[2]);
            //fügt Geld hinzu 
            if (button[0] == 1)
            {
                button[0] = 5;
                Loadform(button);
                rechenzeichen = '+';
                

            }
            //zieht Geld ab
            else if (button[0] == 4)
            {
                button[0] = 5;
                Loadform(button);
                rechenzeichen = '-';
            }



            arrtxt[2] = Kontostand.ToString();
            KontostandSpeichern();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button[0] == 0)
            {
                button[0] = 6;
                Loadform(button);

            }
            button[0] = 0;
            Loadform(button);
            
        }
        private void Kartnum_TextChanged(object sender, EventArgs e)
        {
            
            string katnume= Kartnum.Text;
            IsKatnumCorrect(katnume);
            
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
           
        }
        //Pin wird eingegeben aka NumPad
        private void button13_Click(object sender, EventArgs e)
        {
           if(button[0]!=0)
            {
                SetCustomMoney(1,rechenzeichen);
            }
           else
            PinLong(Pin, 1);

        }

        

        private void button14_Click(object sender, EventArgs e)
        {
            if (button[0] != 0)
            {
                SetCustomMoney(2, rechenzeichen);
            }
            else
                PinLong(Pin, 2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button[0] != 0)
            {
                SetCustomMoney(3, rechenzeichen);
            }
            else
                PinLong(Pin, 3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button[0] != 0)
            {
                SetCustomMoney(4, rechenzeichen);
            }
            else
                PinLong(Pin, 4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button[0] != 0)
            {
                SetCustomMoney(5, rechenzeichen);
            }
            else
                PinLong(Pin, 5);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button[0] != 0)
            {
                SetCustomMoney(6, rechenzeichen);
            }
            else
                PinLong(Pin, 6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button[0] != 0)
            {
                SetCustomMoney(7, rechenzeichen);
            }
            else
                PinLong(Pin, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button[0] != 0)
            {
                SetCustomMoney(8, rechenzeichen);
            }
            else
                PinLong(Pin, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button[0] != 0)
            {
                SetCustomMoney(9, rechenzeichen);
            }
            else
                PinLong(Pin, 9);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button[0] != 0)
            {
                SetCustomMoney(0, rechenzeichen);
            }
            else
                PinLong(Pin, 0);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (button[0] != 0)
            {
                SetCustomMoney(24, rechenzeichen);
            }
            else
                PinLong(Pin, 24);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button[0]=0;
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
            string fullPin = "";
            foreach (int item in pin)
            {
                fullPin += item;
            }
            string pintxt = arrtxt[1].ToString();
            bool pinright=false;
           
           for(int i = 0; i < pin.Count; i++)
            {
                if(fullPin.Trim() == pintxt.Trim())
                    pinright=true;
            }
            if (pinright)
            {
                Loadform(button);
                label2.Text = "";
                InputNumpad.Text = "";
            }
            else if(pinright==false)
            {
                Pin.Clear();
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
            StreamReader sr = new StreamReader(@"F:\Bankomat\Kartendaten.txt");
            
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
        /// Kontostand wird hier ins file abgespeichert
        /// </summary>
        private void KontostandSpeichern()
        {
            // file wird in liste gespeichert
            StreamReader sr = new StreamReader(@"F:\Bankomat\Kartendaten.txt");
            while (sr.EndOfStream==false)
                txtall.Add(sr.ReadLine());
            sr.Close();
            string[] splittext = txtall[wichcard-1].Split(';');
            string output = "";
            for (int i = 0; i < txtall.Count(); i++)
            {
                //wenn true wird Kontostand geupdatet
                if (wichcard-1 == i)
                {
                    splittext[2] = arrtxt[2];
                   
                  
                     output = splittext[0]+";"+ splittext[1] + ";"+ splittext[2];

                    txtall[i] = output;

                }
            }
            
            StreamWriter sw = new StreamWriter(@"F:\Bankomat\Kartendaten.txt");
            for(int i=0;i<txtall.Count;i++)
                sw.WriteLine(txtall[i]);
            sw.Close();
            
            txtall.Clear();
        }
        /// <summary>
        /// Unterprogramm zum Festlegen vom Custom money
        /// </summary>
        /// <param name="v"></param>
        private void SetCustomMoney(int v, char rechenzeichen)
        {
           
            if (v < 10)
            {
                InputNumpad.Text += v.ToString();
                zeichenkette += v.ToString();
            }
            else
            {
                int Kontostand = int.Parse(arrtxt[2]);
                //Geht ins Hinzufüg Menü rein
                
               
                    //zieht Geld ab
                    if (rechenzeichen == '-')
                    {
                       
                    Kontostand -= int.Parse(zeichenkette);

                    }
                    //fügt Geld hinzu 
                    else if (rechenzeichen=='+')
                    {
                        Kontostand += int.Parse(zeichenkette);
                    }

                    arrtxt[2] = Kontostand.ToString();
                    KontostandSpeichern();

                Loadform(button);
                zeichenkette = "";
            }
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
                InputNumpad.Text = arrtxt[2].ToString();
                label2.Text = "Ihr Kontostand beträgt:";
            }
            else if (l == 5)
            {
                bl1.Text = "";
                bl2.Text = "";
                bl3.Text = "";
                bl4.Text = "";
                bl5.Text = "";
                bl6.Text = "Abbrechen";
                error_Katnum.Text = "";
                InputNumpad.Text = "";
                label2.Text = "Geben sie den Geldbetrag an:";
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
