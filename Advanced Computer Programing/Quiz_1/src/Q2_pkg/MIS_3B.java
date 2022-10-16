package Q2_pkg;

import java.util.Scanner;

public class MIS_3B {
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("Input x and y: ");
        int x = sc.nextInt();
        int y = sc.nextInt();
        System.out.println(x + " ^ " + y + " = " + power(x, y));        
    }
    
    public static double power(int x, int y)
    {
        return Math.pow(x, y);
    }
}
