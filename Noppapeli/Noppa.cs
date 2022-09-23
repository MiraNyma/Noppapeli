using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppapeli
{
    class Noppa
    {
        public List<>
        // property
        public int Luku;
        public int Koko;

        // method
        public Noppa(int koko) // constructor
        {
            Koko = koko;
            Heitto();
        }
        public void Heitto()
        {
            Random rng = new Random();
            Luku = rng.Next(1, Koko+1);
        }
        private char getDiceId()
        {
            int returnvalue = 0;
            int silmaluku = Luku;
            returnvalue = silmaluku;
            return (char)returnvalue;
        }
        public string GetPictureKey()
        {
            string returnValue = "";
            char lukumme = getDiceId();
            returnValue = lukumme.ToString();
            return returnValue;
        }
        public static Image GetPictureResourceX(string key)
        {
            return Noppapeli
        }
    }
}
