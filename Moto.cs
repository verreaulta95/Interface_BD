using System;
using System.Collections.Generic;
using System.Text;


namespace RetourPoo
{
    // Moto EST UN vehicule
    class Moto : Vehicule
    {
        /* Attribut de Moto */
        private Moteur moteur;
        private Roue[] roueMoto;
        private string style;
        private int tailleReservoir;
        private double distanceParcourue;

        /* Accesseurs et Mutateurs */
        public Moteur MoteurMoto { get => moteur; set => moteur = value; }
        public Roue[] RoueMoto { get => roueMoto; set => roueMoto = value; }
        public string Style { get => style; set => style = value; }
        public int TailleReservoir { get => tailleReservoir; set => tailleReservoir = value; }
        public double DistanceParcourue { get => distanceParcourue; set => distanceParcourue = value; }

        /* Constructeur */
        public Moto()
        {

        }

        public Moto(int _TailleReservoir, string _Style, double _DistanceParcourue, Moteur _moteur, Roue _roue, string _Couleur, string _Marque, string _Modele)
        {
            this.TailleReservoir = _TailleReservoir;
            this.Style = _Style;
            this.DistanceParcourue = _DistanceParcourue;
            moteur = _moteur;
            roueMoto = new Roue[2];
            this.Couleur = _Couleur;
            this.Marque = _Marque;
            this.Modele = _Modele;

            for (int i = 0; i < roueMoto.Length; i++)
            {
                roueMoto[i] = new Roue(_roue);
            }
        }

        // Constructeur par copie de Moto
        public Moto(Moto _moto)
        {
            TailleReservoir = _moto.TailleReservoir;
            Style = _moto.Style;
            DistanceParcourue = _moto.DistanceParcourue;
            Moteur moteur = _moto.moteur;
            Roue roue = _moto.roueMoto[2];
            Couleur = _moto.Couleur;
            Marque = _moto.Marque;
            Modele = _moto.Modele;
        }

        /* Methodes */
        public void Demarrer() 
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Couleur);
            MoteurMoto.Demarrer();            
            Console.WriteLine("La moto a demarrer !");
        }

        public void Rouler(int _distanceVehicule)
        {
            int fin = _distanceVehicule;

            do
            {
                if (fin > 30)
                    Console.WriteLine("Vous avez roule " + DistanceParcourue + " km. Vous devez refaire le plein avant de continuer le voyage !");
                else
                    Console.WriteLine("Vous avez roule " + DistanceParcourue + " km !");

                DiminuerPression();
                FaireLePlein();                              
                AjouterUsure(fin);
                fin = fin - (int)DistanceParcourue;

                if (fin == 0)
                    Console.WriteLine("Le voyage est fini");

            } while (fin > 0);
        }

        public void DiminuerPression()
        {
            for (int i = 0; i < roueMoto.Length; i++)
            {
                roueMoto[i].Pression -= 1;
            }
        }

        public void AjouterPression()
        {
            for (int i = 0; i < roueMoto.Length; i++)
            {
                roueMoto[i].Pression = roueMoto[i].GonflerPneu(35 - roueMoto[i].Pression);
            }            
        }

        public void FaireLePlein()
        {
            TournerSerrer();

            for (int i = 0; i < roueMoto.Length; i++)
            {
                if (roueMoto[i].Pression < 25)
                    AjouterPression();
            }
            Console.WriteLine("Vous avez fait le plein !");
        }

        virtual public void TournerSerrer()
        {
            Console.WriteLine("Vous tournez serrer dans une virage et avez incliner la moto.");
        }

        virtual public void AjouterUsure(int _fin)
        {
            int usure = _fin;

            if(DureeVieKm == 0)
            {
                if (style == "Chopper")
                {
                    if (usure < DistanceParcourue)
                        Console.WriteLine("Votre " + style + " risque de lâcher a tout moment !");
                }
                else
                {
                    if (usure < DistanceParcourue)
                        Console.WriteLine("Votre " + style + " risque de lâcher a tout moment !");
                }
            }

                                      
        }
        /* Fin */
    }
}
