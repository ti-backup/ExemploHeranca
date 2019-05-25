using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Heranca
{
    class Cachorro : Animal
    {
        public String Pelagem { set; get; }

        public Cachorro() { }

        // EXEMPLO POLIMORFISMO
        public override void EmiteSom()
        {
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(250);
            Console.Beep(392, 125);
            Thread.Sleep(250);
            Console.Beep(330, 125);
            Thread.Sleep(250);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
        }

        // EXEMPLO POLIMORFISMO
        public override String Movimenta()
        {
            // EXECUTA O METODO DEFINIDO NO PAI E COMPLEMENTA
            return base.Movimenta() + " caminhando";
        }
    }
}
