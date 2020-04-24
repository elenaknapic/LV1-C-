using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Z6 Z7
namespace ConsoleApp2
{
    class ToDoLista
    {
        private List<ZabiljeskaDodatnoVrijeme> zadatak = new List<ZabiljeskaDodatnoVrijeme>();

        public ToDoLista(List<ZabiljeskaDodatnoVrijeme> zadatak)
        {
            this.zadatak = zadatak;
        }
        //Z7
        public void DodajZadatak(string autor, string tekst, int razinaVaznosti)
        {
            ZabiljeskaDodatnoVrijeme noviZadatak = new ZabiljeskaDodatnoVrijeme(autor, tekst, razinaVaznosti);
            zadatak.Add(noviZadatak);
        }
        //Z7
        public void ZavrsenZadatak(int index)
        {
            zadatak.Remove(zadatak[index]);
        }

        public ZabiljeskaDodatnoVrijeme GetZabiljeska(int index)
        {
            if ((index <= zadatak.Count) && index >= 0)
            {
                return zadatak[index];
            }
            return null;
        }

        public string GetSveZadatke()
        {
            string output = "    ";
            for (int i = 0; i < zadatak.Count; i++)
            {
                output += zadatak[i].ToString() + "\n";
            }
            return output;
        }

    }
}
