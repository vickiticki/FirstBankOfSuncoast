using System;
using System.Collections.Generic;

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

        private List<Transaction> transactions = new list<Transaction>();

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


            // Display menu with options:
            // Deposit to checking
            // Ask for amount 
            // Send to transaction list 
            // (display new checking balance?)
            // Deposit to savings
            // Ask for amount 
            // Send to transaction list
            // (display new savings balance?)
            // Withdraw from checking
            // Ask for amount 
            // If more than balance, display error message
            // If ok, send to transaction list
            // (display new checking balance?)
            // Withdraw from savings
            // Ask for amount
            // If more than balance, display error message
            // If ok, send to transaction list
            // (display new savings balance?)
            // View balance of both
            // Get checking balance
            // Get savings balance
            // Display both
            // Quit

        }
    }
}
