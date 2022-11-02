package Q2_pkg;
import java.util.Scanner;

public class MIS_3b {
    private String course;
    private int a=0, b=0, c=0, d=0,f=0;
    public MIS_3b(String course)
    {
        this.course = course;
    }
    public void doGrades()
    {
        Scanner sc = new Scanner(System.in);
        int score;
        System.out.println("Input your score, enter ctrl^z to stop: ");
//        NetBean problem: can not stop entering data, use while(!sc.hasNext("#")) to solve.
        while (sc.hasNext())
        {
            score = sc.nextInt();
            switch (score / 10)
            {
                case 10:
                case 9:
                    a+=1;
                    break;
                case 8:
                    b+=1;
                    break;
                case 7:
                    c+=1;
                    break;
                case 6:
                    d+=1;
                    break;
                default:
                    f+=1;
                    break;
            }
        }        
    }
    public void displayGrades()
    {
        System.out.println("Course : " + course + "\nGrade A : " + a + "\nGrade B : " + b + "\nGrade C : " + c + "\nGrade D : " + d + "\nGrade F : " + f);
    }
}