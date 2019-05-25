using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Heranca
{
    class Animal
    {
        public String Nome { set; get; }

        public Animal() { }

        // VIRTUAL: PERMITE QUE A CLASSE FILHA SOBREESCREVA O METODO
        public virtual void EmiteSom()
        {
            Console.Beep(659, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(375);
            Console.Beep(392, 125);
            Thread.Sleep(375);
            Console.Beep(523, 125);
        }

        public virtual String Movimenta()
        {
            return "Deslocou-se ...";
        }
    }
}
