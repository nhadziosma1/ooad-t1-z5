using System;

namespace ooad_t1_z5
{
    class Program
    {
        public static bool daLiJePalindrom(String unos)
        {
            char[] zanemariviZankovi = { ' ', ',', '.', '!', '?', ';', ':' };
            string[] podstringovi = unos.Split(zanemariviZankovi);
            unos= String.Concat(podstringovi).ToLower();

            int pocetak = 0, kraj = unos.Length-1;
            while (pocetak < kraj)
            {
                char prvi, zadnji;

                prvi = unos[pocetak];
                zadnji = unos[kraj];

                if (prvi.Equals(zadnji) == false)
                    return false;

                pocetak++;
                kraj--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite izrez/recenicu, da bi provjerili da li se radi o palindromu: ");
            String unos = Console.ReadLine();
            Console.WriteLine("Uneseni izaz/recenica {0} palindrom", daLiJePalindrom(unos));

            Console.ReadLine();
        }
    }
}
