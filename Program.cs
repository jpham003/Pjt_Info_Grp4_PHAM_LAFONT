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




