using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get { return CalcularGanancia(ETipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(ETipoLlamada.Provincial); }
        }

        public float GananciasPorTodas
        {
            get { return CalcularGanancia(ETipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; } //Checkear
        }

        private float CalcularGanancia(ETipoLlamada tipo)
        {
            float acumuladorLocal = 0;
            float acumuladorProvincial = 0;
            foreach (var item in listaDeLlamadas)
            {
                if (ETipoLlamada.Provincial == tipo)
                {
                    acumuladorProvincial += GananciasPorProvincial;
                }
                else if (ETipoLlamada.Local == tipo)
                {
                    acumuladorLocal += GananciasPorLocal;
                }
            }
            float retorno = 0;
            switch (tipo)
            {
                case ETipoLlamada.Local:
                    retorno = acumuladorLocal;
                    break;
                case ETipoLlamada.Provincial:
                    retorno = acumuladorProvincial;
                    break;
                case ETipoLlamada.Todas:
                    retorno = acumuladorLocal + acumuladorProvincial;
                    break;
                default:
                    break;
            }

            return retorno;
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Razon Social: {razonSocial}");
            foreach (var item in listaDeLlamadas)
            {
                if (item is Local l)
                {
                    sb.AppendLine(l.Mostrar());
                }
                else if (item is Provincial p)
                {
                    sb.AppendLine(p.Mostrar());
                }
            }
            return sb.ToString();
        }
    }
}

