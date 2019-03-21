using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Menu
    {
        Autobazar autobazar = new Autobazar();      

        public static void Option()
        {
            string choice = "";
            int choiceS = 0;
            bool test = true;
            int rok = 0;
            int km = 0;
            Car.Znacka znacka = 0;              //okrem 0 nic neberie, mozny zapis Car.Znacka.fabia napr, natvrdo  zadana hodnota
            Car.Typ typ = 0;
            Car.Palivo palivo = 0;
            int cena = 0;
            string mesto = "";
            int pocetDveri = 0;
            int havarovane = 0;
            bool havarovaneBool = false;

            while (test)
            {
                Console.Clear();
                Console.WriteLine("Vytvorenie Auta:");
                Console.WriteLine("Zmazanie Auta:");
                Console.WriteLine("Zmena informacii o aute:");
                Console.WriteLine("Zapis do suboru:");
                Console.WriteLine("Nacitanie zo suboru:");
                Console.WriteLine("Zadaj jednu z moznosti: ");
                choice = Console.ReadLine();

                test = false;
            }

            switch (choice)
            {
                case "1":
                    //if (Autobazar. < 5)
                    //{
                    //    Console.WriteLine("dosiahol si maximalny pocet aut");
                    //    Option();
                    //}
                    Console.WriteLine("Vytvorenie Auta: ");
                    Console.WriteLine("Zadaj: Rok vyroby");
                    rok = int.Parse(Console.ReadLine());
                    Console.WriteLine("Zadaj: km");
                    km = int.Parse(Console.ReadLine());
                    Console.WriteLine("Zadaj: Znacku Auta \n- 1: Skoda, \n2: Volkswagen, \n3: Seat, \n4: Nisan, \n5: Peugeot, \n6: Porsche, \n7: BMW, \n8: Audi, \n9: Mercedes");
                    //Skoda, Volkswagen, Seat, Nisan, Peugeot, Porsche, BMW, Audi, Mercedes,
                    //Fabia, Octavia, Superb, Golf, Passat, Bora, Almera, Cupra, N350z, Skyline, P206, P307, P406, Panamera, Cayene, M3, M5, A4, A5, E, G,
                    choiceS = int.Parse(Console.ReadLine());
                    switch (choiceS)
                    {
                        case 1:
                            znacka = Car.Znacka.Skoda;                                  //nejdu zadat hodnoty, musi sa to priradovat cez operator .
                            Console.WriteLine($"Pre znacku {znacka} su dostupne, tieto automobily: 1: Fabia, 2: Octavia, 3: Superb ");
                            choiceS = int.Parse(Console.ReadLine());
                            switch (choiceS)
                            {
                                case 1:
                                    typ = Car.Typ.Fabia;
                                    break;
                                case 2:
                                    typ = Car.Typ.Octavia;
                                    break;
                                case 3:
                                    typ = Car.Typ.Superb;
                                    break;
                            }
                            break;
                        case 2:
                            znacka = Car.Znacka.Volkswagen;
                            Console.WriteLine($"Pre znacku {znacka} su dostupne, tieto automobily: 1: Golf, 2: Passat, 3: Bora ");
                            choiceS = int.Parse(Console.ReadLine());
                            switch (choiceS)
                            {
                                case 1:
                                    typ = Car.Typ.Golf;
                                    break;
                                case 2:
                                    typ = Car.Typ.Passat;
                                    break;
                                case 3:
                                    typ = Car.Typ.Bora;
                                    break;
                            }
                            break;
                        case 3:
                            znacka = Car.Znacka.Seat; ;
                            Console.WriteLine($"Pre znacku {znacka} su dostupne, tieto automobily: 1: Almera, 2: Cupra");
                            choiceS = int.Parse(Console.ReadLine());
                            switch (choiceS)
                            {
                                case 1:
                                    typ = Car.Typ.Almera;
                                    break;
                                case 2:
                                    typ = Car.Typ.Cupra;
                                    break;
                            }
                            break;
                        case 4:
                            znacka = Car.Znacka.Nisan;
                            Console.WriteLine($"Pre znacku {znacka} su dostupne, tieto automobily: 1: N350z, 2: Skyline");
                            choiceS = int.Parse(Console.ReadLine());
                            switch (choiceS)
                            {
                                case 1:
                                    typ = Car.Typ.N350z;
                                    break;
                                case 2:
                                    typ = Car.Typ.Skyline;
                                    break;
                            }
                            break;
                        case 5:
                            znacka = Car.Znacka.Peugeot;
                            Console.WriteLine($"Pre znacku {znacka} su dostupne, tieto automobily: 1: P206, 2: P307, 3: P406 ");      //dôlezite, len cisla bez P!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                            choiceS = int.Parse(Console.ReadLine());
                            switch (choiceS)
                            {
                                case 1:
                                    typ = Car.Typ.P206;
                                    break;
                                case 2:
                                    typ = Car.Typ.P307;
                                    break;
                                case 3:
                                    typ = Car.Typ.P406;
                                    break;
                            }
                            break;
                        case 6:
                            znacka = Car.Znacka.Porsche;
                            Console.WriteLine($"Pre znacku {znacka} su dostupne, tieto automobily: 1: Panamera, 2: Cayene");
                            choiceS = int.Parse(Console.ReadLine());
                            switch (choiceS)
                            {
                                case 1:
                                    typ = Car.Typ.Panamera;
                                    break;
                                case 2:
                                    typ = Car.Typ.Cayene;
                                    break;
                            }
                            break;
                        case 7:
                            znacka = Car.Znacka.BMW;
                            Console.WriteLine($"Pre znacku {znacka} su dostupne, tieto automobily: 1: M3, 2: M5 ");
                            choiceS = int.Parse(Console.ReadLine());
                            switch (choiceS)
                            {
                                case 1:
                                    typ = Car.Typ.M3;
                                    break;
                                case 2:
                                    typ = Car.Typ.M5;
                                    break;
                            }
                            break;
                        case 8:
                            znacka = Car.Znacka.Audi;
                            Console.WriteLine($"Pre znacku {znacka} su dostupne, tieto automobily: 1: A4, 2: A5");
                            choiceS = int.Parse(Console.ReadLine());
                            switch (choiceS)
                            {
                                case 1:
                                    typ = Car.Typ.A4;
                                    break;
                                case 2:
                                    typ = Car.Typ.A5;
                                    break;
                            }
                            break;
                        case 9:
                            znacka = Car.Znacka.Mercedes;
                            Console.WriteLine($"Pre znacku {znacka} su dostupne, tieto automobily: 1: E, 2: G");
                            choiceS = int.Parse(Console.ReadLine());
                            switch (choiceS)
                            {
                                case 1:
                                    typ = Car.Typ.E;
                                    break;
                                case 2:
                                    typ = Car.Typ.G;
                                    break;
                            }
                            break;
                    }

                    Console.WriteLine("Zadaj: Palivo - 1. Benzin, 2. Diesel");
                    choiceS = int.Parse(Console.ReadLine()); ;
                    switch (choiceS)
                    {
                        case 1:
                            palivo = Car.Palivo.Benzin;
                            break;
                        case 2:
                            palivo = Car.Palivo.Diesel;
                            break;
                    }
                    
                    Console.WriteLine("Zadaj: Cena");
                    cena = int.Parse(Console.ReadLine());
                    Console.WriteLine("Zadaj: Mesto");
                    mesto = Console.ReadLine();
                    Console.WriteLine("Zadaj: PocetDveri");
                    pocetDveri = int.Parse(Console.ReadLine());
                    Console.WriteLine("Zadaj: Havarovane - 1. Havarovane, 2. Nehavarovane");
                    havarovane = int.Parse(Console.ReadLine());
                    if (havarovane == 1) havarovaneBool = true;
                    else havarovaneBool = false;

                    Autobazar.CreateCar(cena, km, rok, mesto, pocetDveri, havarovaneBool, znacka, typ, palivo);
                    break;
                case "2":
                    Console.WriteLine(" ");
                    Autobazar.DeleteCar();
                    break;
                case "3":
                    Console.WriteLine(" ");
                    Autobazar.ChangeInfo();
                    break;
                case "4":
                    Console.WriteLine(" ");
                    break;
            }
            Console.ReadLine();
        }

    }
}
