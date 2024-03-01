using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;

namespace PersonalFinanceTracker_1
{
    public class FinanceTracker : IFinance
    {

        public void Add()
        {
            List < Transaction > transactions = new List<Transaction>{
                new(
                id: Guid.NewGuid(),
                date: DateTime.Parse("2024-02-26"),
                description: "Shop",
                amount: 120M,
                category: "Groceries"
                )
            };
            
          string jsonString = JsonSerializer.Serialize(transactions);
          Console.WriteLine(jsonString);
          File.WriteAllText("Transaction.json",jsonString);
        }
        public void View()
        {

        }
        public void Categorize()
        {

        }
        public string Path = "Transaction.json";

    }
}