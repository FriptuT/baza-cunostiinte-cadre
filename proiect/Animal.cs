using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiiClase
{
    internal class Animal
    {
        public string Nume { get; set; }
        public int Varsta { get; set; }

        public Animal(string nume, int varsta)
        {
            Nume = nume;
            Varsta = varsta;
        }

        public virtual void Sunet()
        {
            Console.WriteLine("Animalul scoate sunete.");
        }

        public override string ToString()
        {
            return $"Nume: {Nume}, Varsta: {Varsta}";
        }
    }

}
