using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Car
    {
        StringBuilder sb = new StringBuilder();
        string[] Cars = new string[5];
        public Car(int price, int km, int rok, string mesto, int pocetDveri, bool havarovane, Znacka znacka, Typ typ, Palivo palivo)
        {
            Price = price;
            Km = km;
            Rok = rok;
            Mesto = mesto;
            PocetDveri = pocetDveri;
            Havarovane = havarovane;
        }


        public int Id { get; set; }
        public int Price { get; set; }
        public int Km { get; set; }
        public int Rok { get; set; }
        public string Mesto { get; set; }
        public int PocetDveri { get; set; }
        public bool Havarovane { get; set; }
        public Znacka znacka { get; set; }
        public Typ typ { get; set; }
        public Palivo palivo { get; set; }

        public enum Znacka 
        {
            Skoda, Volkswagen, Seat, Nisan, Peugeot, Porsche, BMW, Audi, Mercedes,
        }

        public enum Typ
        {
            Fabia, Octavia, Superb, Golf, Passat, Bora, Almera, Cupra, N350z, Skyline, P206, P307, P406, Panamera, Cayene, M3, M5, A4, A5, E, G,
        }

        public enum Palivo
        {
            Diesel, Benzin,
        }

        public string DescribeMe()
        {
            //cena, km, rok, mesto, pocetDveri, havarovaneBool, znacka, typ, palivo
            //sb.Append($"{Id}");
            //sb.AppendLine("Cena\tKilometre\tRok\tMesto\tPocet Dveri\tHavarovane\tZnacka\tTyp\tPalivo");
            sb.Append($"{Price}\t");
            sb.Append($"{Km}\t");
            sb.Append($"{Rok}\t");
            sb.Append($"{Mesto}\t");
            sb.Append($"{PocetDveri}\t");
            sb.Append($"{Havarovane}\t");
            sb.Append($"{znacka}\t");
            sb.Append($"{typ}\t");
            sb.Append($"{palivo}\t");

            Console.ReadLine();
            return sb.ToString();
        }
      

        

        

    }
}
