using System;
using System.Collections.Generic;
using System.Text;

namespace RetourPoo
{
    abstract class Vehicule
    {
        /* Attributs */
        private int dureeVieKm;
        private int autonomieKm;
        private string couleur;
        private int anneeDeProduction;
        private string marque;
        private string modele;

        // Accesseurs et mutateurs
        public int DureeVieKm { get => dureeVieKm; set => dureeVieKm = value; }
        public int AutonomieKm { get => autonomieKm; set => autonomieKm = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public int AnneeDeProduction { get => anneeDeProduction; set => anneeDeProduction = value; }
        public string Marque { get => marque; set => marque = value; }
        public string Modele { get => modele; set => modele = value; }


        /* constructeur */
        public Vehicule()
        {

        }

        public Vehicule(int _DureeVieKm, int _AutonomieKm, string _Couleur, int _AnneeDeProd, string _Marque, string _Modele)
        {
            this.DureeVieKm = _DureeVieKm;
            this.AutonomieKm = _AutonomieKm;
            this.Couleur = _Couleur;            
            this.AnneeDeProduction = _AnneeDeProd;
            this.Marque = _Marque;
            this.Modele = _Modele;
        }

        /* Constructeur par Copie */
        public Vehicule(Vehicule vehicule)
        {
            DureeVieKm = vehicule.DureeVieKm;
            AutonomieKm = vehicule.AutonomieKm;
            Couleur = vehicule.Couleur;
            AnneeDeProduction = vehicule.AnneeDeProduction;
            Marque = vehicule.Marque;
            Modele = vehicule.Modele;
        }

        /* Methodes */
        virtual public void Demarrer()
        {

        }


    }
}
