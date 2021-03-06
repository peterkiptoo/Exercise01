using System;
using System.Collections.Generic;

namespace Exercise01
{
    public class BigIntExtenderLibrary
    {
        
            private static String[] units = { "Zero", "One", "Two", "Three",
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
    "Seventeen", "Eighteen", "Nineteen" };
            private static String[] tens = { "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        

        public static String Towards(double amount)
            {
                try
                {
                    Int64 amount_int = (Int64)amount;
                    Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);
                    if (amount_dec == 0)
                    {
                        return Convert(amount_int) + " ";
                    }
                    else
                    {
                        return Convert(amount_int) + " Point " + Convert(amount_dec) + " ";
                    }
                }
                catch (Exception ex)
                {
                    // handle exception
                    Console.WriteLine(ex.Message);
                }
                return "";
            }

            public static String Convert(Int64 i)
            {
                if (i < 20)
                {
                    return units[i];
                }
                if (i < 100)
                {
                    return tens[i / 10] + ((i % 10 > 0) ? " " + Convert(i % 10) : "");
                }
                if (i < 1000)
                {
                    return units[i / 100] + " Hundred"
                            + ((i % 100 > 0) ? " And " + Convert(i % 100) : "");
                }
                if (i < 1000000)
                {
                    return Convert(i / 1000) + " Thousand "
                    + ((i % 1000 > 0) ? " " + Convert(i % 1000) : "");
                }
                if (i < 1000000000)
                {
                    return Convert(i / 1000000) + " Million "
                            + ((i % 1000000 > 0) ? " " + Convert(i % 1000000) : "");
                }
                if (i < 1000000000000)
                {
                    return Convert(i / 1000000000) + " Billion "
                            + ((i % 1000000000 > 0) ? " " + Convert(i % 1000000000) : "");
                }
                if (i < 1000000000000000)
                {
                    return Convert(i / 1000000000000) + " Trillion "
                        + ((i % 1000000000000 > 0) ? " " + Convert(i % 1000000000000) : "");
                }
                if (i < 1000000000000000000)
                {
                    return Convert(i / 1000000000000000) + " Quadrillion "
                       + ((i % 1000000000000000 > 0) ? " " + Convert(i % 1000000000000000) : "");
                }
               
                    return Convert(i / 1000000000000000000) + " Quintillion "
                     + ((i % 1000000000000000000 > 0) ? " " + Convert(i % 1000000000000000000) : "");
                
            }
        }

    
}
