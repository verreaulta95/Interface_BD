using System;
using System.Collections.Generic;
using System.Text;

namespace RetourPoo
{
    /* Un vehicule EST COMPOSE d'un Moteur */
    class Moteur
    {
        /* Attributs de Moteur */
        private int taille;
        private int nbCylindre;
        private int puissanceChevaux;
        private double consommationParKm;

        /* Accesseurs et Mutateurs */
        public int Taille { get => taille; set => taille = value; }
        public int NbCylindre { get => nbCylindre; set => nbCylindre = value; }
        public int PuissanceChevaux { get => puissanceChevaux; set => puissanceChevaux = value; }
        public double ConsommationParKm { get => consommationParKm; set => consommationParKm = value; }
        
       /* Constructeur de Moteur */ 

        public Moteur(int _Taille, int _nbCylindre, int _PuissanceChevaux, double _ConsommationParKm)
        {
            this.Taille = _Taille;
            this.NbCylindre = _nbCylindre;
            this.PuissanceChevaux = _PuissanceChevaux;
            this.ConsommationParKm = _ConsommationParKm;
        }

        /* Ajouter Constructeur par Copie */
        public Moteur(Moteur moteur)
        {
            Taille = moteur.Taille;
            NbCylindre = moteur.NbCylindre;
            PuissanceChevaux = moteur.PuissanceChevaux;
            ConsommationParKm = moteur.ConsommationParKm;
        }

        /* Methodes de Moteur */
        public void Demarrer()
        {
            Console.WriteLine("Vroooooom !");            
        }

    }
}
