using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Cachorro : Animal
    {
        public String Pelagem { set; get; }

        public Cachorro() { }

        public override String EmiteSom()
        {
            return "Late ...";
        }
    }
}
