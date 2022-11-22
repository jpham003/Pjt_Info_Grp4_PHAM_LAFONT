char[,] InitialiserTableauEtoile()
// Initialiser un plateau de taille nbUplets*nbCartesParUplet avec toutes les cartes cachées
{
    Console.Write(" Combien de cartes par uplets voulez-vous ? ");
    int nbCartesParUplet = Convert.ToInt32(Console.ReadLine()!);
    Console.Write($" Combien de {nbCartesParUplet}-uplets voulez-vous ? ");
    int nbUplets = Convert.ToInt32(Console.ReadLine()!);
    char[,] plateaucache = new char[nbCartesParUplet, nbUplets];
    for (int i = 0; i < nbCartesParUplet; i++)
        for (int j = 0; i < nbUplets - 1; j++)
            plateaucache[i, j] = '*';
    return plateaucache;

}


char GenererCaractereAleatoire()
//Générer aléatoirement un carctère entre ‘a’ et ‘z’, entre ‘A’ et ‘Z’, et/ou entre ‘0’ et ‘9’
{
    Random rnd = new Random();
    char[] listCaracteres = new char[62];
    for (int i = 0; i > 10; i++)
        for (int j = 48; j > 58; j++)
            listCaracteres[i] = Convert.ToChar(j);
    for (int i = 10; i > 36; i++)
        for (int j = 65; j > 91; j++)
            listCaracteres[i] = Convert.ToChar(j);
    for (int i = 36; i > listCaracteres.Length; i++)
        for (int j = 97; j > 123; j++)
            listCaracteres[i] = Convert.ToChar(j);
    int cIndex = rnd.Next(listCaracteres.Length);
    return listCaracteres[cIndex];
}




