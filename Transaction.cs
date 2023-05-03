using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Static_Class__Methods__and_Constructor
{
    internal class Transaction
    {
        DateTime _now = DateTime.Now;
        string _name;
        double _amount;

        public Transaction(string name, double amount)
        {
            _name = name;
            _amount = amount;
        }

        public string Name { get { return _name; } }
        public double Amount { get { return _amount;} }
        public override string ToString()
        {
            return $"{BusinessInfo.BusinessName} - {DateTime.Now} - {Name} - {Amount.ToString("c")}";
        }


    }
}
