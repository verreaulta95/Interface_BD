using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Modeles;
using Lab3.Commandes;
using System.Windows;
using Lab3.View;

namespace Lab3.ViewModel
{
    public class MainViewModel : BaseViewModel, INotifyPropertyChanged
    {
        // Attributs
        private Produit produit;
        private BaseViewModel selectedViewModel;     

        public event PropertyChangedEventHandler PropertyChanged;

        // Gets et sets

        public Produit Produit
        {
            get { return produit; }
            set { 
                produit = value;
                OnPropertyChanged("Produit");
            }
        }

        public BaseViewModel SelectedViewModel
        {
            get { return selectedViewModel; }
            set { 
                selectedViewModel = value;
                OnPropertyChanged("SelectedViewModel");
            }
        }

        public BaseCommand CommandeConnexion
        {
            get;
            set;
        }

        // constructeur
        public MainViewModel()
        {
            Produit = new Produit();
            SelectedViewModel = this;
            CommandeConnexion = new BaseCommand(SeConnecte, obj => true);
        }

        protected void OnPropertyChanged(string property = null)
        {
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public void SeConnecte(object p)
        {
            Fenetre fenetre = new Fenetre();
            fenetre.DataContext = SelectedViewModel;
            fenetre.Show();
        }
    }
}
