using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga_vs_Conejo
{
    class correr
    {
        protected int _numero;
        protected int _posicion;//Solo en clases que heredan
        private static Random gen = new Random();
        public correr (int numero)
        {
            _numero = numero;
            _posicion = 0;
        }
        public int Numero
        {
            get { return _numero; }
        }

        public int Posicion
        {
            get { return _posicion; }
        }
        public  int Correr()
        {
           int x= gen.Next(1, 21);
            return x;
        }
        /*public override string ToString()
        {
          //  return "Liebre numero" + _numero.ToString() + "Esta en la posicion  " + _posicion.ToString() + "              Tortuga numero: " + _numero + "      Esta en la posicion: " + _posicion.ToString()+Environment.NewLine;
        }*/
    }
}
