using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiiClase
{
    internal class Reptila: Animal
    {
        public bool solziMari { get; set; }
        public bool solziMici { get; set; }

        public double Marime { get; set; }

        public List<string> listaDeReptileMari = new List<string>
        {
            "Anaconda",
            "Piton",
            "Crocodil",
            "Aligator",
            "Caiman"
        };

        public List<string> listaDeReptileMici = new List<string>
        {
            "Gecko",
            "Soparla Anolis",
            "Serpii de nisip",
            "Serpii de iarba",
            "Broasca testoasa de Florida"
        };

        public Reptila(string nume, int varsta, bool solzi_mari, bool solzi_mici, double marime) : base(nume, varsta)
        {
            solziMari = solzi_mari;
            solziMici = solzi_mici;
            Marime = marime;

        }

        public override void Sunet()
        {
            Console.WriteLine("Reptila scoate sunete");
        }

        public override string ToString()
        {
            if (solziMari)
            {
                return base.ToString() + $", are solzi mari";
            }
            else
            {
                return base.ToString() + $", are solzi mici care abia se vad";
            }
        }

        public void interogare(string nume, bool solzi_mari)
        {
            if (solzi_mari)
            {
                Console.WriteLine($"{nume} are solzi mari sau mici ?");
                Console.WriteLine("Are solzi mari");
            }
            else
            {
                Console.WriteLine("Are solzi mici");
            }
        }

        public void interogare(string nume, int varsta)
        {
            Console.WriteLine($"{Nume} are solzi mari sau mici?");
            Console.WriteLine("Acest lucru depinde de varsta reptilei");
            if (varsta > 2)
            {
                solziMari = true;
                Console.WriteLine("Are peste 2 ani, deci solzii sunt mari");
            }
            else
            {
                solziMici = true;
                Console.WriteLine("Are sub 2 ani, deci solzii sunt mici");
            }
        }

        public void interogare(int varsta, string nume)
        {
            Console.WriteLine($"{Nume} are solzi mari sau mici?");

            if (listaDeReptileMari.Contains("Crocodil") || listaDeReptileMari.Contains("Aligator")
                || listaDeReptileMari.Contains("Caiman") || listaDeReptileMari.Contains("Anaconda")
                || listaDeReptileMari.Contains("Piton"))
            {
                solziMari = true;
                Console.WriteLine("Aceasta reptila are solzi mari indiferent de varsta");
            }
        }

        public void interogare(int varsta, string nume, double marime)
        {
            Console.WriteLine($"{Nume} are solzi mari sau mici?");

            if (listaDeReptileMici.Contains(Nume))
            {
                solziMici = true;
                Console.WriteLine("Aceasta reptila are solzi mici indiferent de varsta");
            }
            else if (listaDeReptileMari.Contains(Nume))
            {
                solziMari = true;
                Console.WriteLine("Aceasta reptila are solzi mari indiferent de varsta");
            }

            if (marime > 5)
            {
                Console.WriteLine("De asemenea mai putem spuene ca este o reptila mare");
            }
            else
            {
                Console.WriteLine("De asemenea mai putem spune ca este o reptila mica");
            }
        }
    }
}
