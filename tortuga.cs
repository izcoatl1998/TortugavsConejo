using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga_vs_Conejo
{
    class tortuga:correr
    {
        public tortuga(int numero) : base(numero)
        {

            this._posicion = 0;
        }
        public void correr()
        {
            int avance = base.Correr();
            if (avance <= 9)
                _posicion += 3;
            else if (avance <= 12)
                _posicion += 6;
            else if (avance <= 16)
                if (_posicion-5 < 0)
                {
                    avance = 0;
                }
                else
                {
                    _posicion -= 5;
                }

                else if (avance <= 20)
                if (_posicion-9 < 0)
                {
                    avance = 0;
                }
                else
                {
                    _posicion -= 9;
                }
        }
    }
}
