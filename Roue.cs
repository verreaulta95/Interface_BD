using System;
using System.Collections.Generic;
using System.Text;

namespace RetourPoo
{
    /* Un vehicule EST COMPOSE de Roues */
    class Roue
    {
        /* Attributs de Roue */
        private int largeur;
        private int pourcentageHauteur;
        private int diametreJante;
        private int indiceCharge;
        private int indiceVitesse;
        private int pression;
        private string type;

        /* Accesseurs et Mutateurs */
        public int Largeur { get => largeur; set => largeur = value; }
        public int PourcentageHauteur { get => pourcentageHauteur; set => pourcentageHauteur = value; }
        public int DiametreJante { get => diametreJante; set => diametreJante = value; }
        public int IndiceCharge { get => indiceCharge; set => indiceCharge = value; }
        public int IndiceVitesse { get => indiceVitesse; set => indiceVitesse = value; }
        public int Pression { get => pression; set => pression = value; }
        public string Type { get => type; set => type = value; }

        /* Methodes */

        // Recoit le nombre de Roue en paramètre 
        public Roue(int _largeur, int _pourcentageHauteur, int _DiametreJante, int _IndiceCharge, int _IndiceVitesse, int _pression, string _Type)
        {
            this.Largeur = _largeur;
            this.PourcentageHauteur = _pourcentageHauteur;
            this.DiametreJante = _DiametreJante;
            this.IndiceCharge = _IndiceCharge;
            this.IndiceVitesse = _IndiceVitesse;
            this.Pression = _pression;
            this.Type = _Type;
        }

        /* Constructeur par copie */
        public Roue(Roue roue1)
        {
            Largeur = largeur;
            PourcentageHauteur = roue1.pourcentageHauteur;
            DiametreJante = roue1.DiametreJante;
            IndiceCharge = roue1.IndiceCharge;
            IndiceVitesse = roue1.IndiceVitesse;
            Pression = roue1.pression;
            Type = roue1.type;
        }

        public int GonflerPneu(int _pression)
        {
            Pression = Pression + _pression;

            Console.WriteLine("Votre pneu a ete correctement gonfler");

            return Pression;
        }
    }
}
