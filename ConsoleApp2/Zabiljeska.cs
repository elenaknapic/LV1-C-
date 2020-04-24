using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Zabiljeska
    {

        private String tekst;
        private String autor;
        private int razinaVaznosti;

        public string GetAutor()
        {
            return this.autor;
        }

        public string GetTekst()
        {
            return this.tekst;
        }
        public int GetRazinaVaznosti()
        {
            return this.razinaVaznosti;
        }
        public void SetTekst(string tekst)
        {
            this.tekst = tekst;
        }
        public void SetRazinaVaznosti(int razinaVaznosti)
        {
            this.razinaVaznosti = razinaVaznosti;
        }


        // Z4 set autor na private
        private void SetAutor(string autor)
        {
            this.autor = autor;
        }


     

        public Zabiljeska(string autor, string tekst, int razinaVaznosti)
        {
            this.autor = autor;
            this.tekst = tekst;
            this.razinaVaznosti = razinaVaznosti;
        }

        public Zabiljeska(string autor, string tekst)
        {
            this.autor = autor;
            this.tekst = tekst;
            razinaVaznosti = 2;
        }
        public Zabiljeska(string tekst)
        {

            this.tekst = tekst;
            autor = "Elena";
            razinaVaznosti = 0;
        }

        // Z3 atribut postavljen na prazan string 
        public Zabiljeska()
        {
            tekst = "   ";
            autor = "   ";
            razinaVaznosti = 10;
        }

        //Z5
        public override string ToString()
        {
            return this.autor +   "  ,  "   +   this.razinaVaznosti;
        }




    }
}
