using System;
using System.Collections.Generic;
using System.Globalization;

namespace Test1
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            int nemCserelt = 0;
            int cserelt = 0;

            for (int i = 1; i <= 1000000; i++)
            {
                Random rnd = new Random();

                int ajandek = rnd.Next(1, 4);
                int jatekosValaszt = rnd.Next(1, 4);
                int ajtoKinyit = rnd.Next(1, 4);

                

                while (ajtoKinyit == ajandek || ajtoKinyit == jatekosValaszt)
                {
                    ajtoKinyit = rnd.Next(1, 4);
                }
                Console.WriteLine("----------------");
                Console.WriteLine( i + ". Kor - Ajandek: " + ajandek + " Valaszt: " + jatekosValaszt + " Kinyitott: " + ajtoKinyit);
                //Console.WriteLine(" ---- " + " Ajandek: " + ajandek + " Valaszt: " + jatekosValaszt);

                if (ajandek == jatekosValaszt)
                {
                    Console.WriteLine("Nem cserelt");
                    nemCserelt++;
                }
                else
                {
                    Console.WriteLine("Cserelt");
                    cserelt++;
                }

                



                //Console.WriteLine(i +"--- Ajandekkal ajto : " + ajto_Ajandekkal + " Jatekos ajto: " + ajto_JatekosValaszt + " Ajto amit elvesz: " + ajto_AmitKinyit);
                //Console.WriteLine("---------------------------");
            }
            Console.WriteLine("_____________");

            Console.WriteLine( "Nem cserelt es NYERT: " + nemCserelt + " Cserelt en NYERT: " + cserelt);


            Console.ReadKey();

            //Console.WriteLine("Enter the amount : ");

            //double szam1 = Convert.ToDouble(Console.ReadLine());
            //double szam3;

            //for (int i = 0; i < 10; i++)
            //{
            //    double tempSzam = szam1;

            //    //tempSzam = Math.Truncate(tempSzam * 100) / 100;
            //    //tempSzam.ToString("0.##");

            //    Console.WriteLine( (i+1) + ". nap:  " + (tempSzam.ToString("0.##") ) );

            //    double szam2 = tempSzam * 1.05;
            //    szam1 = szam2;             

            //    //Console.WriteLine("Temp : "+tempSzam);
            //    //Console.WriteLine("Szam2 : " + szam2);                
            //}

            //Console.WriteLine(" Vegosszeg: " + szam1);





            /*
            string szovegInputString, szamInputString, doubleInputString;

            Console.WriteLine("Most ird be amit akarsz." );

            Console.WriteLine("\nSzoveg  : ");
            szovegInputString = Console.ReadLine();

            Console.WriteLine("\nSzam: ");
            szamInputString = Console.ReadLine();

            Console.WriteLine("\nDouble : ");
            doubleInputString = Console.ReadLine();


            try
            {
                int szamInt = Int32.Parse(szamInputString);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string is invalid.");
            }
            //int szovegInt = Int32.Parse(szovegInputString);

            double doubleDouble = Convert.ToDouble(doubleInputString);

            Console.WriteLine( "\nBeirt Szoveg : " + szovegInputString);
            Console.WriteLine( "\nBeirt szam : "   + szamInputString);
            Console.WriteLine( "\nBeirt double : " + doubleInputString);
            */


        }
    }
}
