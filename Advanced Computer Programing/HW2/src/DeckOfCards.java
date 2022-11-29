/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author USER
 */
import java.security.SecureRandom;

public class DeckOfCards {
    private int currentCard;
    private static final int NUMBER_OF_CARDS = 52;
    private Card[] deck = new Card[NUMBER_OF_CARDS]; //Can't use private Card[] deck; deck = new Card[NUMBER_OF_CARDS], it would couse error
    private static final SecureRandom rn = new SecureRandom();

    public DeckOfCards()
    {
        int faces[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
        String suits[] = {"Hearts", "Diamonds", "Clubs", "Spades"};
        for (int i = 0; i < deck.length; i++)
        {
            deck[i] = new Card(faces[i % 13], suits[i / 13]);
        }
    }
    public void shuffle()
    {
        currentCard = 0;
        for (int first = 0; first < deck.length; first++)
        {
            int sec = rn.nextInt(NUMBER_OF_CARDS);
            Card temp = deck[first];
            deck[first] = deck[sec];
            deck[sec] = temp;
        }
    }
    public Card dealCard()
    {
        if (currentCard < deck.length)
        {
            return deck[currentCard++];
        } else {
            return null;
        }
    }
    public int count6()
    {
        int count = 0;
        for (int i = 1; i <= 20; i++)
        {
            if (deck[i-1].getFace() == 6)
            {
                count++;
            }
        }
        return count;
    }
}