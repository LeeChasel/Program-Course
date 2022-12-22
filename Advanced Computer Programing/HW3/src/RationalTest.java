/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author USER
 */
public class RationalTest {
    public static void main(String[] args)
    {
        Rational r1 = new Rational(4,6);
        Rational r2 = new Rational(1,4);
        Rational addR = add(r1, r2);
        Rational subtractR = subtract(r1, r2);
        Rational multiplyR = multiply(r1, r2);
        Rational divideR = divide(r1, r2);
        
        System.out.println("---Add---");
        display(addR);
        System.out.println("---Subtract---");
        display(subtractR);
        System.out.println("---Multiply---");
        display(multiplyR);
        System.out.println("---Divide---");
        display(divideR);
    }

    public static Rational add(Rational r1, Rational r2)
    {
        int r1_n = r1.getNumerator();
        int r1_d = r1.getDenominator();
        int r2_n = r2.getNumerator();
        int r2_d = r2.getDenominator();
        int least_common_multiple = r2_d;
        if (r1_d != r2_d)
        {
            //輾轉相除法
            int m = r1_d;
            int n = r2_d;
            while (r1_d % r2_d != 0)
            {
                int tmp = r1_d % r2_d;
                r1_d = r2_d;
                r2_d = tmp;
            }
            least_common_multiple = m * n / r2_d; //end
            r1_n *= (least_common_multiple / r1.getDenominator());
            r2_n *= (least_common_multiple / r2.getDenominator());
        }
        return new Rational(r1_n + r2_n, least_common_multiple);
    }
    public static Rational subtract(Rational r1, Rational r2)
    {
        int r1_n = r1.getNumerator();
        int r1_d = r1.getDenominator();
        int r2_n = r2.getNumerator();
        int r2_d = r2.getDenominator();
        int least_common_multiple = r2_d;
        if (r1_d != r2_d)
        {
            //輾轉相除法
            int m = r1_d;
            int n = r2_d;
            while (r1_d % r2_d != 0)
            {
                int tmp = r1_d % r2_d;
                r1_d = r2_d;
                r2_d = tmp;
            }
            least_common_multiple = m * n / r2_d; //end
            r1_n *= (least_common_multiple / r1.getDenominator());
            r2_n *= (least_common_multiple / r2.getDenominator());
        }
        return new Rational(r1_n - r2_n, least_common_multiple);
    }
    public static Rational multiply(Rational r1, Rational r2)
    {
        int numerator = r1.getNumerator() * r2.getNumerator();
        int denominator = r1.getDenominator() * r2.getDenominator();
        return new Rational(numerator, denominator);
    }
    public static Rational divide(Rational r1, Rational r2)
    {
        int numerator = r1.getNumerator() * r2.getDenominator();
        int denominator = r1.getDenominator() * r2.getNumerator();
        return new Rational(numerator, denominator);
    }
    public static void print_with_form(Rational r)
    {
        System.out.printf("%s/%s\n", r.getNumerator(), r.getDenominator());
    }
    public static void print_with_float(Rational r)
    {
        float res = (float)r.getNumerator() / r.getDenominator();
        System.out.printf("%.3f\n", res);
    }
    public static void display(Rational r)
    {
        print_with_form(r);
        print_with_float(r);
    }
}