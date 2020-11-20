using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lab2.Modele
{
    class Oiseau : Animal, INotifyPropertyChanged
    {     
        // Constructeur
        public Oiseau(string nom, int age) : base(nom,"Oiseau",age)
        {
            
        }
    }
}
