using System;

namespace lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar
 In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
             */
            Console.WriteLine("introduceti un numar intreg");

            int numar = int.Parse(Console.ReadLine());


            int jumatateaNumarului = numar/2;
            int dublulJumatatii = jumatateaNumarului * 2;

            if (numar == dublulJumatatii)
                Console.WriteLine("par");
            else
                Console.WriteLine("impar");
            /*
            deodorant: prima varianta a fost fara google search ref odd and even in c#, asta e dupa search :) ambele dau corect la numere intregi)
            int zecimale;
            zecimale = numar % 2;
            if (zecimale == 0 )
                Console.WriteLine("par");
            else
                Console.WriteLine("impar");
            */
        }

    }
}
