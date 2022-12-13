using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int numPostiPrenotati;

        //COSTRUTTORE
        public Evento(string titolo, DateTime data, int capienzaMassima, int numeroPostiPrenotati)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMassima = capienzaMassima;
            this.numPostiPrenotati = 0;
        }

        //GETTERS
        public string Gettitolo()
        {
            return titolo;
        }

        public DateTime Data()
        {
            return this.data;
        }
        public int GetCapienzaMassima()
        {
            return this.capienzaMassima;
        }
        public int GetPostiPrenotati()
        {
            return this.numPostiPrenotati;
        }

        //SETTERS
        public void SetTitolo()
        {
            if(titolo.Trim() == "")
            {
                this.titolo = titolo;
            }
            else
            {
                throw new Exception("Inserire il titolo corretto");
            }
        }
        public void SetData()
        {
            DateTime data = DateTime.
        }
    }
}
