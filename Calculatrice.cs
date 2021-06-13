using System;
using System.Runtime.CompilerServices;
using Calculatrice.Calcul;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Bienvenue-----");
            Console.WriteLine("Quel type de calcul voulez vous faire?");
            string t = Console.ReadLine();
            
            switch (t)
            {
                case "a":
                    Console.WriteLine("Test");
                    break;
                
                case "b":
                    Console.WriteLine("Quel type d'oppération voulez vous faire? ");
                    string a = Console.ReadLine();
                    
                    Console.WriteLine("Quel est le premier nombre du calcul");
                    int b = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Quel est le second nombre du calcul");
                    int c = Convert.ToInt32(Console.ReadLine());

                    int oe = CalculSimple.Calcul("a", b, c);
                    Console.WriteLine("Le résultat est : " + oe );
                    string resultat = b.ToString() + " " + a + " " + c.ToString() + " = " + oe;
                    
                    
                    break;
                
            }
        }
    }
}