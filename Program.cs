void Tour(int n, char[,]doubleCache, char[,]doubleVisible ) // n représente le nombre de uplet
{
    bool perdu = false;
    int i =1; // initialisation du compteur de tour
    int s = 0; // initialisation de la variable compteur de coordonnée
    int[] coordonnee = new int[n*2];
    //int[] ancienCoordonnee = new int[2];
    //ChoixCarte(1, coordonnee, doubleCache, doubleVisible);
    while(i <= n && perdu == false)
    {
        doubleVisible[coordonnee[0],coordonnee[1]] = doubleCache[coordonnee[0],coordonnee[1]];
        MiseAJourTableau(doubleVisible);
        //ancienCoordonnee[0]= coordonnee[0];
        //ancienCoordonnee[1] = coordonnee[1];
        
        ChoixCarte(i,coordonnee, doubleCache, doubleVisible);
        doubleVisible[coordonnee[s],coordonnee[s+1]] = doubleCache[coordonnee[s],coordonnee[s+1]];
        MiseAJourTableau(doubleVisible);

        if(i!= 1 && doubleCache[coordonnee[s],coordonnee[s+1]] != doubleCache[coordonnee[s-2],coordonnee[s-1]])
        {
            Echec(i,coordonnee, doubleVisible);  // configurer fonction echec
            perdu = true;
        }
        s= s+2;
        i++;
    }
    //commencer nouveau tour dans le main

}

