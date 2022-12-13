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
        private int numeroPostiPrenotati;

        public Evento(string titolo, DateTime data, int capienzaMassima, int numeroPostiPrenotati)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMassima = capienzaMassima;
            this.numeroPostiPrenotati = 0;
        }

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
            return this.numeroPostiPrenotati;
        }
    }
}
