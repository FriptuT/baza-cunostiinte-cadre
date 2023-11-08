using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiiClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================= BEGIN REPTILA =================================");

            Reptila sarpe = new Reptila("Cobra", 3, true, false, 2.25); //1

            Console.WriteLine("Detalii despre " + sarpe.Nume);
            sarpe.interogare(sarpe.Nume, sarpe.solziMari);
            Console.WriteLine("-------");
            sarpe.interogare(sarpe.Nume, sarpe.Varsta);

            Console.WriteLine("========");

            Reptila sarpe2 = new Reptila("Anaconda", 2, true, false, 7.79); //2 

            Console.WriteLine("Detalii despre " + sarpe2.Nume);
            sarpe2.interogare(sarpe2.Varsta, sarpe2.Nume);

            Console.WriteLine("=========");
            Reptila sarpe3 = new Reptila("Piton", 1, true, false, 5.57); //3 
            sarpe3.interogare(sarpe3.Varsta, sarpe3.Nume);

            Console.WriteLine("=========");
            Reptila crocodil = new Reptila("Crocodil", 3, true, false, 7.15); //4
            crocodil.interogare(crocodil.Varsta, crocodil.Nume, crocodil.Marime);

            Console.WriteLine("=========");
            Reptila soparla = new Reptila("Gecko", 3, false, true, 0.50);   // 5
            soparla.interogare(soparla.Varsta, soparla.Nume, soparla.Marime);

            Console.WriteLine("=========");
            Reptila broasca = new Reptila("Broasca testoasa de Florida", 5, false, true, 0.89); //6
            broasca.interogare(broasca.Varsta, broasca.Nume, broasca.Marime);

            Console.WriteLine("========================= END REPTILA =================================");

            Console.WriteLine("========================= BEGIN MAMIFER =================================");


            Mamifer pisica = new Mamifer("Tom", 3, false, 3, 20, "cuminte", Mamifer.actiuni.mangaie); // 7
            
            Console.WriteLine(pisica.ToString());
            pisica.interogare_mici(pisica.Varsta, pisica.Kilograme);
            pisica.interogare_mici(pisica.Nume, pisica.Stare, pisica.Actiune);
            Console.WriteLine("========");

            Mamifer caine = new Mamifer("Omni", 4, false, 7, 45, "musca", Mamifer.actiuni.fugi); // 8
            Console.WriteLine(caine.ToString());
            caine.interogare_mici(caine.Varsta, caine.Kilograme);
            caine.interogare_mici(caine.Nume, caine.Stare, caine.Actiune);

            Console.WriteLine("========");

            Mamifer elefant = new Mamifer("eli", 10, false, 1000, 500, "nervos", Mamifer.actiuni.fugi); // 9
            Console.WriteLine(elefant.ToString());
            caine.interogare_mici(elefant.Varsta, elefant.Kilograme);
            caine.interogare_mici(elefant.Nume, elefant.Stare, elefant.Actiune);
            Console.WriteLine("========");


            Mamifer hipopotam = new Mamifer("hipo", 15, false, 500, 200, "nervos", Mamifer.actiuni.fugi); // 10
            Console.WriteLine(hipopotam.ToString());
            caine.interogare_mici(hipopotam.Varsta, hipopotam.Kilograme);
            caine.interogare_mici(hipopotam.Nume, hipopotam.Stare, hipopotam.Actiune);

            Console.WriteLine("========================= END MAMIFER =================================");
            Console.WriteLine("========================= BEGIN PESTI CARE DEPUN OUA =================================");

            Pesti somon = new Pesti("somon", 1, "portocalie", true); // 11
            Console.WriteLine(somon.ToString());

            Console.WriteLine("========================= END PESTI CARE DEPUN OUA =================================");

            Console.WriteLine("========================= BEGIN PESTI MAMIFERI =================================");

            PestiMamiferi delfin = new PestiMamiferi("delfin", 3, false, 250, 100, "cuminte", PestiMamiferi.actiuni.mangaie, "alba", false); // 12
            Console.WriteLine(delfin.ToString());


            Console.ReadKey();
        }
    }


}
