using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapko_LabWork_2_0
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            bool boo = true;
            char ch = 'a';
            byte b = 1;
            sbyte sb = 100;
            short sh = -250;
            ushort ush = 250;
            int i = -223;
            uint ui = 300;
            long l = 100000;
            ulong ul = 100000;
            decimal de = 100000;
            float fl = -33.1F;
            double d0 = -33.1;

            //2) declare constants of int and double. Try to change their values.

            const int year = 2018;
            const double pi = 3.14;
            //year = 2019;

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            var var1 = 20;
            var var2 = 20.5;
            //var1 = 20.5;
            //var2 = 20;


            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?

            System.Int32 var3 = i;
            System.Double var4 = d0;

            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                //int i = 0;
                //char ch = 'a';
                //double d0 = 2.5;


                // 6) change values of variables from 1)

                i = 4;
                ch = 'j';
                d0 = 5.5;

            }

            // 7)check values of variables from 1). Are they changed? Think, why


            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).
            
            // int -> char
            //ch = i;
            ch = (char)i;
           
            // bool -> short
            //sh = boo;
            //sh = (short)boo;
            
            // double -> long
            //l = d0;
            l = (long)d0;
           
            // float -> char 
            //ch = fl;
            ch = (char)fl;

            // int to char
            //ch = i;
            ch = (char)i;

            // decimal -> double
            //d0 = de;
            d0 = (double)de;

            // byte -> uint
            ui = b;

            // ulong -> sbyte
            //sb = ul;
            sb = (sbyte)ul;

            // 9) and reverse conversion with fixing compilation errors.


            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?

        }
    }
}
