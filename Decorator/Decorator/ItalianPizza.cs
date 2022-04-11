using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
     class ItalianPizza : Pizza
     {
          public ItalianPizza() : base("Pizza italiana")
          { }
          public override int GetCost()
          {
               return 10;
          }
     }
}
