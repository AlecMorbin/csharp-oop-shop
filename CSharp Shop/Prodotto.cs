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
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private float iva;

        //Costruttore
        public Prodotto(string nome ,string descrizione ,float prezzo ,float iva)
        {
            this.codice = codeGenerator();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
        //Metodi di accesso

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public void setPrezzo(float prezzo)
        {
            this.prezzo=prezzo;
        }

        public void setIva(float iva)
        {
            this.iva=iva;
        }

        public int getCodice()
        {
            return codice;
        }

        public string getNome()
        {
            return nome;
        }

        public string getDescrizione()
        {
            return descrizione;
        }

        public float getPrezzo()
        {
            return prezzo;
        }

        public float getIva()
        {
            return iva;
        }

        //Metodi utili e interni
        private int codeGenerator()
        {
            Random random = new Random();
            return  random.Next(10000);
        }

        override
        public string ToString()
        {
            return "Prodotto:\n" +
                    "Codice: " + formattaCodice() + "\n" +
                    "Nome: '" + nome + "'\n" +
                    "Descrizione: '" + descrizione + "'\n" +
                    "Prezzo: " + prezzo + "\n" +
                    "Prezzo con Iva: " + prezzoIva() + "\n";
        }

        public float prezzoIva()
        {
            return prezzo+(prezzo*iva);
        }

        public string nomeEsteso()
        {
            return "Nome esteso:\t" + codice + " - " + nome + "\n";
        }

        private string formattaCodice()
        {
            string result = "";
            
            result = codice.ToString();
            for (int i = 0; i < 8; i++)
            {
                if (result.Length < 8)
                    result = "0" + result;
            }
            //converto in stringa e faccio i controlli e le modifiche neccessarie in questo modo altrimenti
            //anche aggiunendo gli zeri da intero verrebbe comunque letto senza gli zeri aggiunti
            return result;
        }
    }
}
