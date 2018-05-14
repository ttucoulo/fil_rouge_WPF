using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombilleniumWPF
{
    class Monstre : Personnel,INotifyPropertyChanged, IComparable<Monstre>
    {
        //private Attraction affectation;
        private int affectation;
        private int cagnotte;

        public event PropertyChangedEventHandler PropertyChanged;
        
        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int affectation1, int cagnotte1)
            : base(matricule, nom,prenom,sexe,fonction)
        {
            this.affectation = affectation1;
            this.cagnotte = cagnotte1;
        }

        public virtual void ModifierCagnotte(Monstre monstre, int cagnotte)
        {

        }
        
        public override string ToString()
        {
            return base.ToString()+" Affectation : "+ this.affectation + " cagnotte : " + this.cagnotte.ToString();
        }

        public int CompareTo(Monstre monstre)
        {
            return this.cagnotte.CompareTo(monstre.cagnotte);
        }

        public int Affectation
        {
            get { return this.affectation; }
            set { this.affectation = value; }
        }
        public int Cagnotte
        {
            get { return this.cagnotte; }
            set
            {
                if (value != this.cagnotte)
                {
                    cagnotte = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("cagnotte"));
                    }
                }
                else { this.cagnotte = value; }
            }
        }
    }
}
