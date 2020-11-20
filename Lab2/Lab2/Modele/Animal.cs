using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lab2.Modele
{
    public class Animal : INotifyPropertyChanged
    {
        // Attributs pour les classes enfants d'Animal
        private string nom;
        private string type;
        private int age;

        // Gets et Sets
        #region Gets/Sets
        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
                OnPropertyChanged("Nom");
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string nom = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nom));
        }

        // Constructeur
        public Animal(string nom, string type, int age)
        {
            this.Nom = nom;
            this.Type = type;
            this.Age = age;
        }        
    }
}
