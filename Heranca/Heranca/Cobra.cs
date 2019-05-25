using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Heranca
{
    class Cobra : Animal
    {
        public String Veneno { set; get; }

        public Cobra() { }

        // EXEMPLO POLIMORFISMO
        public override void EmiteSom()
        {
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(375);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
        }

        // EXEMPLO POLIMORFISMO
        public override String Movimenta()
        {
            // EXECUTA O METODO DEFINIDO NO PAI E COMPLEMENTA
            return base.Movimenta() + " rastejando";
        }
    }
}
