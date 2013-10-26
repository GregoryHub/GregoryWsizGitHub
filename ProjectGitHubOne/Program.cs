using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGitHubOne
{
    class Program
    {
        static void Main(string[] args)
        
          
        {
            Console.WriteLine("Dodawanie na liczbach całkowitych");
            Console.WriteLine("");
            Console.WriteLine("Podaj pierwszą liczbę i naciśnij enter");

            string pierwsza_zmienna = Console.ReadLine(); // określam rodzaj pierwszej zmiennej i czekam na podanie od użytkownika tej zmiennej
            int zamienna_na_int_pierwsza_zmienna = int.Parse(pierwsza_zmienna); // zamienia znaki na cyfry (string na int) za pomocą parsowania
            Console.WriteLine("Podaj drugą liczbę i naciśnij enter");
            string druga_zmienna = Console.ReadLine();
            int zamienna_na_int_druga_zmienna = int.Parse(druga_zmienna); // zamienia znaki na cyfry (string na int) za pomocą parsowania 
            if (zamienna_na_int_pierwsza_zmienna > zamienna_na_int_druga_zmienna)

                Console.WriteLine(zamienna_na_int_pierwsza_zmienna + " - " + zamienna_na_int_druga_zmienna + " = " + (zamienna_na_int_pierwsza_zmienna - zamienna_na_int_druga_zmienna));
            else if (zamienna_na_int_pierwsza_zmienna < zamienna_na_int_druga_zmienna)

                Console.WriteLine(zamienna_na_int_pierwsza_zmienna + " + " + zamienna_na_int_druga_zmienna + " = " + (zamienna_na_int_pierwsza_zmienna + zamienna_na_int_druga_zmienna));
            else
                Console.WriteLine("Obie liczby są równe więc wynik z odejmowania wyjdzie 0, a z dodawania razy 2");
            Console.ReadLine();

            
        }
    }
}
