using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.U1_W1_D2.OOP__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CV cv = new CV();

            InformazioniPersonali Nicola = new InformazioniPersonali();
            Nicola.Nome = "Nicola";
            Nicola.Cognome = "Lerra";
            Nicola.Email="nicolalerra@gmail.com";
            Nicola.Telefono = "388 758****";


            cv.informazioniPersonali = Nicola;

            Studi studi = new Studi();

            studi.qualifica = "Mediatore Linguistico";
            studi.istituto = "Icotea";
            studi.tipo = "Linguistico";
            studi.Dal = new DateTime(2019, 09, 04);
            studi.Al = new DateTime(2022, 03, 10);

            cv.StudiEffettuati.Add(studi);


            ImpiegoAttuale nuovoImpiego = new ImpiegoAttuale();

            EsperienzaAttuale nuovaEsperienza = new EsperienzaAttuale();
            nuovaEsperienza.azienda = "Epicode Shool";
            nuovaEsperienza.jobTitle = "Junior Full Stack";
            nuovaEsperienza.Dal = new DateTime(2022, 08, 29);
            nuovaEsperienza.Al = new DateTime(2023, 06, 29);
            nuovaEsperienza.descrizione = "Junior Full Stack Developer in apprendimento";
            nuovaEsperienza.compiti = "Creazione app e siti web ";

            nuovoImpiego.esperienzaAttuale = nuovaEsperienza;


            Impiego impiego = new Impiego();

            Esperienza compositore = new Esperienza();
            compositore.azienda = "Film Music Score";
            compositore.jobTitle = "Compositore";
            compositore.Dal = new DateTime(2013);
            compositore.Al = new DateTime(2022);
            compositore.descrizione = "Composizione di colonne sonore per prodotti audioviivi";
            compositore.compiti = "compositore";

            impiego.esperienza = compositore;

            
           

            cv.Impieghi.Add(impiego);
            cv.ImpieghoAttuale.Add(nuovoImpiego);
           
            cv.StampaDettagliCVSuSchermo();
            Console.ReadLine();




        }


    }
}
