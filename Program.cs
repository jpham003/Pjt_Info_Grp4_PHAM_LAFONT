void Tour(int n, char[,]doubleCache, char[,]doubleVisible ) // n représente le nombre de uplet
{
    int i =1;
    int[] coordonnee = new int[2];
    int[] ancienCoordonnee = new int[2];
    ChoixCarte(coordonnee, doubleCache, doubleVisible);
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
            Echec(coordonnee, doubleVisible);  // configurer fonction echec
        }

        i++;
    }
    //commencer nouveau tour dans le main

}

