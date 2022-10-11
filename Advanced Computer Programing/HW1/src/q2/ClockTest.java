package q2;

import java.util.Scanner;

//Execcise 3.14

public class ClockTest {
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("Input hour, minute and second in sequence: ");
        int hour = sc.nextInt();
        int minute = sc.nextInt();
        int second = sc.nextInt();
        Clock ct = new Clock(hour, minute, second);
        ct.displayTime();
    }
}