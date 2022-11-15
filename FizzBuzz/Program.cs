﻿#region Summary
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

#endregion

for (int i = 0; i < 102; i++)
{
    if (i % 3 == 0 || i % 5 == 0 || (i % 3 == 0 && i % 5 == 0))
    {
        if (i % 3 == 0) Console.WriteLine($"fizz");
        if (i % 5 == 0) Console.WriteLine($"buzz");
    }
    else
    {
        Console.WriteLine($", {i}");
    }
}