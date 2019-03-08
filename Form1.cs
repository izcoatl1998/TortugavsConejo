using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuga_vs_Conejo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tortuga tor = new tortuga(19);
            Liebre lie = new Liebre(13);
            do
            {
                tor.correr();
                lie.correr();
                tablero.Text += Environment.NewLine+ "liebre numero: " + lie.Numero.ToString() + " Posicion: " + lie.Posicion.ToString() +"         La tortuga numero:  "+tor.Numero+"   Totruga posicion: " + tor.Posicion.ToString();
            } while (tor.Posicion <= 99 && lie.Posicion <= 99);
            if (lie.Posicion >= 100)
            {
                label1.Text = "La liebre Gano";
            }
            else if (lie.Posicion >= 100)
            {
                label1.Text = "La tortuga gano";
            }
        }
    }
}
