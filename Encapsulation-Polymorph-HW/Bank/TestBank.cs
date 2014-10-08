/*
    A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
    •	Customers could be individuals or companies.
    •	All accounts have customer, balance and interest rate (monthly based). 
    •	Deposit accounts are allowed to deposit and withdraw money. Loan and mortgage accounts can only deposit money.
    •	All accounts can calculate their interest for a given period (in months) using the formula
        A = money * (1 + interest rate * months) 
    •	Loan accounts have no interest for the first 3 months if held by individuals and for the first 2 months if
        held by a company.
    •	Deposit accounts have no interest if their balance is positive and less than 1000.
    •	Mortgage accounts have ½ interest for the first 12 months for companies and no interest for
        the first 6 months for individuals.
    
    Write a program to model the bank system with classes and interfaces. You should identify the classes,
    interfaces, base classes and abstract actions and implement the calculation of the interest functionality
    through overridden methods.Write a program to demonstrate that your classes work correctly.
*/

using System;
using Bank;

class TestBank
{
    static void Main(string[] args)
    {
        Customer facebook=new Customer("company");
        Customer Stephan=new Customer("individual");
            
        DepositAccount deposit = new DepositAccount(facebook, 1100, 3);
        deposit.Withdraw(400);
        Console.WriteLine(deposit.Balance); // 1100 - 400 = 700
        deposit.Deposit(500);
        Console.WriteLine(deposit.Balance); // 700 + 500 = 1200

        LoanAccount loan = new LoanAccount(Stephan, 2000, 2);
        loan.Deposit(1000);
        Console.WriteLine(loan.Interest(12)); // 2000 * (1 + (2 * 12)/100)

        MortgageAccount mortgage = new MortgageAccount(facebook, 1000, 10);
        Console.WriteLine(mortgage.Interest(13));
    }
}

