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
            string path = Path;
            if(File.Exists(path))
            {
                using(StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(File.);
                }
            }
            else
            {
                Exists();
            }
            File.AppendText(path);
        }
        public void View()
        {

        }
        public void Categorize()
        {

        }
        public string Path = "Transaction.json";

        public bool Exists()
        {
            string path = Path;
            File.Create(path);
            return true;
        }


    }
}