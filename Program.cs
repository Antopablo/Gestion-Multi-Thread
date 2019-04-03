using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Exo5thread
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Joueur> ListeJoueur = new List<Joueur>();
            List<Thread> ListeThread = new List<Thread>();

            Joueur j1 = new Joueur("Nico");
            Joueur j2 = new Joueur("Alexis");
            Joueur j3 = new Joueur("Anto");
            Joueur j4 =new Joueur("Frank");

            ListeJoueur.Add(j1);
            ListeJoueur.Add(j2);
            ListeJoueur.Add(j3);
            ListeJoueur.Add(j4);

            Thread th = new Thread(ListeJoueur[0].Run);
            Thread th2 = new Thread(ListeJoueur[1].Run);
            Thread th3 = new Thread(ListeJoueur[2].Run);
            Thread th4 = new Thread(ListeJoueur[3].Run);

            th.Start();
            th2.Start();
            th3.Start();
            th4.Start();

            th.Join();
            th2.Join();
            th3.Join();
            th4.Join();

       
        }
    }
}
