package Q1_pkg;

public class Account {
    private String name;
    private int score1, score2;
    public Account(String name, int score1, int score2)
    {
        this.name = name;
        this.score1 = score1;
        this.score2 = score2;
    }
    public String getName()
    {
        return name;
    }
    public int sum()
    {
        return score1 + score2;
    }
}