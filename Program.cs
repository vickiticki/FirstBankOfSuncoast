using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        //Amount:
        public int TransactionAmount { get; set; }
        //AccountType:
        public string AccountType { get; set; }
        //TransactionType:
        public string TransactionType { get; set; }


    }
    class TransactionDatabase
    {
        // Transaction list (class)

        private List<Transaction> transactions = new List<Transaction>();

        // Get input from user and add to list
        // (save to csv)

        // THIS PART MIGHT MOVE
        // Method to calculate savings 
        // Initial balance = 0
        // For each deposit add money to balance
        // For each withdrawal subtract money from balance
        // Method to calculate checking
        // Initial balance = 0
        // For each deposit add money to balance
        // For each withdrawal subtract money from balance


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the First Bank of Suncoast");

            var keepGoing = true;

            while (keepGoing)
            {
                // Display menu with options:
                Console.WriteLine();
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("(D)eposit   (W)ithdrawal   (V)iew Balance   (Q)uit");
                var response = Console.ReadLine().ToUpper();
                Console.WriteLine();

                switch (response)
                {
                    // Quit
                    case "Q":
                        Console.WriteLine("Thank you. Please come again.");
                        keepGoing = false;
                        break;

                    // Deposit
                    case "D":

                        Console.WriteLine("Would you like to deposit in (C)hecking or (S)avings? E(X)it");
                        var depositAccount = Console.ReadLine().ToUpper();

                        switch (depositAccount)
                        {
                            //Deposit to checking
                            case "C":
                                // Ask for amount 
                                Console.WriteLine();
                                Console.WriteLine("How much would you like to deposit?");
                                // Send to transaction list 
                                // (display new checking balance?)
                                break;
                            // Deposit to savings
                            case "S":
                                Console.WriteLine();
                                Console.WriteLine("How much would you like to withdraw?");
                                // Ask for amount 
                                // Send to transaction list
                                // (display new savings balance?)
                                break;
                            case "X":
                                break;
                            default:
                                Console.WriteLine("Error. Please try again.");
                                break;
                        }

                        break;

                    // Withdrawal
                    case "W":

                        Console.WriteLine("Will you like to withdraw from (C)hecking or (S)avings? E(X)it");
                        var withdrawAccount = Console.ReadLine().ToUpper();
                        // Withdraw from checking
                        // Get checking balance
                        // Ask for amount 
                        // If more than balance, display error message
                        // If ok, send to transaction list
                        // (display new checking balance?)

                        // Withdraw from savings
                        // Get savings balance
                        // Ask for amount
                        // If more than balance, display error message
                        // If ok, send to transaction list
                        // (display new savings balance?)
                        break;

                    // View balance of both
                    case "V":

                        // Get checking balance
                        // Get savings balance

                        // Display both
                        Console.WriteLine($"You have __ in your checking and __ in your savings.");

                        break;

                    default:
                        Console.WriteLine("Error. Please try again.");
                        break;
                }

            }

        }
    }
}
