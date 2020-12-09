using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lab3.Modeles 
{
    public class Produit : INotifyPropertyChanged
    {
        // Attributs
        private string nomProduit;
        private double prixProduit;
        private int hauteurImage;
        private int largeurImage;
        private string background;

        // Gets/Sets
        #region Gets/Sets

        public string Nom
        {
            get { return nomProduit; }
            set
            {
                nomProduit = value;
                OnPropertyChanged("Nom");
            }
        }

        public double Prix
        {
            get { return prixProduit; }
            set
            {
                prixProduit = value;
                OnPropertyChanged("Prix");
            }
        }

        public int Hauteur
        {
            get { return hauteurImage; }
            set
            {
                hauteurImage = value;
                OnPropertyChanged("Hauteur");
            }
        }

        public int Largeur
        {
            get { return largeurImage; }
            set
            {
                largeurImage = value;
                OnPropertyChanged("Largeur");
            }
        }

        public string Background
        {
            get { return background; }
            set
            {
                background = value;
                OnPropertyChanged("Background");
            }
        }

        #endregion 

        // Constructeur

        public Produit()
        {
            Nom = "";
            Prix = 0;
            Hauteur = 50;
            Largeur = 50;
            Background = "";
        }

        // Interface INotifyPropertyChanged 

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
