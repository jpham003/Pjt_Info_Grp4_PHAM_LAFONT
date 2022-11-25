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

void Tour(int n, char[,]doubleCache, char[,]doubleVisible ) // n représente le nombre de uplet
{
    int i =1;
    int[] coordonnee = new int[2];
    int[] ancienCoordonnee = new int[2];
    ChoixCarte(coordonnee);
    while(i <= n && perdu == false)
    {
        doubleVisible[coordonnee[0],coordonnee[1]] = doubleCache[coordonnee[0],coordonnee[1]];
        MiseAJourTableau(doubleVisible);
        ancienCoordonnee[0]= coordonnee[0];
        ancienCoordonnee[1] = coordonnee[1];
        ChoixCarte(coordonnee);
        doubleVisible[coordonnee[0],coordonnee[1]] = doubleCache[coordonnee[0],coordonnee[1]];
        MiseAJourTableau(doubleVisible);

        if(doubleCache[coordonnee[0],coordonnee[1]] =! doubleCache[ancienCoordonnee[0],ancienCoordonnee[1]])
        {
            Echec(coordonnee, ancienCoordonnee);  // configurer fonction echec
        }

        i++;
    }

    if (perdu == false)
    {

    }

}

void ChoixCarte(int[] tab)
{
    int s=0;
    do{
        if(s!=0)
        {
            Console.WriteLine("Cette carte est déjà retourné");
        }
        Console.WriteLine("Veuillez indiquer le n° de colomne de la carte que vous souhaitez retourner : "); //Penser à mettre une sureté pour que l'uttilisateur ne puisse rentrer qu'un nombre
        tab[0] =  Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine("Veuillez indiquer le n° de ligne de la carte que vous souhaitez retourner : ");
        tab[1] =  Convert.ToInt32(Console.ReadLine()!);
        s++;
    }
    while(doubleCache[tab[0],tab[1]] == doubleVisible[tab[0], tab[1]]);
    
}





