using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyackredisi = new İhtiyacKrediManager();         
           IKrediManager tasitkredsi = new TasitKrediManager();         
          IKrediManager konutkredisi = new KonutKrediManager();
            BasvuruManager basvuruyap = new BasvuruManager();
       IlogerrService databaselogger = new DatabaseLoggerService();
            IlogerrService filelogger = new FileLoger();
            basvuruyap.BavuruYap(ihtiyackredisi,databaselogger);
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyackredisi,tasitkredsi,konutkredisi };
          //  basvuruyap.OnBilgilendirmeYap(krediler);
            Console.Read();
        }
    }
}
