package Q1_pkg;

import java.util.Scanner;

public class Student {
    private String name;
    private int scores_num;
    private double avg;
    public Student(String name, int scores_num)
    {
        this.name = name;
        this.scores_num = scores_num;
    }
    public void CalAverage()
    {
        System.out.print("Input " + name + "'s scores: ");
        Scanner sc = new Scanner(System.in);
        double sum = 0;
        for (int i = 1; i<= scores_num; i++)
        {
            sum += sc.nextInt();
        }
        avg = sum / scores_num;
    }
    public void PrintAverage()
    {
        System.out.println(name + "'s average score is: " + avg);
    }
}
