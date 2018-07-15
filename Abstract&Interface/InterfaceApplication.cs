using System;
using System.Collections.Generic;
using System.Text;

namespace Abtstraction
{
    interface ITransaction
    {
        void showTransaction();
        double getAmount();
    }
    class Transaction : ITransaction
    {
        public string tCode;
        public string date;
        public double amount;
        public Transaction()
        {
            tCode = "";
            date = "";
            amount = 0.0;
        }
        public Transaction(string Ic, string date, double amount)
        {
            this.tCode = Ic;
            this.date = date;
            this.amount = amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction : " + tCode);
            Console.WriteLine("Date  : " + date);
            Console.WriteLine("Amount : " + getAmount());
        }

        public double getAmount()
        {
            return amount;
        }
    }
    class InterfaceApplication
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("011", "11/12/2014", 78333.32);
            Transaction t2 = new Transaction("012", "31/07/2018", 39222.23);
            t1.showTransaction();
            Console.WriteLine();
            t2.showTransaction();
            Console.Read();
        }
    }
}