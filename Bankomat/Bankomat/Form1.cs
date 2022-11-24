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

namespace Bankomat
{
    public partial class Form1 : Form
    {
        List<int> Pin = new List<int>();
        List<int> button = new List<int>();
        StreamReader sr = new StreamReader(@"E:\Programieren\github neu\Schule\Schule\Bankomat\Kartendaten.txt");


        public Form1()
        {



            button.Add(0);
            InitializeComponent();

            bl1.Text = "Einzahlen";
            bl2.Text = "";
            bl3.Text = "Kontostand";
            bl4.Text = "Abheben";
            bl6.Text = "Karte Ausgeben";

        }



        private void button1_Click(object sender, EventArgs e)
        {
            buttonPress(1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonPress(2);

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

        private void bl6_Click(object sender, EventArgs e)
        {

        }
        //Pin wird eingegeben
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

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// schauen ob der Pin zu lang ist
        /// </summary>
        /// <param name="pin"></param>
        private void PinLong(List<int> pin, int eingabe)
        {
            if (pin.Count != 4)
                pin.Add(eingabe);
            else
                IsPinRight(pin);
        }
        /// <summary>
        /// schauen ob der Pin richtig ist
        /// </summary>
        /// <param name="pin"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void IsPinRight(List<int> pin)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unterprogramm gibt wert an für labesl zum weiterverarbeiten
        /// </summary>
        /// <param name="v">Nummer des Gedrückten Buttons</param>
        private void buttonPress(int v)
        {
            if (button[0] == 0 && v != 2 && v != 5)
                button[0] = v;

        }

        
    }
    }
