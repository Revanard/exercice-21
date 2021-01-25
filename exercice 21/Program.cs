using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez le nom d'une ville : ");
            string ville = (Console.ReadLine());
            Console.Write("Entrez le nombre d'habitants : ");
            string habitant = (Console.ReadLine());
            // affichage du nom de la ville et du nombre d'habitants

            Console.Write(ville + " possède"+habitant+ "habitants.");
            Console.ReadLine();



        }
    }
}
