using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop
{
    internal class Prodotto
    {
        //attributi
        private int codice { get; }
        private string nome { get; set; }
        private string descrizione { get; set; }
        private float prezzo { get; set; }
        private float iva { get; }

        public Prodotto(string nome ,string descrizione ,float prezzo ,float iva)
        {
            this.codice = codeGenerator();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        private int codeGenerator()
        {
            Random random = new Random();
            return  random.Next();
        }

        override
        public string ToString()
        {
            return "Prodotto:\n" +
                    "Codice: " + codice + "\n" +
                    "Nome: '" + nome + "'\n" +
                    "Descrizione: '" + descrizione + "'\n" +
                    "Prezzo: " + prezzo + "\n" +
                    "Prezzo con Iva: " + prezzoIva() + "\n";
        }

        public float prezzoIva()
        {
            return prezzo+(prezzo*iva);
        }
    }
}
