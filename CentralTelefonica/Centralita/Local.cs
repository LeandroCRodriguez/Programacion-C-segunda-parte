using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;


        public Local(Llamada llamada, float costo) 
            :this(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen,costo)
        {

        }
        public Local(float duracion, string nroDestino, string nroOrigen, float costo) 
            : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public float CostoLlamada
        {
            get { return costo; }
        }

        private float CalcularCosto()
        {
            return duracion*costo;
        }

        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar()); // Llama al método Mostrar de la clase base
            sb.AppendLine($"Costo de la llamada: ${CostoLlamada}");
            return sb.ToString();
        }

    }
}
