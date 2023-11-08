using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiiClase
{
    internal class Mamifer: Animal
    {

        public enum actiuni
        {
            hraneste,
            mangaie = 1,
            fugi = 2 

        }
        public bool Coarne { get; set; }
        public int Kilograme { get; set; }
        public int Inaltime { get; set; }
        
        public string Stare { get; set; }
        public actiuni Actiune { get; set; }



        public List<string> MamifereMici = new List<string>
        {
            "caine",
            "pisica",
            "iepure",
            "mistret",
            "capra"
        };

        public List<string> MamifereMari = new List<string>
        {
            "elefant",
            "hipopotam",
            "rinocer",
            "Cerb",
            "Antilopa"
        };

        public List<string> stariMamifer = new List<string>
        {
            "cuminte",
            "zgarie",
            "nervos",
            "musca"
        };

        public List<string> numeMamifer = new List<string>
        {
            "Tom",
            "Omni",
            "eli",
            "hipo"
        };


        public Mamifer(string nume, int varsta, bool coarne, 
                       int kilograme, int inaltime, string stare,
                       actiuni actiune) : base(nume, varsta)
        {
            Coarne = coarne;
            Kilograme = kilograme;
            Inaltime = inaltime;
            Stare = stare;
            Actiune = actiune;


        }

        public override void Sunet()
        {
            Console.WriteLine("Mamiferul scoate sunete.");
        }

        public override string ToString()
        {
            if (Coarne == true && Kilograme >= 200)
            {
                return $"{Nume} are {Varsta} ani si este un mamifer mare cu coarne";
            }
            else if (Coarne == true && Kilograme < 200)
            {
                return $"{Nume} are {Varsta} ani si este un mamifer mic cu coarne";
            }
            else if (Coarne == false && Kilograme >= 200)
            {
                return $"{Nume} are {Varsta} ani si este un mamifer mare fara coarne";
            }
            else
            {
                return $"{Nume} are {Varsta} ani si este un mamifer mic fara coarne";
            }
        }

        public void interogare_mici(int varsta, int kilograme)
        {
            if (varsta > 3 || kilograme >= 50)
            {
                Console.WriteLine("Este vorba despre un adult");
            }
            else if(varsta < 3 || kilograme < 50)
            {
                Console.WriteLine("Este vorba despre un pui");
            }
        }

        public void interogare_mici(string nume, string stare, actiuni actiune)
        {
            if (numeMamifer.Contains(nume) && stariMamifer.Contains(stare))
            {
                Console.WriteLine("Este " + nume + " si " + stare);
                Console.WriteLine(" deci " + actiune);
            }
        }
    }
}
