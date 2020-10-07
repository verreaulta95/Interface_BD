using System;
using System.Collections.Generic;
using System.Text;

namespace RetourPoo
{
    /* Spyder EST UN vehicule */
    class Spyder : Moto
    {
        /* Constructeur de Spyder*/
        public Spyder(int _TailleReservoir, int _DistanceParcourue, Moteur _Moteur, Roue _Roue, string _Couleur, string _Marque, string _Modele)
        {
            this.TailleReservoir = _TailleReservoir;
            this.DistanceParcourue = _DistanceParcourue;
            MoteurMoto = _Moteur;
            RoueMoto = new Roue[3];          
            this.Couleur = _Couleur;
            this.Marque = _Marque;
            this.Modele = _Modele;

            for (int i = 0; i < RoueMoto.Length; i++)
            {
                RoueMoto[i] = new Roue(_Roue);
            }
        }

        /* Constructeur par Copie de Spyder */
        public Spyder(Spyder spyder)
        {
            TailleReservoir = spyder.TailleReservoir;
            DistanceParcourue = spyder.DistanceParcourue;
            MoteurMoto = spyder.MoteurMoto;
            RoueMoto = new Roue[3];
            Couleur = spyder.Couleur;
            Marque = spyder.Marque;
            Modele = spyder.Modele;
        }

        /* Methodes de Spyder */
        public void Demarrer()
        {
            Console.WriteLine("");
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Couleur);
            MoteurMoto.Demarrer();
            Console.WriteLine("La spyder a demarrer !");
        }

        public override void TournerSerrer()
        {
            Console.WriteLine("Pour faire le virage serrer, vous avez simplement tourner le volant");
        }
    }
}
