using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
     // clasa camilii
     class Camel : IAnimal
     {
          public void Move()
          {
               Console.WriteLine("Calatorul a trecut la camila pentru a trece desertul");
          }
     }
}
