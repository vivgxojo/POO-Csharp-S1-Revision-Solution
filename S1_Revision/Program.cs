using System;
using System.IO;
using S1_Revision;

// Collections de valeurs à tester
string[] chaines = { "Bonjour", "", "a", "maman", "MAMAN", "A", "ma maman", "1", "123", "Password_123" };
int[] nombres = { 10, 0, 9, 11, -1, 20, 99, 100, 200};

// Collection pour stocker les résultats
int[] resultatsLongueur = new int[chaines.Length];
bool[] resultatsEstMultiple10 = new bool[nombres.Length];
int[] resultatsComplement10 = new int[nombres.Length];
int[] resultatsDizaine = new int[nombres.Length];
int[] resultatsCentaine = new int[nombres.Length];

// Tableau 2D pour les résultats des fonctions qui ont le même type de retour et les mêmes tests
int[][] tab2D = { resultatsComplement10, resultatsDizaine, resultatsCentaine };

// Boucles qui exécutent les tests et stockent les résultats
for (int i = 0; i < chaines.Length; i++)
{
    resultatsLongueur[i] = Fonctions.Longueur(chaines[i]);
}

for (int i = 0; i < nombres.Length; i++)
{
    resultatsEstMultiple10[i] = Fonctions.EstMultiple10(nombres[i]);
    tab2D[0][i] = Fonctions.Complement10(nombres[i]);
    tab2D[1][i] = Fonctions.Dizaine(nombres[i]);
    tab2D[2][i] = Fonctions.Centaine(nombres[i]);
}

// Boucles pour afficher tous les essais et leurs résultats
Console.WriteLine("\nTests de Longueur :");
for (int i = 0; i < chaines.Length; i++)
{
    Console.WriteLine($"La longueur de : \"{chaines[i]}\" est : {resultatsLongueur[i]}");
}
Console.WriteLine("\nTests de Multiples de 10 :");
for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine($"La longueur de : \"{nombres[i]}\" est : {resultatsEstMultiple10[i]}");
}
for (int i = 0; i < 3; i++)
{
    switch (i)
    {
        case 0:
            Console.WriteLine("\nTests de Complement 10 :");
            break;
        case 1:
            Console.WriteLine("\nTests de Dizaines :");
            break;
        case 2:
            Console.WriteLine("\nTests de Centaines :");
            break;
    }

    for (int j = 0; j < nombres.Length; j++)
    {
        Console.WriteLine($"Test : \"{nombres[j]}\" => Résultat : {tab2D[i][j]}");
    }
}