namespace emulator_intel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string in1, in2, in3, in4, in5, in6, in7, in8;
            in1 = "  ";
            in2 = "  ";
            in3 = "  ";
            in4 = "  ";
            in5 = "  ";
            in6 = "  ";
            in7 = "  ";
            in8 = "  ";

            InterfejsWitam(in1, in2, in3, in4, in5, in6, in7, in8);

        }
        public static void InterfejsWitam(string in1, string in2, string in3, string in4, string in5, string in6, string in7, string in8)
        {
            string Wiad1, Wiad2, Wiad3, Wiad4, Wiad5, Wiad6, Wiad7, Wiad8, Okno1, Okno2, Okno3, Okno4, Okno5, Okno6, Okno7, Okno8;
            Wiad1 = "INPUT FIELDS YOU'D LIKE TO PERFORM AN ACTION ON";
            Wiad2 = "FIELD.1: ";
            Wiad3 = "FIELD.2: ";
            Wiad4 = "PLEASE ENTER VALUE INTO FIELD 1";
            Wiad5 = "PLEASE ENTER VALUE INTO FIELD 2";
            Wiad6 = "MOVE ";
            Wiad7 = "XCHG ";
            Wiad8 = "NEG";
            Okno1 = "|AL|";
            Okno2 = "|AH|";
            Okno3 = "|BL|";
            Okno4 = "|BH|";
            Okno5 = "|CL|";
            Okno6 = "|CH|";
            Okno7 = "|DL|";
            Okno8 = "|DH|";

            char pomoc, bok;
            string zapychacz, zapychacz1, zapychacz2, zapychacz3, zapychacz4, zapychacz5, zapychacz6, zapychacz7, zapychacz8;
            pomoc = ' ';
            bok = '*';
            zapychacz = "  ";
            zapychacz1 = "  ";
            zapychacz2 = "  ";
            zapychacz3 = "  ";
            zapychacz4 = "  ";
            zapychacz5 = "  ";
            zapychacz6 = "  ";
            zapychacz7 = "  ";
            zapychacz8 = "  ";
            var baza = new String('*', 103);
            var dlugoscLinia = new String(' ', 88);
            var dlLin = dlugoscLinia.Length / 2;
            var dlugoscWiad1 = new String(' ', dlLin - Wiad1.Length / 2 + 2);
            var dlugoscWiad2 = new String(' ', dlLin - Wiad2.Length / 2 + 2);
            var dlugoscWiad3 = new String(' ', dlLin - Wiad3.Length / 2);
            var dlugoscWiad4 = new String(' ', dlLin - Wiad4.Length / 2);
            var dlugoscWiad5 = new String(' ', dlLin - Wiad5.Length / 2);
            var dlugoscWiad6 = new String(' ', dlLin - Wiad6.Length / 2);
            var dlugoscWiad7 = new String(' ', dlLin - Wiad7.Length / 2);
            var dlugoscWiad8 = new String(' ', dlLin - Wiad8.Length / 2);
            var dlugoscPusto = new String(' ', 88 - 2 * Okno2.Length + 9);

            string pusto, wall, wall1, wall2, wall11, wall12, wall13, wall14, wall15, wall16, wall17, wall18,
            wall21, wall22, wall23, wall24, wall25, wall26, wall27, wall28, pustoOkno;

            pusto = dlugoscLinia + pomoc + zapychacz1 + zapychacz1;
            pustoOkno = dlugoscLinia;
            wall1 = bok + zapychacz + zapychacz;
            wall2 = zapychacz + zapychacz + bok;
            wall11 = bok + zapychacz1;
            wall12 = bok + zapychacz2;
            wall13 = bok + zapychacz3;
            wall14 = bok + zapychacz4;
            wall15 = bok + zapychacz5;
            wall16 = bok + zapychacz6;
            wall17 = bok + zapychacz7;
            wall18 = bok + zapychacz8;
            wall21 = in1 + bok;
            wall22 = in2 + bok;
            wall23 = in3 + bok;
            wall24 = in4 + bok;
            wall25 = in5 + bok;
            wall26 = in6 + bok;
            wall27 = in7 + bok;
            wall28 = in8 + bok;

            Console.WriteLine(baza);
            Console.WriteLine(wall1 + pusto + wall2);
            Console.WriteLine(wall1 + dlugoscWiad1 + Wiad1 + dlugoscWiad1 + wall2);
            Console.WriteLine(wall1 + pusto + wall2);
            Console.WriteLine(wall1 + dlugoscWiad2 + Wiad2 + dlugoscWiad2 + wall2);
            Console.WriteLine(wall11 + Okno1 + dlugoscWiad3 + Wiad3 + dlugoscWiad3 + Okno1 + wall21);
            Console.WriteLine(wall12 + Okno2 + dlugoscPusto + Okno2 + wall22);
            Console.WriteLine(wall13 + Okno3 + dlugoscWiad4 + Wiad4 + dlugoscWiad4 + Okno3 + wall23);
            Console.WriteLine(wall14 + Okno4 + dlugoscWiad5 + Wiad5 + dlugoscWiad5 + Okno5 + wall24);
            Console.WriteLine(wall15 + Okno5 + dlugoscPusto + Okno5 + wall25);
            Console.WriteLine(wall16 + Okno6 + dlugoscWiad6 + Wiad6 + dlugoscWiad6 + Okno6 + wall26);
            Console.WriteLine(wall17 + Okno7 + dlugoscWiad7 + Wiad7 + dlugoscWiad7 + Okno7 + wall27);
            Console.WriteLine(wall18 + Okno8 + dlugoscWiad8 + Wiad8 + dlugoscWiad8 + Okno8 + wall28);
            Console.WriteLine(wall1 + pusto + wall2);
            Console.WriteLine(baza);

        }
    }
}  