﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombilleniumWPF
{
    abstract class Personnel
    {
        private string fonction;
        private int matricule;
        private string nom;
        private string prenom;
        private TypeSexe sexe;

        public Personnel(int matricule, string nom, string prenom, TypeSexe sexe, string fonction)
        {
            this.fonction = fonction;
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
        }

        public override string ToString()
        {
            return "Prenom: " + this.Prenom + " Nom : " + this.Nom + " matricule : " + this.Matricule+" fonction : "+this.fonction;
        }

        public string Nom
        {
            get { return this.nom; }
        }
        public string Prenom
        {
            get { return this.prenom; }
        }
        public int Matricule
        {
            get { return this.matricule; }
        }
        public string Fonction
        {
            get { return this.fonction; }
            set { this.fonction = value; }
        }
        public TypeSexe Sexe
        {
            get { return this.sexe; }
        }
    }
}
