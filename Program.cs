class Program
{
    static void Main()
    {
        //ex1();
        //ex2();
        //ex3();
        //ex4();
        //ex5();
        //ex6();
        //ex7();
        //ex8();
        //ex9();
        //ex10();


        static void ex2()
        {
            int numarDecimal = -27;

            // Obținem reprezentarea binară a magnitudinii (ignorăm bitul de semn)
            string magnitudineBinar = Convert.ToString(Math.Abs(numarDecimal), 2);

            // Completăm cu zerouri la stânga pentru a avea 8 biți (o dimensiune fixă)
            magnitudineBinar = magnitudineBinar.PadLeft(8, '0');

            // Obținem bitul de semn (0 pentru numere pozitive, 1 pentru numere negative)
            char semnBinar = numarDecimal < 0 ? '1' : '0';

            // Construim reprezentarea finală a numărului cu semn
            string numarBinarCuSemn = $"{semnBinar}{magnitudineBinar}";

            Console.WriteLine($"Numărul {numarDecimal} în binar cu semn și magnitudine este: {numarBinarCuSemn}");
        }
    }
    static void ex1()
    {
        int numarDecimal = 47;

        // Convertim numărul din baza 10 în binar fără semn
        string numarBinar = Convert.ToString(numarDecimal, 2);

        Console.WriteLine($"Numărul {numarDecimal} în binar fără semn este: {numarBinar}");
    }
    static void ex3()
    {
        string numarHexadecimal = "D5";

        // Convertim numărul din baza 16 în baza 10
        int numarDecimal = Convert.ToInt32(numarHexadecimal, 16);

        Console.WriteLine($"Numărul {numarHexadecimal} în baza 10 este: {numarDecimal}");
    }
    static void ex4()
    {
        string numarBinar = "10110.101";

        // Divizăm numărul binar în parte întreagă și parte zecimală
        string[] parti = numarBinar.Split('.');

        // Convertim partea întreagă din baza 2 în baza 10
        int parteIntreagaDecimal = Convert.ToInt32(parti[0], 2);

        // Convertim partea zecimală din baza 2 în baza 10
        double parteZecimalaDecimal = 0;
        for (int i = 0; i < parti[1].Length; i++)
        {
            parteZecimalaDecimal += double.Parse(parti[1][i].ToString()) * Math.Pow(2, -(i + 1));
        }

        // Calculăm rezultatul total
        double rezultatDecimal = parteIntreagaDecimal + parteZecimalaDecimal;

        Console.WriteLine($"Numărul {numarBinar} în baza 10 este: {rezultatDecimal}");
    }
    static void ex5()
    {
        double numarDecimal = 34.625;

        // Partea întreagă
        int parteIntreaga = (int)numarDecimal;
        string parteIntreagaBaza4 = ConvertToBase4(parteIntreaga);

        // Partea zecimală
        double parteZecimala = numarDecimal - parteIntreaga;
        string parteZecimalaBaza4 = ConvertDecimalToBase4(parteZecimala);

        // Construim rezultatul final
        string rezultatBaza4 = parteIntreagaBaza4 + "." + parteZecimalaBaza4;

        Console.WriteLine($"Numărul {numarDecimal} în baza 4 este: {rezultatBaza4}");
    }

    // Funcție pentru conversia parte întreagă în baza 4
    static string ConvertToBase4(int numar)
    {
        return Convert.ToString(numar, 4);
    }

    // Funcție pentru conversia parte zecimală în baza 4
    static string ConvertDecimalToBase4(double numar)
    {
        const int numarZecimale = 8; // Numărul de zecimale pentru precizie
        string rezultat = "";

        for (int i = 0; i < numarZecimale; i++)
        {
            numar *= 4;
            int cifra = (int)numar;
            rezultat += cifra;
            numar -= cifra;
        }

        return rezultat;
    }
    static void ex6()
    {
        string numarBinar = "011011";

        // Convertim numărul din baza 2 în baza 10
        int numarDecimal = Convert.ToInt32(numarBinar, 2);

        Console.WriteLine($"Numărul {numarBinar} în baza 10 este: {numarDecimal}");
    }
    static void ex7()
    {
        int numarIntreg = -27;
        int exces = 32;

        // Adăugăm exces la valoarea absolută a numărului
        int numarCuExces = Math.Abs(numarIntreg) + exces;

        // Convertim rezultatul în binar
        string numarBinar = Convert.ToString(numarCuExces, 2);

        Console.WriteLine($"Numărul {numarIntreg} în binar cu exces {exces} este: {numarBinar}");
    }
    static void ex8()
    {
        string numarBinar = "011011";

        // Convertim numărul din binar în baza 16
        string numarHexadecimal = Convert.ToString(Convert.ToInt32(numarBinar, 2), 16);

        Console.WriteLine($"Numărul {numarBinar} în baza 16 este: {numarHexadecimal}");
    }
    static void ex9()
    {
        double numarDecimal = 55.875;

        // Partea întreagă
        int parteIntreaga = (int)numarDecimal;
        string parteIntreagaBinar = Convert.ToString(parteIntreaga, 2);

        // Partea zecimală
        double parteZecimala = numarDecimal - parteIntreaga;
        string parteZecimalaBinar = ConvertDecimalToBinary(parteZecimala);

        // Construim rezultatul final
        string rezultatBinar = parteIntreagaBinar + "." + parteZecimalaBinar;

        Console.WriteLine($"Numărul {numarDecimal} în binar fără semn este: {rezultatBinar}");
    }

    // Conversie parte zecimală în binar
    static string ConvertDecimalToBinary(double numar)
    {
        const int numarZecimale = 8; // Numărul de zecimale pentru precizie
        string rezultat = "";

        for (int i = 0; i < numarZecimale; i++)
        {
            numar *= 2;
            int cifra = (int)numar;
            rezultat += cifra;
            numar -= cifra;
        }

        return rezultat;
    }
    static void ex10()
    {
        string numarBaza4 = "132.2";

        // Separăm partea întreagă și partea zecimală
        string[] parti = numarBaza4.Split('.');

        // Convertim partea întreagă din baza 4 în baza 10
        int parteIntreagaBaza10 = Convert.ToInt32(parti[0], 4);

        // Convertim partea zecimală din baza 4 în baza 10
        double parteZecimalaBaza10 = ConvertFractionalPartToBase10(parti[1], 4);

        // Convertim rezultatele în baza 16
        string parteIntreagaBaza16 = Convert.ToString(parteIntreagaBaza10, 16);
        string parteZecimalaBaza16 = ConvertFractionalPartToBase16(parteZecimalaBaza10);

        // Construim rezultatul final
        string rezultatBaza16 = parteIntreagaBaza16 + "." + parteZecimalaBaza16;

        Console.WriteLine($"Numărul {numarBaza4} în baza 16 este: {rezultatBaza16.ToUpper()}");
    }

    // Conversie parte zecimală în baza 10
    static double ConvertFractionalPartToBase10(string parteZecimala, int baza)
    {
        double rezultat = 0;

        for (int i = 0; i < parteZecimala.Length; i++)
        {
            int cifra = int.Parse(parteZecimala[i].ToString());
            rezultat += cifra * Math.Pow(baza, -(i + 1));
        }

        return rezultat;
    }

    // Conversie parte zecimală în baza 16
    static string ConvertFractionalPartToBase16(double parteZecimala)
    {
        const int numarZecimale = 8; // Numărul de zecimale pentru precizie
        string rezultat = "";

        for (int i = 0; i < numarZecimale; i++)
        {
            parteZecimala *= 16;
            int cifra = (int)parteZecimala;
            rezultat += cifra.ToString("X");
            parteZecimala -= cifra;
        }

        return rezultat;
    }
}
