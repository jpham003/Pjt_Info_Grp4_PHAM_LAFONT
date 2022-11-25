
void AfficherPlateau(char[,] plateau)
{
    for (int i = 0; i < plateau.GetLength(0); i++)
    {
        for (int j = 0; j < plateau.GetLength(1) - 1; j++)
        {
            plateau[i, j] = '*';
            Console.Write($"{plateau[i, j]} ");
        }
        plateau[i, plateau.GetLength(1) - 1] = '*';
        Console.WriteLine(plateau[i, plateau.GetLength(1) - 1]);
    }
}

void InitialiserTableauEtoile()
// Initialiser un plateau de taille nbUplets*nbCartesParUplet avec toutes les cartes cachées
{
    Console.Write(" Combien de cartes par uplets voulez-vous ? ");
    int nbCartesParUplet = Convert.ToInt32(Console.ReadLine()!);
    Console.Write($" Combien de {nbCartesParUplet}-uplets voulez-vous ? ");
    int nbUplets = Convert.ToInt32(Console.ReadLine()!);
    char[,] plateaucache = new char[nbCartesParUplet, nbUplets];
    for (int i = 0; i < nbCartesParUplet; i++)
    {
        for (int j = 0; j < nbUplets - 1; j++)
            plateaucache[i, j] = '*';
        plateaucache[i, nbUplets - 1] = '*';
    }
    AfficherPlateau(plateaucache);
}

InitialiserTableauEtoile();

char GenererCaractereAleatoire()
//Générer aléatoirement un carctère entre ‘a’ et ‘z’, entre ‘A’ et ‘Z’, et/ou entre ‘0’ et ‘9’
{
    Random rnd = new Random();
    char[] listCaracteres = new char[62];
    int j = 48;
    int k = 65;
    int l = 97;
    for (int i = 0; i < 10; i++)
    {
        listCaracteres[i] = Convert.ToChar(j);
        j++;
    }
    for (int i = 10; i < 36; i++)
    {
        listCaracteres[i] = Convert.ToChar(k);
        k++;
    }
    for (int i = 36; i < listCaracteres.Length; i++)
    {
        listCaracteres[i] = Convert.ToChar(l);
        l++;
    }
    int cIndex = rnd.Next(listCaracteres.Length);
    return listCaracteres[cIndex];
}




