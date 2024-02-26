using System.Security.Cryptography.X509Certificates;
using PersonalFinanceTracker_1;

namespace Pft
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to your Personal Finance TRacker, shorter PFT.");
                Console.WriteLine("1. Add Transaction.");
                Console.WriteLine("2. View Transaction.");
                Console.WriteLine("3. Financial Summary.");
                Console.WriteLine("4. Exit.");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                    FinanceTracker financeTracker = new FinanceTracker();
                    financeTracker.Add();
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        exit = true;
                        break;

                }

            }
        }
    }
}