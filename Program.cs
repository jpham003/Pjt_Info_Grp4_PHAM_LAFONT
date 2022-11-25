void ChoixCarte(int s, int[] tab, char[,]doubleCache, char[,]doubleVisible)
{
    int i=0;
    do{
        if(i!=0)
        {
            Console.WriteLine("Cette carte est déjà retourné");
        }
        Console.WriteLine("Veuillez indiquer le n° de colomne de la carte que vous souhaitez retourner : "); //Penser à mettre une sureté pour que l'uttilisateur ne puisse rentrer qu'un nombre
        tab[s] =  Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine("Veuillez indiquer le n° de ligne de la carte que vous souhaitez retourner : ");
        tab[s+1] =  Convert.ToInt32(Console.ReadLine()!);
        i++;
    }
    while(doubleCache[tab[s],tab[s+1]] == doubleVisible[tab[s], tab[s+1]]);
    
}




