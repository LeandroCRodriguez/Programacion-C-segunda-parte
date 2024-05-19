using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public enum EFranja
    {
        Franja1,
        Franja2,
        Franja3
    }
    public class Provincial : Llamada
    {

        protected EFranja franjaHoraria;

        public Provincial(Llamada llamada, EFranja miFranja)
            :this(llamada.Duracion, llamada.NroDestino,llamada.NroOrigen,miFranja)
        {

        }
        public Provincial(float duracion, string nroDestino, string nroOrigen, EFranja miFranja)
            : base(duracion, nroDestino, nroOrigen)
        {
            franjaHoraria = miFranja;
        }

        
        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            float costo = 0;

            switch (franjaHoraria)
            {
                case EFranja.Franja1:
                    costo = duracion * 0.99f;
                    break;
                case EFranja.Franja2:
                    costo = duracion * 1.25f;
                    break;
                case EFranja.Franja3:
                    costo = duracion * 0.66f;
                    break;
                default:
                    break;
            }
            return costo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine("Llamada Provincial");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo:{CostoLlamada}");
            sb.AppendLine($"Franja:{franjaHoraria}");

            return sb.ToString();
        }
    }
}
