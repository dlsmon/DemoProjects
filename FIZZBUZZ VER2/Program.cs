#region Summary
/* 

Programmer un FizzBuzz
----------------------

Présentation :

FizzBuzz est un jeu de comptage qui se joue à plusieurs.
Les joueurs se mettent en cercle puis, un premier joueur est choisi.
Le premier joueur commence alors à compter, puis chaque joueur dans l'ordre annonce le nombre suivant.
Si un joueur se trompe, il est retiré du jeu puis le jeu rédémarre à 1 avec les joueurs restants.
Le gagnant est le dernier a rester en jeu.

Subtilités :

Ce serai bien trop facile s'il suffisait de compter normalement.
La difficulté réside dans le fait que, si le nombre à annoncer est un multiple de 3, il faut dir Fizz au lieu du nombre en question.
Si le nombre est un multiple de 5, il faut annocer Buzz.
S'il est à la fois multiple de 3 et 5 on doit annoncer FizzBuzz.

Exemple de comptage correct et de sortie attendue dans la console :

1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz, 31, 32, Fizz, 34, Buzz, Fizz, 37, 38, Fizz, Buzz, 41, Fizz, 43, 44, FizzBuzz, 46, 47, Fizz, 49, Buzz, ...


Objectif :
----------

1 - Programmer un simulateur de FizzBuzz qui se contente de compter de 1 à 100 en effectuant les bonnes annonces

2 - Trouver au moins une autre alternative (une autre façon de programmer) le même jeu

3 - Simuler un jeu de FizzBuzz avec plusieurs joueurs (nombre à définir entre 2 et 10) à qui on demandera leurs noms, jusqu'à obtenir un gagnant

*/
#endregion


#region VAR 
//VAR
using System.Text.RegularExpressions;
using System.Xml.Linq;

List<string> playerList = new List<string>();
int numberOfPlayers = 0;

int roundPosition = 1;
int playerPosition = 0;

string correctAnswer = "1";
string guessAnswer = "1";

int gameOver = 0;

Random rnd = new Random();
int randomNumber = rnd.Next(101);//0 a 100
#endregion


#region MAIN 
GameStart();
#endregion


void GameStart()
{
    Console.WriteLine("--------------------------\n|    FizzBUZZ GAME    |\n--------------------------");
    Console.WriteLine("\nLes regles 101\n");

    getNumberOfPlayers();
    setNameOfPlayers();

    playGame();
}

void getNumberOfPlayers()
{
    while (numberOfPlayers < 3 || numberOfPlayers > 10)
    {
        Console.WriteLine("Go! Choose the number of Players: ");
        if (!int.TryParse(Console.ReadLine(), out numberOfPlayers))
        {
            Console.Write("You must write a number!");
        }
        else if (numberOfPlayers < 3 || numberOfPlayers > 10)
        {
            Console.Write("Only between 3 and 10 players! : ");

        }
    }
    if (numberOfPlayers > 1)
    {
        Console.WriteLine($"You have choosen a multi player game with {numberOfPlayers} players!");
    }
}

void setNameOfPlayers()
{
    string Name = "";
    for (int i = 0; i < numberOfPlayers; i++)
    {
        //GET NAME OF PLAYERS
        while (Name == "" || (Name.Length > 0 && Name.Length < 3) || Regex.IsMatch(Name, @"^[0-9]+$"))
        {
            Console.WriteLine($"Enter the name of player {i + 1} : ");
            Name = Console.ReadLine();

            if (Regex.IsMatch(Name, @"^[0-9]+$"))
            {
                Console.Write("You must write a name, not numbers! ");
            }
            else if (Name.Length > 0 && Name.Length < 3)
            {
                Console.WriteLine("Your name is too short!");
            }
        }
        playerList.Add(Name);
        Name = "";
    }

    printNameOfPlayers();

}

void printNameOfPlayers()
{
    int n = 1;
    foreach (string item in playerList)
    {
        Console.Write($" | Player {n} {item} |");
    }
    Console.Write("\n\n");
}

void playGame()
{
        Console.Write($"Player {playerPosition + 1} - {playerList[playerPosition]} ! What's the next answer : ");
        guessAnswer = Console.ReadLine();

        //Console.WriteLine(guessAnswer);
        testAnswer();
        //Console.WriteLine("\n\n GAME OVER \n\n");
}

void wrongAnswer()
{
    //Answer is wrong, eliminate player (check if number of player is more than one, else game over)
    //remove player 
    //Correct n of players
    if (numberOfPlayers > 1)
    {
        //Console.WriteLine($"remove player {playerList[playerPosition]}");
        Console.WriteLine($"\n\n Player {playerPosition + 1} - {playerList[playerPosition]} lost and is removed! Players left: ");
        playerList.RemoveAt(playerPosition);
        printNameOfPlayers();
        numberOfPlayers--;
        //continue the loop because there's more players!!
        roundPosition = 1;
        playerPosition = 0;
        correctAnswer = "1";
        guessAnswer = "1";
        Console.WriteLine($" START AGAIN !! ");
    }
    else
    {
        gameOver = 1;
    }
}

void nextUserAnswer()
{
    roundPosition++;
    if (playerPosition < numberOfPlayers - 1)
    {
        playerPosition++;
        //Console.WriteLine("position ++ next player");
    }
    else
    {
        playerPosition = 0;
        //Console.WriteLine("position 0");
    }
}

void testAnswer()
{
    if (guessAnswer.ToLower() == "fizz")
    {
        if (roundPosition % 3 == 0)
        {
            nextUserAnswer();
        }
        //Console.Write("fizz");
    }
    else if (guessAnswer.ToLower() == "buzz")
    {
        if (roundPosition % 5 == 0)
        {
            nextUserAnswer();
        }
        //Console.Write("buzz");
    }
    else if (guessAnswer.ToLower() == "fizzbuzz")
    {
        if (roundPosition % 5 == 0 && roundPosition % 3 == 0)
        {
            nextUserAnswer();
        }
        //Console.Write("fizzbuzz");
    }
    else if (Regex.IsMatch(guessAnswer, @"^[0-9]+$"))
    {
        if (roundPosition % 5 == 0 || roundPosition % 3 == 0 || (roundPosition % 5 == 0 && roundPosition % 3 == 0))
        {
            //wrong answer
            wrongAnswer();
            //Console.Write("a number but not %3/5/35");
        }
        else if (roundPosition == int.Parse(guessAnswer))
        {
            //Console.Write($" a number {roundPosition} - {guessAnswer} ");
            nextUserAnswer();
        }
        else
        {
            wrongAnswer();
        }
    }
    else
    {
        //all texts except fizz buzz and fizzbuzz
        wrongAnswer();
    }

    isGameOver();
}

void isGameOver()
{
    if (gameOver == 0)
    {
        playGame();
    }
    else
    {
        Console.Write($"\n\n GAME OVER \n\n");
    }
}