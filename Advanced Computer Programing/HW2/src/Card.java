/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author USER
 */
public class Card {
    private final int face;
    private final String suit;
    
    public Card(int cardFace, String cardSuit)
    {
        this.face = cardFace;
        this.suit = cardSuit;
    }
    public String toString()
    {
        return face + " " + suit;
    }
    public int getFace()
    {
        return face;
    }
}
