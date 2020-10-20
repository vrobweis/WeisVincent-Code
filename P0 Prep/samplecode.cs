using System;

class Start {


    public static boolean start() {
        if (checkAccountExistence()) {

        } else {

        }
        
    } 

    public static Boolean checkAccountExistence() {
        string ans;
        Console.WriteLine("Do you have an account?");
        Console.WriteLine("Y or N");
        ans = Console.ReadLine().ToLower();
        if (ans.StartsWith("n")) {
            Console.WriteLine("You responded that you have an account!");
            return true;
        }
        Console.WriteLine("No account? Let's fix that.");
        return false;
    }

    public static Boolean createAccount() {
        string ans;
        Console.WriteLine("Do you wish to make an account?");
        Console.WriteLine("Y or N");
        ans = Console.ReadLine().ToLower();
        if (ans.StartsWith("n")) {
            Console.WriteLine("You responded that you have an account!");
            return true;
        }
        Console.WriteLine("No account? Let's fix that.");
        return false;

    }
}