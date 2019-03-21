using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Autobazar
    {

        static List<Car> Cars = new List<Car>();           //instancie zacinaju malym
        Menu Menu = new Menu();
        //string[] Cars = new string();
        



        public static void CreateCar(int price, int km, int rok, string mesto, int pocetDveri, bool havarovane, Car.Znacka znacka, Car.Typ typ, Car.Palivo palivo)
        {
            StringBuilder sb = new StringBuilder();
            Car car = new Car(price, km, rok, mesto, pocetDveri, havarovane, znacka, typ, palivo);
            Cars.Add(car);                 //do pola aut priradujem objekt auta                             //Cars[0] = car.DescribeMe();                 //ukladanie do indexu 0 v poli auta, metodu describe me, ktora mi vrati string a ten sa ulozi
            Console.WriteLine(Cars[0]);
            Console.ReadLine();
            ConsoleApp12.Menu.Option();
            
        }

        public void Id()
        {
            //nacitam subor, vezmem udaj z id a pripocitam +1
        }
       

        public static void DeleteCar()
        {

            Menu.Option();
        }

        public static void ChangeInfo()
        {

            Menu.Option();
        }
        
    }

}
