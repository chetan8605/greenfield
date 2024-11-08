using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxation
{
    public static class Tax

    {

        //fuction with no implemetation and object oriented function pointer 
        public static void PayIncomeTax(float factor)
        {
            Console.WriteLine("Income Tax" + factor + "  is Dedeucted from your account!");
        }
        public static void PayProfessinalTax(float factor) { Console.WriteLine("Professional " + factor + "Tax Deducted"); }
        public static void PayServiceTax(float factor) { Console.WriteLine("Service " + factor + " Tax Deducted"); }
        public static void PayGST(float factor) { Console.WriteLine("GST" + factor + " DEDUCTED"); }
    }
}
