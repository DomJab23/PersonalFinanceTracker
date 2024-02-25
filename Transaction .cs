using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinanceTracker_1
{
    public class Transaction 
    {
        public Guid ID{get; set;} = Guid.NewGuid();

        public DateTime Date{get; set;}

        public string? Description{get; set;}

        public decimal Amount{get; set;}

        public string? Category{get; set;}

    }
}