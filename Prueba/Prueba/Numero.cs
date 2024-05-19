using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Numero
    {
        private int numero;

        private Numero(int numero)
        {
            this.numero = numero;
        }
        public int NumeroLoco
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public static implicit operator Numero(int numero)
        {
            return new Numero(numero);
        }
    }
}