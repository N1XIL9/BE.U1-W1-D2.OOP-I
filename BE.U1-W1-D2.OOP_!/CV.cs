using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.U1_W1_D2.OOP__
{
    internal class CV
    {
        public InformazioniPersonali informazioniPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; } = new List<Studi>();

        public List<Impiego> Impieghi { get; set; } = new List<Impiego>();
        public List<ImpiegoAttuale> ImpieghoAttuale { get; set; } = new List<ImpiegoAttuale>();

        

        public void StampaDettagliCVSuSchermo()
        {
            Console.WriteLine($"CV DI NICOLA LERRA");
            Console.WriteLine($"");
            Console.WriteLine($"---- INFORMAZIONI PERSONALI ---");
            Console.WriteLine($"");
            Console.WriteLine($"Nome:{informazioniPersonali.Nome}");
            Console.WriteLine($"Cognome:{informazioniPersonali.Cognome}");
            Console.WriteLine($"Email:{informazioniPersonali.Email}");
            Console.WriteLine($"Telefono:{informazioniPersonali.Telefono}");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"---- INIZIO STUDI ---");
            Console.WriteLine($"");
            foreach(Studi item in StudiEffettuati)
            {
                Console.WriteLine($"");
                Console.WriteLine($"Qualifica: {item.qualifica}");
                Console.WriteLine($"Istituto: {item.istituto}");
                Console.WriteLine($"Tipo: {item.tipo}");
                Console.WriteLine($"Dal: {item.Dal}");
                Console.WriteLine($"Al: {item.Al}");
            }

            Console.WriteLine($"");
            Console.WriteLine($"---- ESPERIENZA ATTUALE ---");
            Console.WriteLine($"");
            foreach (ImpiegoAttuale item in ImpieghoAttuale)
            {
                Console.WriteLine($"");
                Console.WriteLine($"Azienda: {item.esperienzaAttuale.azienda}");
                Console.WriteLine($"Ruolo: {item.esperienzaAttuale.jobTitle}");
                Console.WriteLine($"Descizione: {item.esperienzaAttuale.descrizione}");
                Console.WriteLine($"Compiti: {item.esperienzaAttuale.compiti}");
                Console.WriteLine($"Dal: {item.esperienzaAttuale.Dal}");
                Console.WriteLine($"Al: {item.esperienzaAttuale.Al}");
            }

            Console.WriteLine($"");
            Console.WriteLine($"---- ESPERIENZE ---");
            Console.WriteLine($"");
            foreach (Impiego item in Impieghi)
            {
                Console.WriteLine($"");
                Console.WriteLine($"Azienda: {item.esperienza.azienda}");
                Console.WriteLine($"Ruolo: {item.esperienza.jobTitle}");
                Console.WriteLine($"Descizione: {item.esperienza.descrizione}");
                Console.WriteLine($"Compiti: {item.esperienza.compiti}");
                Console.WriteLine($"Dal: {item.esperienza.Dal}");
                Console.WriteLine($"Al: {item.esperienza.Al}");
            }

        }
    }
}
