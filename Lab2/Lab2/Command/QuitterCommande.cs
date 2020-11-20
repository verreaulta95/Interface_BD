using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Lab2.ViewModele;

namespace Lab2.Commande
{
    public class QuitterCommande : ICommand
    {
        // Attributs
        private MenuViewModel viewModel;

        // Gets et Sets
        public MenuViewModel ViewModel
        {
            get { return viewModel; }
            set
            {
                viewModel = value;
            }
        }

        // Constructeur de la commande Quitter qui recoit en parametre le MenuViewModel
        public QuitterCommande(MenuViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        // Fait afficher une boite de message
        public void Execute(object parameter)
        {
            MessageBox.Show("Vous devez clicker sur le X en haut a droite !", "Quitter");
        }
    }
}
