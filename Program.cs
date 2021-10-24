using System;
using System.Collections.Generic;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entrez le nombre d'étudiants en filière Informatique: ");
            int nombreEtudiants = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------------");

            Option GL = new Option("GL");

            Console.Write("Entrez le nombre de places disponibles pour l'option GL: ");
            GL.placesDispo = int.Parse(Console.ReadLine());

            Option ABD = new Option("ABD");
            Console.Write("Entrez le nombre de places disponibles pour l'option ABD: ");
            ABD.placesDispo = int.Parse(Console.ReadLine());

            Option ASR = new Option("ASR");
            Console.Write("Entrez le nombre de places disponibles pour l'option ASR: ");
            ASR.placesDispo = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------------");

            var listeEtudiants = new List<Tuple<Etudiant, string, string, string>>();

            for (int i = 0; i < nombreEtudiants; i++)
            {
                Console.Write("Entrez le nom de l'étudiant: ");
                string nomEtudiant = Console.ReadLine();

                Console.Write("Entrez le prénom de l'étudiant: ");
                string prenomEtudiant = Console.ReadLine();

                Console.Write("Entrez la note de l'étudiant: ");
                float noteEtudiant = float.Parse(Console.ReadLine());

                Console.WriteLine();

                Etudiant etudiant = new Etudiant(nomEtudiant, prenomEtudiant, noteEtudiant);

                Console.Write("Entrez votre 1er choix: ");
                string choix1 = Console.ReadLine();

                Console.Write("Entrez votre 2ème choix: ");
                string choix2 = Console.ReadLine();

                Console.Write("Entrez votre 3ème choix: ");
                string choix3 = Console.ReadLine();

                Console.WriteLine();

                var choix = Tuple.Create(etudiant, choix1, choix2, choix3);
                listeEtudiants.Add(choix);
            }
            
            var listeGL = new List<Etudiant>();
            var listeABD = new List<Etudiant>();
            var listeASR = new List<Etudiant>();

            for (int i = 0; i < nombreEtudiants; i++)
            {
                switch (listeEtudiants[i].Item2)
                {
                    case "GL":
                        if (GL.placesDispo > 0)
                        {
                            Etudiant etudiant = listeEtudiants[i].Item1;
                            listeGL.Add(etudiant);
                            --(GL.placesDispo);
                        }
                        else
                        {
                            switch (listeEtudiants[i].Item3)
                            {
                                case "ABD":
                                    if (ABD.placesDispo > 0)
                                    {
                                        Etudiant etudiant = listeEtudiants[i].Item1;
                                        listeABD.Add(etudiant);
                                        --(ABD.placesDispo);
                                    }
                                    else
                                    {
                                        if (listeEtudiants[i].Item4 == "ASR" && ASR.placesDispo > 0)
                                        {
                                            Etudiant etudiant = listeEtudiants[i].Item1;
                                            listeASR.Add(etudiant);
                                            --(ASR.placesDispo);
                                        }
                                    }
                                    break;

                                case "ASR":
                                    if (ASR.placesDispo > 0)
                                    {
                                        Etudiant etudiant = listeEtudiants[i].Item1;
                                        listeASR.Add(etudiant);
                                        --(ASR.placesDispo);
                                    }
                                    else
                                    {
                                        if (listeEtudiants[i].Item4 == "ABD" && ABD.placesDispo > 0)
                                        {
                                            Etudiant etudiant = listeEtudiants[i].Item1;
                                            listeABD.Add(etudiant);
                                            --(ABD.placesDispo);
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                    case "ABD":
                        if (ABD.placesDispo > 0)
                        {
                            Etudiant etudiant = listeEtudiants[i].Item1;
                            listeABD.Add(etudiant);
                            --(ABD.placesDispo);
                        }
                        else
                        {

                            switch (listeEtudiants[i].Item3)
                            {
                                case "GL":
                                    if (GL.placesDispo > 0)
                                    {
                                        Etudiant etudiant = listeEtudiants[i].Item1;
                                        listeGL.Add(etudiant);
                                        --(GL.placesDispo);
                                    }
                                    else
                                    {
                                        if (listeEtudiants[i].Item4 == "ASR" && ASR.placesDispo > 0)
                                        {
                                            Etudiant etudiant = listeEtudiants[i].Item1;
                                            listeASR.Add(etudiant);
                                            --(ASR.placesDispo);
                                        }
                                    }
                                    break;

                                case "ASR":
                                    if (ASR.placesDispo > 0)
                                    {
                                        Etudiant etudiant = listeEtudiants[i].Item1;
                                        listeASR.Add(etudiant);
                                        --(ASR.placesDispo);
                                    }
                                    else
                                    {
                                        if (listeEtudiants[i].Item4 == "GL" && GL.placesDispo > 0)
                                        {
                                            Etudiant etudiant = listeEtudiants[i].Item1;
                                            listeGL.Add(etudiant);
                                            --(GL.placesDispo);
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                    case "ASR":
                        if (ASR.placesDispo > 0)
                        {
                            Etudiant etudiant = listeEtudiants[i].Item1;
                            listeASR.Add(etudiant);
                            --(ASR.placesDispo);
                        }
                        else
                        {

                            switch (listeEtudiants[i].Item3)
                            {
                                case "ABD":
                                    if (ABD.placesDispo > 0)
                                    {
                                        Etudiant etudiant = listeEtudiants[i].Item1;
                                        listeABD.Add(etudiant);
                                        --(ABD.placesDispo);
                                    }
                                    else
                                    {
                                        if (listeEtudiants[i].Item4 == "GL" && GL.placesDispo > 0)
                                        {
                                            Etudiant etudiant = listeEtudiants[i].Item1;
                                            listeGL.Add(etudiant);
                                            --(GL.placesDispo);
                                        }
                                    }
                                    break;

                                case "GL":
                                    if (GL.placesDispo > 0)
                                    {
                                        Etudiant etudiant = listeEtudiants[i].Item1;
                                        listeGL.Add(etudiant);
                                        --(GL.placesDispo);
                                    }
                                    else
                                    {
                                        if (listeEtudiants[i].Item4 == "ABD" && ABD.placesDispo > 0)
                                        {
                                            Etudiant etudiant = listeEtudiants[i].Item1;
                                            listeABD.Add(etudiant);
                                            --(ABD.placesDispo);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;

                }

            }

            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("La liste des étudiants en GL: ");
            foreach (Etudiant liste in listeGL) Console.WriteLine(liste.nom + " " + liste.prenom + " - " + liste.note);
            Console.WriteLine();

            Console.WriteLine("La liste des étudiants en ABD: ");
            foreach (Etudiant liste in listeABD) Console.WriteLine(liste.nom + " " + liste.prenom + " - " + liste.note);
            Console.WriteLine();

            Console.WriteLine("La liste des étudiants en ASR: ");
            foreach (Etudiant liste in listeASR) Console.WriteLine(liste.nom + " " + liste.prenom + " - " + liste.note);

            Console.WriteLine("-------------------------------------------------------------");
        }

    }
}
