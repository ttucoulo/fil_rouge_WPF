﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombilleniumWPF
{
    class Sorcier : Personnel
    {
        private Grade tatouage;
        private List<string> pouvoirs;

        public Sorcier(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, Grade tatouage, List<string> pouvoirs)
            :base(matricule,nom,prenom,sexe,fonction)
        {
            this.tatouage = tatouage;
            this.pouvoirs = pouvoirs;
        }
        public Grade Tatouage
        {
            get { return this.tatouage; }
        }
        public override string ToString()
        {
            return base.ToString()+ " tatouage : "+this.tatouage;
        }
    }
}
