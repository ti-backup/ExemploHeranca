using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            teste();
        }

        private void teste()
        {
            Animal animal = new Animal();
            animal.Nome = "Fera";
            MessageBox.Show("Animal: " + animal.EmiteSom());

            Cachorro dog = new Cachorro();
            dog.Nome = "Totó";
            dog.Pelagem = "escura e rala";
            MessageBox.Show("Cachorro: " + dog.EmiteSom());

            Cobra snake = new Cobra();
            snake.Nome = "Minhoca";
            snake.Veneno = "fatal";
            MessageBox.Show("Cobra: " + snake.EmiteSom());
        }
    }
}
