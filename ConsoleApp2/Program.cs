using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Zabiljeska biljeska = new Zabiljeska("Biljeska");
            Zabiljeska note = new Zabiljeska("Ron", "Biljeska2");
            Zabiljeska businessCard = new Zabiljeska("Lena", "Biljeska3", 6);

            Console.WriteLine(biljeska.GetAutor());
            Console.WriteLine(biljeska.GetTekst());

            Console.WriteLine(note.GetAutor());
            Console.WriteLine(note.GetTekst());

            Console.WriteLine(businessCard.GetAutor ());
            Console.WriteLine(businessCard.GetTekst());


            ZabiljeskaDodatnoVrijeme zabiljeska = new ZabiljeskaDodatnoVrijeme("ena", "tekst", 0);
            Console.WriteLine(zabiljeska.ToString());

            List<ZabiljeskaDodatnoVrijeme> zadatak = new List<ZabiljeskaDodatnoVrijeme>();
            ToDoLista sadasnjiZadatak = new ToDoLista(zadatak);

            string autor;
            string tekst;
            int razinaVaznosti;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Unesite ime:  ");
                autor = Console.ReadLine();

                Console.WriteLine("Unesite svoju biljesku:  ");
                tekst = Console.ReadLine();

                Console.WriteLine("Razina vaznosti? (od 0 do 10):");
                razinaVaznosti = Convert.ToInt32(Console.ReadLine());
                sadasnjiZadatak.DodajZadatak(autor, tekst, razinaVaznosti);
            }

            Console.WriteLine(sadasnjiZadatak.GetSveZadatke());

            int maxPriorityIndex = 0;
            int maxValue = zadatak[0].GetRazinaVaznosti();
            for (int i = 0; i <= zadatak.Count; i++)
            {
                maxValue = zadatak[i].GetRazinaVaznosti();
                maxPriorityIndex = i;
                for (int j = 0; j < zadatak.Count; j++)
                {
                    if (zadatak[j].GetRazinaVaznosti() > maxValue)
                    {
                        maxValue = zadatak[j].GetRazinaVaznosti();
                        maxPriorityIndex = j;
                    }
                }
                sadasnjiZadatak.ZavrsenZadatak(maxPriorityIndex);
            }
            sadasnjiZadatak.ZavrsenZadatak(0);

            Console.WriteLine(sadasnjiZadatak.GetSveZadatke());

        }
    }
}
