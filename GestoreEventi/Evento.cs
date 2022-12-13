using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
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
        public Evento(string titolo, string data, int capienzaMassima, int numeroPostiPrenotati)
        {
            SetTitolo(titolo);
            SetDataEvento(data);
            this.capienzaMassima = capienzaMassima;
            this.numPostiPrenotati = 0;
        }

        //GETTERS
        public string GetTitolo()
        {
            return this.titolo;
        }

        public DateTime GetData()
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
        public void SetTitolo(string titolo)
        {
            if(titolo.Trim() == "" || titolo.Length == 0)
            {
                throw new Exception("Insert the correct title!");
            }
            else
            {
                this.titolo = titolo;
            }
        }

        //METODI PUBBLIC
        public void SetDataEvento(string datastring)
        {
            DateTime dataAttuale = DateTime.Now;

            DateTime dataInput = DateTime.Parse(datastring);
            if (dataInput <= dataAttuale)
            {
                throw new Exception("Data invalid or Date expired!");
            }
            else
            {
                this.data = dataInput;
            }
        }
        public void NumPostiPrenotati(int numPostiPrenotati)
        {
            int numPostiDisponibili = this.capienzaMassima - this.numPostiPrenotati;
            if(numPostiDisponibili == 0 || numPostiPrenotati > numPostiDisponibili)
            {
                throw new Exception("Not Available! Event fully booked");
            }
            else
            {
                this.numPostiPrenotati += numPostiPrenotati;
            }
        }
        public void DisdiciPosti(int numPostiPrenotati)
        {
            if(this.numPostiPrenotati == 0)
            {
                throw new Exception("Not possible to cancel the seats for the Event");
            }
            else
            {
                this.numPostiPrenotati -= numPostiPrenotati;
            }
        }
        public override string ToString()
        {
            string datastring = this.data.ToString("dd/MM/yyyy");
            return datastring + "-" + this.titolo;
        }
    }
}
