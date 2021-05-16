using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Vazlat
{
    //objektumból lista
    class listaclass
    {
        public string adat1;
        public int adat2;

        public listaclass(string adat1constructor, int adat2constructor)
        {
            adat1 = adat1constructor;
            adat2 = adat2constructor;
        }
    }
    class Program
    {
        //Lista generálás
        static List<listaclass> lista1 = new List<listaclass>();
        static List<int> lista2 = new List<int>();


        //Fügveny
        static string fugveny1(int valtozo1)
        {
            string valtozo2 = "true";
            return valtozo2;
        }

        static void eljaras1()
        {
            Console.WriteLine("eljaras1");
        }


        //Főprogram
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            fugveny1(1);
            eljaras1();

            //fáj beolvasás
            StreamReader sr = new StreamReader("szoveg.txt");
            string[] reszek;
            string sor;
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                reszek = sor.Split(" ");

                lista2.Add(Convert.ToInt32(reszek[0]));
                lista1.Add(new listaclass("nev", 12));

            }
            sr.Close;


            //Fügvények
            int szamol = lista2.Count();
            bool keres = lista2.Contains(3);
            int behiv = Convert.ToInt32(Console.ReadLine());

            //Változók
            int egesz = 1;
            string szoveg = "alma";
            float valós = 1/2;


            //izék
            int index1 = 0;
            foreach (var item in lista1)
            {
                index1++;
            }

            if (true == lista2.Contains(12))
            {
                Console.WriteLine("True");
            }

            for (int i = 0; i > lista2.Count(); i--)
            {
                Console.WriteLine(lista2[i]);
            }

            //String szerkesztése
            szoveg.Substring(1, 2);                   //másolás index szerint 0-tól.
            string szoveg1 = szoveg.Insert(2, ":");   //Beszúr
            string szoveg3 = szoveg + szoveg1;        //Összefűz
            szoveg1 = szoveg1.Remove(2, 3);           //Törlés
            
            //írás fáljba
            FileStream fs = new FileStream("szoveg2.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            StreamWriter ki = new StreamWriter("szoveg2.txt");
            ki.Write("Szasz");
            ki.WriteLine("Szasz2");

            ki.Flush();
            ki.Close();
            fs.Flush();
            fs.Close();
            sw.Flush();
            sw.Close();
        }
    }
}
