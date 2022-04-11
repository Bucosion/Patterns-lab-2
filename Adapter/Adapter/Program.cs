using System;
using System.Threading.Tasks;

namespace Adapter
{
     class Program
     {
          static void Main(string[] args)
          {
               // calator
               Driver driver = new Driver();
               // masina
               Auto auto = new Auto();
               // start calatorie
               driver.Travel(auto);
               Console.WriteLine("-Drumul s-a sfarsit, masina nu mai poate merge prin nisip");
               // am ajuns la nisip, trebuie de trecut la camila
               Camel camel = new Camel();
               // folosim adapterul
               ITransport camelTransport = new CamelToTransportAdapter(camel);
               // continua drumul pe nisipul desertului
               driver.Travel(camelTransport);

               Console.Read();
          }
     }
}
