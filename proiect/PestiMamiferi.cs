using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiiClase
{
    internal class PestiMamiferi: Mamifer
    {
        public string Culoare_carne { get; set; }
        public bool Depun_oua { get; set; }

        public PestiMamiferi(string nume, int varsta, bool coarne,
                       int kilograme, int inaltime, string stare,
                       actiuni actiune, string culoare_carne, bool depun_oua) : base(nume, varsta,coarne,kilograme,inaltime,stare,actiune)
        {
            Culoare_carne = culoare_carne;
            Depun_oua = depun_oua;
        }

        public override void Sunet()
        {
            Console.WriteLine("Pesti mamiferi precum delfinul,balena scot sunete");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
