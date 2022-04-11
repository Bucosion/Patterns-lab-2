using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
     // clasa masinii
     class Auto : ITransport
     {
          public void Drive()
          {
               Console.WriteLine("Calatorul conduce masina pe drum");
          }
     }
}
