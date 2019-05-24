using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Animal
    {
        public String Nome { set; get; }

        public Animal() { }

        public virtual String EmiteSom()
        {
            return "Ruído ...";
        }
        public String Movimenta()
        {
            return "Deslocou-se ...";
        }
    }
}
