/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author USER
 */
public class HW2 {
    public static void main(String[] args)
    {
        DeckOfCards doc = new DeckOfCards();
        doc.shuffle();
        for (int i = 1; i <= 52; i++)
        {
            System.out.printf("%-19s", doc.dealCard());
            if (i % 4 == 0)
            {
                System.out.println();
            }
        }
        System.out.printf("\nThe number of 6 face in the first 20 cards: %d\n", doc.count6());
    }
}