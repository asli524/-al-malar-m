using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public  void BavuruYap( IKrediManager kredimanager,IlogerrService Log)
        {
            kredimanager.hesapla();
            Log.Log();
        }
        public void OnBilgilendirmeYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.hesapla();
            }
        }
    }
}
