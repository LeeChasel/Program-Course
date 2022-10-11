package q1;
//Exercise 3.11
import java.util.Scanner;

public class AccountTest {
    public static void main(String[] args)
    {
        Account ac1 = new Account("Jane Green", 50.00);
        Account ac2 = new Account("John Blue", -7.53);
        System.out.printf("%s balance: $%.2f%n", ac1.getName(), ac1.getBalance());
        System.out.printf("%s balance: $%.2f%n%n", ac2.getName(), ac2.getBalance());
        
        Scanner sc = new Scanner(System.in);
        
        System.out.print("Enter deposit for account 1: ");
        double depositAmount = sc.nextDouble();
        System.out.printf("%nadding %.2f to account1's balance%n%n", depositAmount);
        ac1.deposit(depositAmount);
       
        System.out.printf("%s balance: $%.2f%n", ac1.getName(), ac1.getBalance());
        System.out.printf("%s balance: $%.2f%n%n", ac2.getName(), ac2.getBalance());
        System.out.println("----------------------------------");

        System.out.print("Enter deposit for account 2: ");
        depositAmount = sc.nextDouble();
        System.out.printf("%nadding %.2f to account2's balance%n%n", depositAmount);
        ac2.deposit(depositAmount);
        
        System.out.printf("%s balance: $%.2f%n", ac1.getName(), ac1.getBalance());
        System.out.printf("%s balance: $%.2f%n%n", ac2.getName(), ac2.getBalance());
        System.out.println("----------------------------------");
        
//        withdraw
        System.out.print("Enter withdraw for account 1: ");
        double withdrawM = sc.nextDouble();
        ac1.withdraw(withdrawM, "account1");

        System.out.printf("%s balance: $%.2f%n", ac1.getName(), ac1.getBalance());
        System.out.printf("%s balance: $%.2f%n%n", ac2.getName(), ac2.getBalance());
        System.out.println("----------------------------------");

        System.out.print("Enter withdraw for account 2: ");
        withdrawM = sc.nextDouble();
        ac2.withdraw(withdrawM, "account2");

        System.out.printf("%s balance: $%.2f%n", ac1.getName(), ac1.getBalance());
        System.out.printf("%s balance: $%.2f%n%n", ac2.getName(), ac2.getBalance());    
    }  
}