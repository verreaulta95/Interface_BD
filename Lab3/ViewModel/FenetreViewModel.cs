using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.ViewModel
{
    public class FenetreViewModel : BaseViewModel, INotifyPropertyChanged
    {
        // Attributs
        private BaseViewModel selectedViewModel;

        public event PropertyChangedEventHandler PropertyChanged;

        // Gets et Sets
        public BaseViewModel SelectedViewModel
        {
            get { return selectedViewModel; }
            set { 
                selectedViewModel = value;
                OnPropertyChanged("SelectedViewModel");
            }
        }
        // Constructeur
        public FenetreViewModel()
        {
            selectedViewModel = this;
        }

        protected void OnPropertyChanged(string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
