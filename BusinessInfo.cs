using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Static_Class__Methods__and_Constructor
{
    internal class BusinessInfo
    {
        static string _businessName;
        static double _taxAmount;

        static BusinessInfo() {
            _businessName = "Big Baller Brand";

            _taxAmount = 0.1;
        
        }
        
        public static string BusinessName { get { return _businessName; } set { _businessName = value; } }
        public static double TaxAmount { get { return _taxAmount; } set { _taxAmount = value; } }




    }




}
