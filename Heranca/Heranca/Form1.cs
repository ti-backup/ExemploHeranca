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
        List<Animal> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Animal>();
            teste();

            cmbAnimais.Items.Add(lista.ElementAt(0).Nome);
            cmbAnimais.Items.Add(lista.ElementAt(1).Nome);
            cmbAnimais.Items.Add(lista.ElementAt(2).Nome);
        }

        private void teste()
        {
            

            Animal animal = new Animal();
            animal.Nome = "Fera";
            //MessageBox.Show("Animal:");
            //animal.EmiteSom();
            lista.Add(animal);

            Cachorro dog = new Cachorro();
            dog.Nome = "Totó";
            dog.Pelagem = "escura e rala";
            //MessageBox.Show("Cachorro:");
            //dog.EmiteSom();
            lista.Add(dog);

            Cobra snake = new Cobra();
            snake.Nome = "Minhoca";
            snake.Veneno = "fatal";
            //MessageBox.Show("Cobra: ");
            //snake.EmiteSom();
            lista.Add(snake);

            /*
            String resultado = "";
            foreach (Animal temp in lista)
            {
                resultado += temp.Movimenta() + Environment.NewLine;
            }
            txtTeste.Text = resultado;
            */
        }
    }
}
