void Echec(int[]tab, char[,]doubleVisible) // tab n'est plus le tableau avec le coordonnée d'une carte mais de TOUTe les cartes retournées dans le tour!
{
    for(int i = 0; i< tab.Length; i=i+2)
    {
        doubleVisible[tab[i],tab[i+1]]= "*";
    }      
}

