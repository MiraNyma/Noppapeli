using System;
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
         
       List<Noppa> noppas = new List<Noppa>();

        
       
        public Form1()
        {
            InitializeComponent();
            for (int i=0; i<5; i++)
            {
                PictureBox tempPB = new PictureBox();
                this.Controls.Add(tempPB);
                Noppa tempNoppa = new Noppa(6, tempPB);
                noppas.Add(tempNoppa);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            for (int i=0; i<noppas.Count; i++)
            {
                noppas[i].Heitto();
                AddPictureBox(noppas[i], 1);
            }
            // lisää nopalle property "Koko", jolla määritellään
            // montako silmälukua nopalla on
            // ja käytetään sitä luvun arvonnassa
            // nopan koko annetaan sitä generoidessa
        }
        private void AddPictureBox(Noppa noppa, int count)
        {
            const int spacing = 120;
            //PictureBox tempPB = new PictureBox();
            string key = noppa.GetDiceId();
            noppa.Boxi.Image = Noppa.GetPictureResourceX(key);
            noppa.Boxi.Location = new Point(360 + (count - 1) * spacing, 1);
            noppa.Boxi.Size = new Size(100, 200);
            noppa.Boxi.SizeMode = PictureBoxSizeMode.Zoom;
                    
        }
       
    }
}
