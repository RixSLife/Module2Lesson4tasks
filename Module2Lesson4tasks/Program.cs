using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Module2Lesson4tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie nr 1
            //Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.Dane które chcesz przetrzymywać to:
            //a.Imię,
            //b.Nazwisko
            //c.Wiek
            //d.Płeć(‘m’ albo ‘k’)
            //e.PESEL
            //f.Numer pracownika(np. 2509324094)
            //Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje
            string Name = "Robert";
            string Surname = "Kowalski";
            int Age = 42;
            string Gender = "Male";
            string PESEL = "81050519756"; //jako string poniewaz nie bedzie uzywane do obliczen
            string EmployeeId = "12345";  //jako string poniewaz nie bedzie uzywane do obliczen
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(Age);
            Console.WriteLine(Gender);
            Console.WriteLine(PESEL);
            Console.WriteLine(EmployeeId);
            Console.WriteLine("");

            //Zadanie nr 2
            //Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.
            Console.WriteLine("Zadanie nr 2");

            int x = 10;
            int y = 20;
            int z = 30;

            Console.WriteLine("");
            Console.WriteLine($" {z} \r\n {y} \r\n {x}");
            Console.WriteLine("");

            //Zadanie nr 3
            //Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej.
            //(Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
            Console.WriteLine("");
            Console.WriteLine("Zadanie nr 3");

            Console.WriteLine("Do obliczenia przekatnejbedziemy potrzebowac");
            Console.WriteLine("dlugosci bokow prostokata.");
            Console.WriteLine("");

            Console.WriteLine("Podaj dlugosc boku A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Podaj dlugosc boku B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Dlugosc przekatnej wynosi: " + c);
            Console.WriteLine("");

            //Zadanie nr 4
            //Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie przypiszesz im następujące wartości:
            //a. 10
            //b.Szkoła Dotneta
            //c. 12,5
            //Pamiętaj o użyciu poprawnych typów danych.
            Console.WriteLine("");
            Console.WriteLine("Zadanie nr 4");
            int d = 10;
            string e = "Szkola Dotneta";
            double f = 12.5;
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            //Zadanie nr 5
            //Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko, numer telefonu, adres email, wzrost, waga(np. 85, 7), itp
            //(postaraj się wymyślić jak najwięcej)
            //i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody: typDanych.Parse(odpowiedźOdUżytkownika).
            Console.WriteLine("Prosze podac Twoje dane personalne");
            Console.WriteLine("Imie: ");
            string Imie = Console.ReadLine();
            Imie = Imie.ToUpper();

            Console.WriteLine("Nazwisko: ");
            string Nazwisko = Console.ReadLine();
            Nazwisko = Nazwisko.ToUpper();

            Console.WriteLine("Nr. telefonu: ");
            string Phone = Console.ReadLine();

            Console.WriteLine("Adres email: ");
            string Email = Console.ReadLine();
            Email = Email.ToLower();

            Console.WriteLine("Wzrost: (cm) ");
            double Height = double.Parse(Console.ReadLine());

            Console.WriteLine("Waga: (kg) ");
            double Weight = double.Parse(Console.ReadLine());

            Console.WriteLine("\nWprowadziles dane: ");
            Console.WriteLine("Imie: " + Imie);
            Console.WriteLine("Nazwisko: " + Nazwisko);
            Console.WriteLine("Telefon: " + Phone);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Wzrost: " + Height + "cm");
            Console.WriteLine("Waga: " + Weight + "kg");


            Console.ReadKey();


        }
    }
}
