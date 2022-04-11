using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
     // adaptor de la Camel la ITransport
     class CamelToTransportAdapter : ITransport
     {
          Camel camel;
          public CamelToTransportAdapter(Camel c)
          {
               camel = c;
          }

          public void Drive()
          {
               camel.Move();
          }
     }
}
