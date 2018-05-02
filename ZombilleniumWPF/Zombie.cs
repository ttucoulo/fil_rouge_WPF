﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombilleniumWPF
{
    class Zombie : Monstre, IComparable<Zombie>
    {
        private CouleurZ teint;
        private int degreDecomposition;

        public Zombie(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int affectation1 ,int cagnotte1, CouleurZ teint, int degreDecomp)
            : base(matricule, nom, prenom, sexe, fonction, affectation1, cagnotte1)
        {
            this.teint = teint;
            this.degreDecomposition = degreDecomp;
        }

        public override void ModifierCagnotte(Monstre monstre, int cagnotte)
        {

        }
        public override string ToString()
        {
            return (base.ToString() +
                " Décomposition : " + this.degreDecomposition + " teint :"+this.teint);
        }
        public int CompareTo(Zombie zombie)
        {
            return this.degreDecomposition.CompareTo(zombie.degreDecomposition);
        }
    }
}
