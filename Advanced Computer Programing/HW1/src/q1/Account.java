package q1;

public class Account {
    private String name;
    private double balance;
    
    public Account(String name, double balance)
    {
        setName(name);
        if (balance > 0.0)
        {
            this.balance = balance;
        }
    }
    public void deposit(double depositAmount)
    {
        if (depositAmount > 0.0)
        {
            balance += depositAmount;
        }
    }
    public double getBalance()
    {
        return balance;
    }
    public void setName(String name)
    {
        this.name = name;
    }
    public String getName()
    {
        return name;
    }
    public void withdraw(double money, String account)
    {
        if (money > balance)
        {
            System.out.println("withdraw amount exceed account balance!");
        } else {
            balance = balance - money;
            System.out.printf("%nwithdrawing %.2f to %s's balance%n%n", money, account);
        }
    }
}