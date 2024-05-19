using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EmpleadoPlantaPermanente : Empleado
    {
        int cantidadHijos;
        int antiguedad;
        float sueldoBasico;

        public EmpleadoPlantaPermanente(string nombre, int dirección, bool estadoCivil,
            DateTime fechaNacimiento, float sueldoBasico, float ret, int cantidadHijos, 
            int antiguedad) 
            : base(nombre, dirección, estadoCivil, fechaNacimiento, sueldoBasico, ret)
        {
            this.antiguedad = antiguedad;
            this.cantidadHijos = cantidadHijos;
            this.sueldoBasico = sueldoBasico;
            
        }

        public override float CalcularSueldoBruto()
        {
            float asignacionPorHijo=30;
            float asignacionPorconyuge=30;
            float antiguedad=20;
            float salarioFamiliar = 100;
            return sueldoBasico + salarioFamiliar + asignacionPorHijo + asignacionPorconyuge + antiguedad;
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
