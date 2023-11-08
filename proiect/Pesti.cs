using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiiClase
{
    internal class Pesti: Animal
    {
        public string Culoare_carne;
        public bool depun_oua;


        public Pesti(string nume, int varsta, string culoare_carne, bool depun_oua) : base(nume, varsta)
        {
            this.Culoare_carne = culoare_carne;
            this.depun_oua = depun_oua;

        }

        public override void Sunet()
        {
            Console.WriteLine("Dar unele specii de pesti scot sunete");
        }

        public override string ToString()
        {
            return $"Nume peste {Nume}, are {Varsta} luni, culoare carne: {Culoare_carne}";
        }

       
    }
}
