//Problem 4. Print a Deck of 52 Cards
//
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;
class DeckOf52Cards
{
    static void Main()
    {
        //char numbers for each suit
        int clubs = 6; 
        int hearts = 3;
        int diamonds = 4;
        int spades = 5;

        for (int i = 2; i < 15; i++)
        {
            if (i > 1 && i < 11)
            {
                Console.WriteLine("{0}" + (char)clubs + " {0}" + (char)hearts + " {0}" + (char)diamonds + " {0}" + (char)spades, i);
            }
            else
            {
                for (int j = i; j < i +1; j++)
                {
                    switch (i)
                    {
                        case 11: Console.WriteLine("J" + (char)clubs + " J" + (char)hearts + " J" + (char)diamonds + " J" + (char)spades); continue;
                        case 12: Console.WriteLine("Q" + (char)clubs + " Q" + (char)hearts + " Q" + (char)diamonds + " Q" + (char)spades); continue;
                        case 13: Console.WriteLine("K" + (char)clubs + " K" + (char)hearts + " K" + (char)diamonds + " K" + (char)spades); continue;
                        case 14: Console.WriteLine("A" + (char)clubs + " A" + (char)hearts + " A" + (char)diamonds + " A" + (char)spades); continue;
                    }
                }
            }
        }
    }
}

