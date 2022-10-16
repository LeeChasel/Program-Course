package Q3_pkg;

import java.util.Scanner;

public class MIS_3B {
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("Input three integers: ");
        int x = sc.nextInt();
        int y = sc.nextInt();
        int z = sc.nextInt();
        System.out.println("The maximum between " + x + ", " + y + " and " + z + " is: " + max(x, y, z));
    }
    public static int max(int x, int y, int z)
    {
        int max = x;
        if (y > max)
        {
            max = y;
        }
        if (z > max)
        {
            max = z;
        }
        return max;
    }
}
