using System;

namespace Exercice3
{
    class Etudiant
    {

        public string nom;
        public string prenom;
        public float note;

        public Etudiant(string nomEtudiant, string prenomEtudiant, float noteEtudiant)
        {
            nom = nomEtudiant;
            prenom = prenomEtudiant;
            note = noteEtudiant;
        }

    }
}