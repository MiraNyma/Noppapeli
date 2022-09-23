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
        // property
        Noppa noppa1 = new Noppa(20);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noppa1.Heitto();
            label1.Text = noppa1.Luku.ToString();



            // lisää nopalle property "Koko", jolla määritellään
            // montako silmälukua nopalla on
            // ja käytetään sitä luvun arvonnassa
            // nopan koko annetaan sitä generoidessa
        }
        private void addPictureBox(Noppa noppa, int count)
        {
            const int spacing = 120;
            PictureBox tempPB = new PictureBox();
            string key = noppa.GetPictureKey();
            tempPB.Image=Noppa
        }
    }
}
