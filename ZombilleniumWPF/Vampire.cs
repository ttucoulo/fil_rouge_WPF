using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombilleniumWPF
{
    class Vampire : Monstre, IComparable<Vampire>
    {
        private float indiceLuminosite;

        public Vampire(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int affectation1, int cagnotte1, float indiceLumi)
            : base(matricule, nom, prenom, sexe, fonction, affectation1, cagnotte1)
        {
            this.indiceLuminosite = indiceLumi;
        }

        public override void ModifierCagnotte(Monstre monstre, int cagnotte)
        {
            if (this.Prenom.ToLower() == "rose" && this.Nom.ToLower() == "von bloodt")
            {
                monstre.Cagnotte += cagnotte;
                if (monstre.Cagnotte < 50)
                {
                    monstre.Affectation = 684;
                }
                else if (monstre.Cagnotte > 500)
                {
                    monstre.Affectation = 1000;
                }
            }
        }
        public float IndiceLuminosite
            {
            get { return this.indiceLuminosite; }
            }
        public override string ToString()
        {
            return (base.ToString() +
                "indiceLuminosité : " + this.indiceLuminosite);
        }
        public int CompareTo(Vampire vampire)
        {
            return this.indiceLuminosite.CompareTo(vampire.indiceLuminosite);
        }

    }
}
