﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noppapeli
{
    // Luo luokka "Noppa", jossa on tallessa nopan arvo 1-6
    // nopalla on myös "Heitto"-metodi, joka arpoo sille arvon 1-6
    // Anna nopalle myös constructor-metodi, joka heti alussa arpoo arvon

    // Lähde tekemään Yatzi-peli

    public partial class Form1 : Form
    {
        private Random rng = new Random();
        List<Noppa> noppas = new List<Noppa>();



        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                PictureBox tempPB = new PictureBox();
                this.Controls.Add(tempPB);
                Noppa tempNoppa = new Noppa(6, tempPB);
                noppas.Add(tempNoppa);
                Summa.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < noppas.Count; i++)
            {
                noppas[i].Heitto(rng);
                AddPictureBox(noppas[i], i);
            }
            // lisää nopalle property "Koko", jolla määritellään
            // montako silmälukua nopalla on
            // ja käytetään sitä luvun arvonnassa
            // nopan koko annetaan sitä generoidessa
        }
        private void AddPictureBox(Noppa noppa, int count)
        {
            const int spacing = 70;
            //PictureBox tempPB = new PictureBox();
            string key = noppa.GetDiceId();
            noppa.Boxi.Image = Noppa.GetPictureResourceX(key);
            noppa.Boxi.Location = new Point(250 + (count - 1) * spacing, 14);
            // noppa.Boxi.Size = new Size(100, 200);
            //noppa.Boxi.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Ykkoset_Click(object sender, EventArgs e)
        {
            int Lopputulos = 0;
            int Lukumme = 1;

            for (int i = 0; i < noppas.Count; i++)
            {
                if (noppas[i].Luku == Lukumme)
                {

                    Lopputulos += 1;

                }
            }


            Ykkoset.Text = $"{Lopputulos}";
            int tnum = 0;
            tnum = int.Parse(Summa.Text);
            Summa.Text = $"{Lopputulos + tnum}";
        }

        private void Kakkoset_Click(object sender, EventArgs e)
        {
            int Lopputulos = 0;
            int Lukumme = 2;

            for (int i = 0; i < noppas.Count; i++)
            {
                if (noppas[i].Luku == Lukumme)
                {

                    Lopputulos++;

                }
            }

            Kakkoset.Text = $"{Lopputulos}";
            int tnum = 0;
            tnum = int.Parse(Summa.Text);
            Summa.Text = $"{Lopputulos + tnum}";
        }

        private void Kolmoset_Click(object sender, EventArgs e)
        {
            {
                int Lopputulos = 0;
                int Lukumme = 3;

                for (int i = 0; i < noppas.Count; i++)
                {
                    if (noppas[i].Luku == Lukumme)
                    {

                        Lopputulos++;

                    }
                }
                Kolmoset.Text = $"{Lopputulos}";
                int tnum = 0;
                tnum = int.Parse(Summa.Text);
                Summa.Text = $"{Lopputulos + tnum}";
            }
        }

        private void Neloset_Click(object sender, EventArgs e)
        {
            {
                int Lopputulos = 0;
                int Lukumme = 4;

                for (int i = 0; i < noppas.Count; i++)
                {
                    if (noppas[i].Luku == Lukumme)
                    {

                        Lopputulos++;

                    }
                }
                Neloset.Text = $"{Lopputulos}";
                int tnum = 0;
                tnum = int.Parse(Summa.Text);
                Summa.Text = $"{Lopputulos + tnum}";
            }
        }

        private void Vitoset_Click(object sender, EventArgs e)
        {
            {
                int Lopputulos = 0;
                int Lukumme = 5;

                for (int i = 0; i < noppas.Count; i++)
                {
                    if (noppas[i].Luku == Lukumme)
                    {

                        Lopputulos++;

                    }
                }
                Vitoset.Text = $"{Lopputulos}";
                int tnum = 0;
                tnum = int.Parse(Summa.Text);
                Summa.Text = $"{Lopputulos + tnum}";

            }
        }

        private void Kutoset_Click(object sender, EventArgs e)
        {
            {
                int Lopputulos = 0;
                int Lukumme = 6;

                for (int i = 0; i < noppas.Count; i++)
                {
                    if (noppas[i].Luku == Lukumme)
                    {

                        Lopputulos++;

                    }
                }
                Kutoset.Text = $"{Lopputulos}";
                int tnum = 0;
                tnum = int.Parse(Summa.Text);
                Summa.Text = $"{Lopputulos + tnum}";
                Kutoset.Enabled = false;
            }
        }

        private void Pari_Click(object sender, EventArgs e)
        {

            int[] pairs = new int[6];
            int[] pairValues = new int[6];
            const int multiplier = 2;
            for (int i = 0; i < pairs.Length; i++)
            {
                pairs[i] = noppas.Where(test => test.Luku == i + 1).Count();
            }
            for (int i = 0; i < pairs.Length; i++)
            {
                if (pairs[i] > 1)
                {
                    pairValues[i] = (i + 1) * multiplier;
                }
            }
            int väli = pairValues.Max();
            Pari.Text = väli.ToString();

            int tnum = 0;
            tnum = int.Parse(Summa.Text);
            Summa.Text = $"{väli + tnum}";


            /* int[] pairs = new int[6];
             for(int i=0; i < pairs.Length; i++)
             {
                 pairs[i] = Noppa.Where(noppas => noppas.Luku == i + 1);
             }
             Pari.Text = pairs.Max().ToString(); */
        }

        private void Yat_Click(object sender, EventArgs e)
        {
            int Summa = 0;


            for (int i = 0; i < noppas.Count; i++)
            {
                if (noppas[i].Luku == noppas[i].Luku)
                {

                    Summa++;

                }
            }
            Yat.Text = $"{Summa}";
        }

        private void KolPari_Click(object sender, EventArgs e)
        {




            /*   var numberCounts = new Dictionary<int, int>();
            for (int i = 0; i < noppas.Count; i++)
            {
                var current = noppas[i];
                if (!numberCounts.ContainsKey(current))
                {
                    numberCounts[current] = 1;
                    continue;
                }

                if (numberCounts[current] == 3 - 1)
                {
                   
                }

                numberCounts[current]++;
            }*/
            //                 silmäluku(key), montako (value)
            string vastaus = "";
            var dict = new Dictionary<int, int>();
            foreach (var noppa in noppas)
            {
                if (dict.ContainsKey(noppa.Luku))
                {
                    dict[noppa.Luku] = dict[noppa.Luku] + 1;
                    if (dict[noppa.Luku] == 3)
                    {
                        vastaus = dict[noppa.Luku].ToString();

                        KolPari.Text = $"{int.Parse(vastaus) * noppa.Luku}";
                        int tnum = 0;
                        tnum = int.Parse(Summa.Text);
                        Summa.Text = $"{int.Parse(vastaus) * noppa.Luku + tnum}";
                        KolPari.Enabled = false;
                    }
                }
                else
                {
                    dict.Add(noppa.Luku, 1);


                }
            }

            /*
            int[] pairs = new int[6];
            int[] pairValues = new int[6];
            const int multiplier = 2;
            int pareja = 0;
            for (int i = 0; i < pairs.Length; i++)
            {
                pairs[i] = noppas.Where(test => test.Luku == i + 1).Count();
            }
            for (int i = 0; i < pairs.Length; i++)
            {
                if (pairs[i] > 1)
                {
                    // pari on löytynyt
                    pareja++;
                    pairValues[i] = (i + 1) * multiplier;
                }
            }

            if (pareja == 2)
            {
                KaksPari.Text = pairValues.Sum().ToString();
            }
            else
            {
                KaksPari.Text = "0";
            }*/

        }

        private void KaksPari_Click(object sender, EventArgs e)
        {
            int[] pairs = new int[6];
            int[] pairValues = new int[6];
            const int multiplier = 2;
            int pareja = 0;
            for (int i = 0; i < pairs.Length; i++)
            {
                pairs[i] = noppas.Where(test => test.Luku == i + 1).Count();
            }
            for (int i = 0; i < pairs.Length; i++)
            {
                if (pairs[i] > 1)
                {
                    // pari on löytynyt
                    pareja++;
                    pairValues[i] = (i + 1) * multiplier;
                }
            }

            if (pareja == 2)
            {
                KaksPari.Text = pairValues.Sum().ToString();
                int tnum = 0;
                tnum = int.Parse(Summa.Text);
                Summa.Text = $"{pairValues.Sum() + tnum}";
            }
            else
            {
                KaksPari.Text = "0";
            }
        }

        private void Summa_Click(object sender, EventArgs e)
        {

        }

        private void NelPari_Click(object sender, EventArgs e)
        {
            string vastaus = "";
            var dict = new Dictionary<int, int>();
            foreach (var noppa in noppas)
            {
                if (dict.ContainsKey(noppa.Luku))
                {
                    dict[noppa.Luku] = dict[noppa.Luku] + 1;
                    if (dict[noppa.Luku] == 4)
                    {
                        vastaus = dict[noppa.Luku].ToString();

                        NelPari.Text = $"{int.Parse(vastaus) * noppa.Luku}";
                        int tnum = 0;
                        tnum = int.Parse(Summa.Text);
                        Summa.Text = $"{int.Parse(vastaus) * noppa.Luku + tnum}";
                    }
                }
                else
                {
                    dict.Add(noppa.Luku, 1);


                }
            }
        }

        private void ViisPari_Click(object sender, EventArgs e)
        {

            bool isStraight = true;
            List<int> numerot = new List<int> { 1, 2, 3, 4, 5 };
            if (isStraight == true)
            {
                for (int i = 0; i <= 5; i++)
                {

                    if (noppas[i].Luku== numerot[i])
                    {
                        ViisPari.Text = numerot.Count.ToString();
                    }
                    if(!noppas[i].Luku==numerot[i])
                }
            }

            /*    int vastaus = 0;+
            for (int i=0;i<noppas.Count; i++)
            {
                vastaus = noppas[i].Luku + vastaus;
            }
             
            if (vastaus == 15)
            {
                ViisPari.Text = 15.ToString();
            }
            else
            {
                ViisPari.Text = 0.ToString();
            }
            */
        }

        private void KuusPari_Click(object sender, EventArgs e)
        {

        }
    }




}


