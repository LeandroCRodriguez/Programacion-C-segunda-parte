using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{    
    public class EmpleadoPlantaTransitoria : Empleado
    {
        float sueldoBasico;
        float horasExtras;
        public EmpleadoPlantaTransitoria(string nombre, int dirección, bool estadoCivil, 
            DateTime fechaNacimiento, float sueldoBasico, float ret,float horasExtras) 
            : base(nombre, dirección, estadoCivil, fechaNacimiento, sueldoBasico, ret)
        {
            this.sueldoBasico = sueldoBasico;
            this.horasExtras = horasExtras;
        }

        public override float CalcularSueldoBruto()
        {
            return sueldoBasico + this.horasExtras;
        }

        public override float CalcularRetenciones()
        {
            float obraSocial = 20;
            float aportesJubilatorios = 30;
            return obraSocial + aportesJubilatorios;
        }

        public override float SueldoNeto()
        {
            return CalcularSueldoBruto() - CalcularRetenciones();
        }
    }
}
