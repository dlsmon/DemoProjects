#region summary 
/*
Programmer un jeu du nombre mystérieux
--------------------------------------

L'objectif est de deviner un nombre aléatoire entre 1 et 100 en un minimum de coups.

Spécifications :
- Au démarrage de l'application on affiche un titre pour le jeu
- On présente les règles
- On demande au joueur son nom
- On vérifie que ce nom soit valide :
	- un texte d'au moins 3 caractères de long
	- pas de nombre
- On tire un nombre aléatoire compris entre 1 et 100 inclus
- Tant que le joueur n'a pas deviné le nombre mystérieux
	- On lui demande de saisir un nombre
	- On affiche si le nombre saisi est inférieur ou supérieur au nombre mystérieux
- Une fois qu'il a trouvé le nombre on lui dit qu'il a gagné et on précise en combien de coups
- On lui demande s'il veut refaire une partie
	- Si oui on retourne au tirage d'un nouveau nombre
	- Si non on lui dit Au revoir
*/
#endregion

#region VAR 
//VAR
using System.Text.RegularExpressions;

string Name = "";
Random rnd = new Random();
int randomNumber = rnd.Next(101);//0 a 100
int rounds = 0;
int guessNumber = -1;
String restart = "O";
#endregion

#region MAIN 
GameStart();
#endregion

void GameStart()
{
    Console.WriteLine("--------------------------\n|    Mysterious Number   |\n--------------------------");
    Console.WriteLine("\nLes regles 101\n");

    Name = getUserData();

    //Start Game and get random number from User 
    Console.WriteLine($"\n*****************************************\n\nBienvenue {Name} au jeu Mysterious Number\n\n*****************************************\n*\n*\n*");

    while (guessNumber != randomNumber)
    {
        Console.WriteLine("C'est parti ! Nous avons choise le numero aleatoire de 0 à 100 : ");
        if (!int.TryParse(Console.ReadLine(), out guessNumber))
        {
            Console.Write("Il faut appuyer un nombre! ");
        }
        else if (guessNumber > randomNumber)
        {
            Console.Write($"\nLe nombre mystérieux est plus grand!\nTentez encore une fois MOINS de {guessNumber}! ");
        }
        else if (guessNumber < randomNumber)
        {
            Console.Write($"\nLe nombre mystérieux est plus petit!\nTentez encore une fois PLUS de {guessNumber}! ");
        }
        rounds++;
    }

    Console.WriteLine("\n\n\n\n ******************************************************** \n");
    Console.WriteLine($" Bravo {Name}!!!!! Tu as gagné en {rounds} Rounds coups");
    Console.WriteLine("\n ******************************************************** \n\n\n\n");

    GameLoop();
}

void GameLoop()
{
    //Restart Game
    Console.WriteLine("\n\n Veux-tu rejouer ? : \n");
    restart = Console.ReadLine();
    if (restart.ToLower().StartsWith("o"))
    {
        rounds = 0;
        guessNumber = -1;
        randomNumber = rnd.Next(101);//0 a 100
        GameStart();
    }
    GameEnd();
}

void GameEnd()
{
    Console.WriteLine($"\n************************\n AU REVOIR {Name}\n************************ \n\n\n\n");
}

string getUserData()
{
    //GET NAME
    while (Name == "" || (Name.Length > 0 && Name.Length < 3) || Regex.IsMatch(Name, @"^[0-9]+$"))
    {
        Console.WriteLine("Entre ton prénom : ");
        Name = Console.ReadLine();

        if (Regex.IsMatch(Name, @"^[0-9]+$"))
        {
            Console.Write("Il faut appuyer un nombre! ");
        }
        else if (Name.Length > 0 && Name.Length < 3)
        {
            Console.WriteLine("Ton prénom est très court!");
        }
    }
    return Name;
}

