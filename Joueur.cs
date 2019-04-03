using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Exo5thread
{
    class Joueur
    {
        public static readonly object _locker = new object();

        private  int _Point;
        public  int Point
        {
            get { return _Point; }
            set { _Point = value; }
        }

        public Joueur(string nom)
        {
            _Point = Point;
            _nom = nom;
        }

        private  string _nom;
        public  string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }


        public void Run()
        {
            while(Point <= 997)
            {
                lock (_locker)
                {
                    Console.WriteLine("\r\n"+Nom + " commence sont tour");
                    for (int i = 0; i < 3; i++)
                    {
                        int D = RandomMaison.Instance.Next(1, 7);
                        Point += D;
                        Console.WriteLine("Lancé " +(i+1)+ " = "+D);
                    }
                    Console.WriteLine("total du lancé de "+Nom+ " " + Point);
                    Thread.Sleep(50);
                }
            }
            Thread.Sleep(50);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Nom + " a gagné");
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }

    }
}
