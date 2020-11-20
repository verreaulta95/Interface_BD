using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Modele
{
    public class Usager
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Usager(string usager)
        {
            Nom = usager;
        }

    }
}
