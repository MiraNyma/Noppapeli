using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noppapeli
{
    class Noppa
    {
        public PictureBox Boxi = new PictureBox();
        // property
        public int Luku;
        public int Koko;
        
        
        // method
        public Noppa(int koko, PictureBox boxi) // constructor
        {
            Koko = koko;
            Heitto();
            Boxi = boxi;
        }
        public void Heitto()
        {
            Random rng = new Random();
            Luku = rng.Next(1, Koko+1);
        }
       
            public string GetDiceId()
        {
            const string tiedostonAlku = "Noppa"; // noppa kuvien tiedostot (Resource1.resx) alkaa tekstillä "Noppa"
            string returnValue = tiedostonAlku;
            
            switch (Luku)
            {
                case 1:
                    returnValue = returnValue + Luku.ToString();
                    break;
                case 2:
                    returnValue = "Noppa2";
                    break;
                case 3:
                    returnValue = "Noppa3";
                    break;
                case 4:
                    returnValue = "Noppa4";
                    break;
                case 5:
                    returnValue = "Noppa5";
                    break;
                case 6:
                    returnValue = "Noppa6";
                    break;
                
            }
            return returnValue;
            
            //char lukumme = getDiceId();
            //returnValue = lukumme.ToString();
            //return returnValue;
        }
        public static Image GetPictureResourceX(string key)
        {
            return Noppapeli.Resource1.ResourceManager.GetObject(key) as Image;
                
        }
    }
}
