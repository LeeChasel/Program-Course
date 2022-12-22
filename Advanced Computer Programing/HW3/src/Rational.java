/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author USER
 */
public class Rational {
    private int numerator;
    private int denominator;
    public Rational()
    {
        this(1,1);
    }
    public Rational(int numerator, int denominator)
    {
        int small = ((numerator > denominator)? denominator: numerator);
        int highest_common_factor = 1;
        for (int i = 2; i <= small; i++)
        {
            if ((numerator % i == 0) && (denominator % i == 0))
            {
                highest_common_factor = i;
            }
        }
        this.numerator = numerator / highest_common_factor;
        this.denominator = denominator / highest_common_factor;
    }
    public int getNumerator()
    {
        return numerator;
    }
    public int getDenominator()
    {
        return denominator;
    }
}
