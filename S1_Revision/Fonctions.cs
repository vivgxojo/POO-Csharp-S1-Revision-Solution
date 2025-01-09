using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Revision
{
    /// <summary>
    /// C'est une classe avec des fonction écrites par ChatGPT
    /// </summary>
    public class Fonctions
    {

        /// <summary>
        /// Cette fonction reçoit une chaîne de caractères en argument et retourne sa longueur.
        /// </summary>
        /// <param name="chaine">La chaîne de caractères à évaluer.</param>
        /// <returns>La longueur de la chaîne.</returns>
        public static int Longueur(string chaine)
        {
            return chaine.Length;
        }

        /// <summary>
        /// Cette fonction vérifie si un nombre entier est un multiple de 10.
        /// </summary>
        /// <param name="nombre">Le nombre entier à vérifier.</param>
        /// <returns>True si le nombre est un multiple de 10, sinon False.</returns>
        public static bool EstMultiple10(int nombre)
        {
            return nombre % 10 == 0;
        }

        /// <summary>
        /// Cette fonction calcule le complément d'un nombre entier pour atteindre le multiple de 10 le plus proche.
        /// </summary>
        /// <param name="nombre">Le nombre entier à compléter.</param>
        /// <returns>La valeur manquante pour atteindre le multiple de 10 suivant.</returns>
        public static int Complement10(int nombre)
        {
            return (10 - (nombre % 10)) % 10;
        }

        /// <summary>
        /// Cette fonction retourne le chiffre des dizaines d'un nombre entier.
        /// </summary>
        /// <param name="nombre">Le nombre entier dont on veut extraire le chiffre des dizaines.</param>
        /// <returns>Le chiffre des dizaines.</returns>
        public static int Dizaine(int nombre)
        {
            return Math.Abs(nombre) / 10 % 10;
        }

        /// <summary>
        /// Cette fonction retourne le chiffre des centaines d'un nombre entier.
        /// </summary>
        /// <param name="nombre">Le nombre entier dont on veut extraire le chiffre des centaines.</param>
        /// <returns>Le chiffre des centaines.</returns>
        public static int Centaine(int nombre)
        {
            return Math.Abs(nombre) / 100 % 10;
        }

    }
}
