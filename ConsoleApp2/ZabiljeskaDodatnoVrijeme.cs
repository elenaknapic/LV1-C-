using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Z6
namespace ConsoleApp2
{
    class ZabiljeskaDodatnoVrijeme : Zabiljeska   //nasljeduje klasu zabiljeska
    {
        private DateTime datum; //objekt za pohranu vremena

        //s base pristupamo objektima iz base klase
        //za pohranu vremena koristiti objekt DateTime klase
        public ZabiljeskaDodatnoVrijeme(string autor, string tekst, int razinaVaznosti) : base(autor,tekst,razinaVaznosti)
        {
            datum = DateTime.Now;
        }

        /* omogućiti postavljanje vremena na novom objektu 
         i promjenu vremena na postojećem objektu.*/
        public ZabiljeskaDodatnoVrijeme(string autor, string tekst, int razinaVaznosti, int dan, int mjesec, int godina) : base(autor,tekst,razinaVaznosti)
        {
            datum = new DateTime(dan, mjesec,godina);
        }

        public DateTime Datum
        {
            get => datum; set => datum = value;
        }

        /*ToShortDateString converts the value of the current DateTime 
        object to its equivalent short date string representation.*/
        // override tako da uz prethodne vrijednosti ukljucuje i vrijeme zadano za zabiljesku

        public override string ToString()
        {
            return base.ToString() +    datum.ToShortDateString();
        }
    }
}
