using System;
using System.ComponentModel.Design;

namespace Exercice_01
{
    internal class Program
    {

        public static string[] films = ["Starwars", "Lord of the ring", "The matrix", "Mad max"];
        public static int[] places = [7, 12, 0, 4];

        public static void AfficherFilm(bool afficherComplet = true)
        {
            Console.Clear();
            for (int i = 0; i < films.Length; i++)
            {
                string disponible = $"{places[i]} places disponibles";

                if (places[i] == 0)
                {
                    disponible = "complet";
                    Console.WriteLine("Veuillez choisir un autre film");
                }

                if (afficherComplet || places[i] > 0)
                {
                    Console.WriteLine($"{i + 1} - {films[i]} - {disponible}");
                }

                


                    Console.WriteLine($"{i + 1} - {films[i]} - {disponible}");
            }
        }
        public static void ListeFilms()
        {
            Console.Clear();
            
            Console.WriteLine("=============== Liste des films ================");
            Console.WriteLine("1. Starwars - 7 places disponibles");
            Console.WriteLine("2. Lord of the ring - 12 places disponibles");
            Console.WriteLine("3. The matrix - complet");
            Console.WriteLine("4. Mad max - 4 places disponibles");

            
            Console.WriteLine("=================================");
            
            
        }

        public static void ChoisirFilms()
        {
            Console.Clear();

            AfficherFilm();
            Console.WriteLine("========== Réserver une place ============");
            
            Console.WriteLine("Veuillez choisir un numéro de film");
            int numeroFilm = Convert.ToInt32(Console.ReadLine());
            if (places[numeroFilm] == 0)
            {
                
                Console.WriteLine("Veuillez choisir un autre film");
            }

            else
            {
                places[numeroFilm - 1]--;
                Console.WriteLine("Une place a été réservé pour vous. Appuyez sur une touche pour revenir au menu principal");
            }
                
            Console.WriteLine("==========================================");
            
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
            
            char action = ' ';
            Console.WriteLine("====== Cinéma ======");
            Console.WriteLine("1. Afficher les films");
            Console.WriteLine("2. Réserver une place");
            Console.WriteLine("3. Sortir");
            Console.WriteLine("=====================");
            Console.WriteLine("Veuillez choisir une option : " + action);
            action = Convert.ToChar(Console.ReadLine());
          
            
                if (action == '1')
                {
                    ListeFilms();
                    Console.ReadKey();
                }

                else if (action == '2')
                {
                    ChoisirFilms();
                }

                else if (action == '3')
                {
                    break;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Veuillez choisir une option valide");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
            
            }

        }
    }
}
