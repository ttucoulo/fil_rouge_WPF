﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombilleniumWPF
{
    class Fantome : Monstre
    {
        public Fantome(int matricule, string nom, string prenom, TypeSexe sexe, string fonction ,int affectation1, int cagnotte1) 
            : base(matricule, nom, prenom, sexe, fonction,affectation1, cagnotte1)
        {

        }
        public override void ModifierCagnotte(Monstre monstre, int cagnotte)
        {

        }
        public override string ToString()
        {
            return (base.ToString());
        }
    }
}
