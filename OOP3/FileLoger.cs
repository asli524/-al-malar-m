using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class FileLoger:IlogerrService
    {
           void IlogerrService.Log()
        {
            Console.WriteLine("dosya loglandı");
        }
    }
}
