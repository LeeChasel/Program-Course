package Q1_pkg;

public class Q1 {
    public static void main(String[] args)
    {
        Student s1 = new Student("Owen", 3);
        Student s2 = new Student("Fiona", 4);
        
        s1.CalAverage();
        s2.CalAverage();
        
        s1.PrintAverage();
        s2.PrintAverage();       
    }   
}
