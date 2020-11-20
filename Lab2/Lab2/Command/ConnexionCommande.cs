using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Lab2.ViewModele;
using Lab2.Modele;

namespace Lab2.Commande
{
    public class ConnexionCommande : ICommand
    {
        // Attributs
        private MainViewModel pageConnexion;
        private AnimalViewModel pageAnimal;
        private BaseViewModel viewModelActif;

        // Gets et Sets
        #region Gets/Sets 

        public MainViewModel PageConnexion
        {
            get { return pageConnexion; }
        }

        public AnimalViewModel PageAnimal
        {
            get { return pageAnimal; }
            set
            {
                pageAnimal = value;
            }
        }

        public BaseViewModel ViewModelActif
        {
            get { return viewModelActif; }
            private set
            {
                viewModelActif = value;                
            }
        }
        
        #endregion

        // Constructeur qui recoit une instance de MainViewModel
        public ConnexionCommande(MainViewModel viewModel)
        {
            pageConnexion = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return pageConnexion.PeutSeConnecter;
        }

        public void Execute(object parameter)
        {
            PageConnexion.SeConnecter();
        }
    }
}
