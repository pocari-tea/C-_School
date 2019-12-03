using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice14
{
    interface ITransactions
    {
        string ProductName { get; set; }
        DateTime TransactionDate { get; set; }
        int TransactionAmount { get; set; }

        void showTransaction();
    }

    class Transaction : ITransactions
    {
        private string p_name;
        private DateTime p_date;
        private int p_amount;

        public string ProductName { get { return p_name; } set { p_name = value; } }
        public DateTime TransactionDate { get { return p_date; } set { p_date = value; } }
        public int TransactionAmount { get { return p_amount; } set { p_amount = value; } }

        public void showTransaction()
        {
            Console.WriteLine($"ProductName : {p_name}");
            Console.WriteLine($"TransactionDate : {p_date}");
            Console.WriteLine($"TransactionAmount : {p_amount}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction()
            {
                ProductName = "노트북",
                TransactionAmount = 240

            };

            t1.showTransaction();

            Transaction t2 = new Transaction()
            {
                ProductName = "데스크톱",
                TransactionDate = new DateTime(2020, 3, 1),
                TransactionAmount = 80
            };
            t2.showTransaction();
        }
    }
}